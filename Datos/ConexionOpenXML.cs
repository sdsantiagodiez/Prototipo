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
        public bool escribirExcel(DataTable table, string p_direccionDeArchivo)
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
                DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = "Export"};
                sheets.Append(sheet);
                #endregion

                #region Inserta nombre de atributo en columna
                DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                List<String> columns = new List<string>();
                foreach (DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);

                    DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                    cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                    cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName); 
                    //cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.InlineString;
                    //cell.InlineString = new InlineString() { Text = new Text(column.ColumnName) };
                    
                    headerRow.AppendChild(cell);
                }

                sheetData.AppendChild(headerRow);
                #endregion

                #region Inserta Datos
                foreach (DataRow row in table.Rows)
                {
                    DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                    foreach (String col in columns)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString());
                        //cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.InlineString;
                        //cell.InlineString = new InlineString() { Text = new Text(row[col].ToString()) };
                        newRow.AppendChild(cell);
                    }

                    sheetData.AppendChild(newRow);
                }
                #endregion
            }
            return true;
        }
        public bool leerExcel(string p_path, List<int?> p_indiceAtributo, ref DataTable p_dataTable, bool p_primeraRowHeaders)
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

                        for (int i = 0; i < p_indiceAtributo.Count; i++) // row.Descendants<Cell>().Count(); i++)
                        {
                            if (p_indiceAtributo[i] == null)
                            { continue; }
                            indiceAux = Convert.ToInt32(p_indiceAtributo[i]);
                            tempRow[i] = this.getCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(indiceAux));
                        }

                        p_dataTable.Rows.Add(tempRow);
                    }

                }
                if (p_primeraRowHeaders)
                {
                    p_dataTable.Rows.RemoveAt(0); //quitamos headers de atributos
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public DataTable leerExcel_preview(string p_path, int p_cantidadDeColumnas)
        {
            DataTable lcl_dt_preview = new DataTable();

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
                
                for (int i= 0; i< p_cantidadDeColumnas; i++) //Crea columnas de dataTablePreview
                {
                    lcl_dt_preview.Columns.Add();
                }

                foreach (Row row in rows)   //Lee las rows del archivo y las pasa al dataTablePreview
                {
                    DataRow tempRow = lcl_dt_preview.NewRow();

                    for (int i = 0; i < row.Descendants<Cell>().Count() && i < p_cantidadDeColumnas; i++)
                    {
                        tempRow[i] = this.getCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }

                    lcl_dt_preview.Rows.Add(tempRow);
                }
            }

            return lcl_dt_preview;
        }
        private string getCellValue(SpreadsheetDocument document, Cell cell)
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
