using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Modelos;
using System.Data;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Datos
{
    public class ConexionOpenXML
    {
        public string errorActual = "";
        private static List<char> Letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };
        public bool escribirExcel(DataTable table, string p_direccionDeArchivo)
        {
            try
            {
                using (var workbook = SpreadsheetDocument.Create(p_direccionDeArchivo, SpreadsheetDocumentType.Workbook))
                {
                    #region Inicialización de workbook
                    var workbookPart = workbook.AddWorkbookPart();
                    workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();
                    workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();
                    var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                    var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                    sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);
                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                    string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);
                    uint sheetId = 1;
                    DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = "Export" };
                    sheets.Append(sheet);
                    #endregion

                    #region Inserta nombre de atributo en columna
                    DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                    List<String> columns = new List<string>();
                    int rowNumber = 1;
                    int columnIndex = 0;
                    foreach (DataColumn column in table.Columns)
                    {
                        columns.Add(column.ColumnName);

                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName);
                        //cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.InlineString;
                        //cell.InlineString = new InlineString() { Text = new Text(column.ColumnName) };

                        cell.CellReference = Letters[columnIndex] + rowNumber.ToString();
                        headerRow.AppendChild(cell);
                        string v = cell.CellReference.Value;
                        columnIndex++;
                    }

                    sheetData.AppendChild(headerRow);
                    #endregion

                    #region Inserta Datos
                    foreach (DataRow row in table.Rows)
                    {
                        rowNumber++;
                        columnIndex = 0;
                        DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                        foreach (String col in columns)
                        {
                            DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString());
                            //cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.InlineString;
                            //cell.InlineString = new InlineString() { Text = new Text(row[col].ToString()) };
                            cell.CellReference = Letters[columnIndex] + rowNumber.ToString();
                            newRow.AppendChild(cell);

                            columnIndex++;
                        }

                        sheetData.AppendChild(newRow);
                    }
                    #endregion
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool leerExcel(string p_path, List<int?> p_indiceAtributos, ref DataTable p_dataTable, bool p_primeraRowHeaders)
        {
            try
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(p_path, false))
                {
                    #region Inicialización de workbook
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>();
                    #endregion

                    int indiceAux;
                    foreach (Row row in rows)
                    {
                        DataRow tempRow = p_dataTable.NewRow();

                        int cantidadCeldasEnRowActual = row.Descendants<Cell>().Count();
                        for (int i = 0; i < row.Descendants<Cell>().Count(); i++) // < p_indiceAtributos.Count ; i++)
                        {
                            int indiceRealExcel = ConvertColumnNameToNumber(GetColumnName(row.Descendants<Cell>().ElementAt(i).CellReference));

                            indiceAux = Convert.ToInt32(p_indiceAtributos[indiceRealExcel]);
                            if (p_indiceAtributos[indiceRealExcel] == null)
                            { continue; }

                            tempRow[indiceAux] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                        }

                        p_dataTable.Rows.Add(tempRow);
                    }

                }
                if (p_primeraRowHeaders)
                {
                    p_dataTable.Rows.RemoveAt(0); //quitamos headers de atributos
                }
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
                return false;
            }
            return true;
        }
        public DataTable leerExcel_preview(string p_path, int p_cantidadDeColumnas)
        {
            DataTable lcl_dt_preview = new DataTable();
            try
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(p_path, false))
                {
                    #region Inicialización de workbook
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>();
                    #endregion

                    for (int i = 0; i < p_cantidadDeColumnas; i++) //Crea columnas de dataTablePreview
                    {
                        lcl_dt_preview.Columns.Add();
                    }

                    foreach (Row row in rows)   //Lee las rows del archivo y las pasa al dataTablePreview
                    {
                        DataRow tempRow = lcl_dt_preview.NewRow();

                        for (int i = 0; i < row.Descendants<Cell>().Count() && i < p_cantidadDeColumnas; i++)
                        {
                            /*
                             * indiceRealExcel muestra la relacion correcta del indice columna en excel. Ejemplo: {A,B,C,D,E}->{0,1,2,3,4}
                             * Sin el método excel saltea las columnas sin valor, obteniendo menos indices de los que realmente hay
                             */
                            int indiceRealExcel = ConvertColumnNameToNumber(GetColumnName(row.Descendants<Cell>().ElementAt(i).CellReference));
                            tempRow[indiceRealExcel] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                        }

                        lcl_dt_preview.Rows.Add(tempRow);
                    }
                    if (lcl_dt_preview.Rows.Count < 1)
                    {
                        errorActual = "El archivo seleccionado esta vacío.";
                    }
                }
            }
            catch (Exception ex)
            {
                errorActual = "No se ha podido leer el archivo seleccionado. "+ex.Message;
            }
            
            return lcl_dt_preview;

        }
        /// <summary>
        /// Given a cell name, parses the specified cell to get the column name.
        /// </summary>
        /// <param name="cellReference">Address of the cell (ie. B2)</param>
        /// <returns>Column Name (ie. B)</returns>
        public static string GetColumnName(string cellReference)
        {
            // Match the column name portion of the cell name.
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[A-Za-z]+");

            return regex.Match(cellReference).Value;
        }
        /// <summary>
        /// Given just the column name (no row index),
        /// it will return the zero based column index.
        /// </summary>
        /// <param name="columnName">Column Name (ie. A or AB)</param>
        /// <returns>Zero based index if the conversion was successful</returns>
        /// <exception cref="ArgumentException">thrown if the given string
        /// contains characters other than uppercase letters</exception>
        private static int ConvertColumnNameToNumber(string columnName)
        {
            System.Text.RegularExpressions.Regex alpha = new System.Text.RegularExpressions.Regex("^[A-Z]+$");
            if (!alpha.IsMatch(columnName)) throw new ArgumentException();

            char[] colLetters = columnName.ToCharArray();
            Array.Reverse(colLetters);

            int convertedValue = 0;
            for (int i = 0; i < colLetters.Length; i++)
            {
                char letter = colLetters[i];
                int current = i == 0 ? letter - 65 : letter - 64; // ASCII 'A' = 65
                convertedValue += current * (int)Math.Pow(26, i);
            }

            return convertedValue;
        }
        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            if (cell.CellValue == null)
            {
                return null;
            }
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
    }
}
