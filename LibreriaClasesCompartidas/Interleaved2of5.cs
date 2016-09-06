using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBarcode.Barcode;
using System.Drawing;

namespace LibreriaClasesCompartidas
{
    public class Interleaved2of5
    {
        public static string gifInterleaved(string p_codigo)
        {
            Linear interleaved25 = new Linear();

            // Barcode data to encode
            interleaved25.Data = p_codigo;
            // Barcode symbology type to Interleaved 2 of 5
            interleaved25.Type = BarcodeType.INTERLEAVED25;

            // Wide/narrow ratio, 2.0 - 3.0 inclusive, default is 2.
            interleaved25.N = 3.0f;

            /*
            * Barcode Image Related Settings
            */
            // Unit of meature for all size related setting in the library. 
            interleaved25.UOM = UnitOfMeasure.PIXEL;
            // Bar module width (X), default is 1 pixel;
            interleaved25.X = 1;
            // Bar module height (Y), default is 60 pixel;
            interleaved25.Y = 60;
            // Barcode image left, right, top, bottom margins. Defaults are 0.
            interleaved25.LeftMargin = 0;
            interleaved25.RightMargin = 0;
            interleaved25.TopMargin = 0;
            interleaved25.BottomMargin = 0;
            // Image resolution in dpi, default is 72 dpi.
            interleaved25.Resolution = 72;
            // Created barcode orientation.
            //4 options are: facing left, facing right, facing bottom, and facing top
            interleaved25.Rotate = Rotate.Rotate0;

            /*
            * Linear barcodes human readable text styles
            */
            // Display human readable text under the barcode
            interleaved25.ShowText = true;
            // Display checksum digit at the end of barcode data.
            interleaved25.ShowCheckSumChar = true;
            // Human readable text font size, font family and style
            interleaved25.TextFont = new Font("Arial", 9f, FontStyle.Regular);
            // Space between barcode and text. Default is 6 pixel.
            interleaved25.TextMargin = 6;

            // Generate Interleaved 2 of 5 and encode barcode to gif format
            interleaved25.Format = System.Drawing.Imaging.ImageFormat.Gif;
            string directorio = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;//"C:\\Users\\lopejmar\\Desktop\\RelProy\\barcode.gif";
            directorio = directorio + @"\Vista\Resources\barcode.gif";
            interleaved25.drawBarcode(directorio);
            return directorio;
        }
    }
}
