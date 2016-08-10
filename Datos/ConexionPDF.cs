using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;

namespace Datos
{
    public class ConexionPDF
    {
        public void crearPDF(byte[] p_bytes,string p_destino)
        {
            FileStream fs = new FileStream(p_destino, FileMode.Create);
            fs.Write(p_bytes, 0, p_bytes.Length);
            fs.Close();
            //agregarAPDF(pathnombre_archivo, destinationDocumentStream);
        }

        public bool concatenarPDFs(List<string> p_direccionArchivoPDFs, string p_destino)
        {
            if (p_direccionArchivoPDFs.Count < 1)
            {
                return false;
            }

            FileStream fs = new FileStream(p_destino, FileMode.Create);

            var pdfConcat = new PdfConcatenate(fs);
            foreach (string direccion in p_direccionArchivoPDFs)
            {
                var sourceDocumentStream = new FileStream(direccion, FileMode.Open, FileAccess.Read, 0);

                var pdfReader = new PdfReader(sourceDocumentStream);
                pdfReader.SelectPages("1");
                pdfConcat.AddPages(pdfReader);
                //pdfReader.Close();
            }

            pdfConcat.Close();

            return true;

            //// step 1: creation of a document-object
            //iTextSharp.text.Document document = new iTextSharp.text.Document();

            //// step 2: we create a writer that listens to the document
            //PdfCopy writer = new PdfCopy(document, new FileStream(p_destino, FileMode.Create));
            //if (writer == null)
            //{
            //    return false;
            //}

            //// step 3: we open the document
            //document.Open();

            //foreach (string fileName in p_direccionArchivoPDFs)
            //{
            //    // we create a reader for a certain document
            //    PdfReader reader = new PdfReader(fileName);
            //    reader.ConsolidateNamedDestinations();

            //    // step 4: we add content
            //    for (int i = 1; i <= reader.NumberOfPages; i++)
            //    {
            //        PdfImportedPage page = writer.GetImportedPage(reader, i);
            //        writer.AddPage(page);
            //    }

            //    PRAcroForm form = reader.AcroForm;
            //    if (form != null)
            //    {
            //        writer.AddDocument(reader);
            //    }

            //    reader.Close();
            //}
            //return true;

           
        }
    }
}
