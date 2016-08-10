using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Controladores
{
    public class ControladorPDF
    {
        List<string> PDFSaAgregar = new List<string>();
        ConexionPDF glb_conexionPDF = new ConexionPDF();
        public void crearPDF(byte[] p_bytes, string p_destino)
        {
            glb_conexionPDF.crearPDF(p_bytes, p_destino);
            
            PDFSaAgregar.Add(p_destino);
        }
        /// <summary>
        /// Concatena pdfs y devuelve la dirección de archivo del pdf final
        /// </summary>
        /// <returns></returns>
        public bool concatenarPDFs(string p_destino)
        {
            return  glb_conexionPDF.concatenarPDFs(PDFSaAgregar, p_destino);
        }
    }
}
