using System.Collections.Generic;
using System.Text;
using EasyGest.Print.Commands;
using System.Drawing;
using EasyGest.Print.Printing;
using System;

namespace EasyGest.Print.Commands
{
    public partial class  POSCommand
    {
        public static int StringCounter { get; private set; }
        public static PrinterSettings PrinterSettings { get; private set; }

        private const String ESC = "\u001B";
        private const String GS = "\u001D";
        private static int InterpretCodePage(Codepage8 code)
        {
            switch (code)
            {
                case Codepage8.DOS_437:
                    return 0;
                case Codepage8.DOS_737:
                    return 7;   
                case Codepage8.DOS_850:
                    return 2;                
                case Codepage8.DOS_860:
                    return 3;
                case Codepage8.DOS_862:
                    return 8;         
                case Codepage8.DOS_863:
                    return 4;
                case Codepage8.DOS_865:
                    return 5;
                case Codepage8.DOS_852:
                    return 18;
                case Codepage8.DOS_866:
                    return 17;
                case Codepage8.Windows_1250:
                    return 9;
                case Codepage8.Windows_1251:
                    return 17;
                case Codepage8.Windows_1252:
                    return 16;
                case Codepage8.Windows_1253:
                    return 7;
                case Codepage8.Windows_1255:
                    return 8;
                default:
                    return 0;
            }
        }

        public static byte[] SetupPrinter(Printing.PrinterSettings settings)
        {
            StringCounter = 0;
            PrinterSettings = settings;
            StringBuilder sb = new StringBuilder();
            sb.Append(ESC + Char.Parse("@")); //Initializer printer;
            sb.Append(ESC + "R" + System.Convert.ToChar(11));
            sb.Append(ESC + "t" + System.Convert.ToChar(InterpretCodePage(settings.PrinterCodePage)));
            return Encoding.GetEncoding(850).GetBytes(sb.ToString());
        }

        public static byte[] FeedLines(int numLines)
        {
            return Encoding.GetEncoding(850).GetBytes(ESC + "d" + Convert.ToChar(numLines));        
        }

        public static byte[] CutPaper(int numFeeds = 0)
        {
            if (numFeeds > 0)
                return Encoding.GetEncoding(850).GetBytes(GS + "V" + Convert.ToChar(66) + Convert.ToChar(numFeeds));
            else
                return Encoding.GetEncoding(850).GetBytes(GS + "V" + Convert.ToChar(1));
        }

        public static byte[] SendPulse(string secuencia)
        {
            int m = 0;
            int t1 = 25;
            int t2 = 200;
            try
            {
                string[] values = secuencia?.Split(Char.Parse(" "));
                m = Int32.Parse(values[0]);
                t1 = Int32.Parse(values[1]);
                t2 = Int32.Parse(values[2]);
            }
            catch (Exception e)
            {
            }

            return Encoding.GetEncoding(850).GetBytes(ESC + "p" + Convert.ToChar(m) + Convert.ToChar(t1) + Convert.ToChar(t2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="bold"></param>
        /// <param name="underline"></param>
        /// <param name="alignment"></param>
        /// <param name="fontHeight">Range: 1-8</param>
        /// <param name="fontWidth">Range: 1-8</param>
        /// <returns></returns>

        public static byte[] TextWrite(string text, POSFont font, bool bold = false, bool underline = false, POSFontAlignment alignment = POSFontAlignment.LEFT, int fontHeight = 1, int fontWidth = 1, int codepage = 1252)
        {
            string command = string.Format("{0}" + text, ESC + "M" + Convert.ToChar((int) font));
            int heigtBits, widthBits;
            if (fontHeight < 1) fontHeight = 1;
            if (fontHeight > 8) fontHeight = 8;
            if (fontWidth < 1) fontWidth = 1;
            if (fontWidth > 8) fontWidth = 8;
            heigtBits = fontHeight - 1;
            widthBits = 16 * (fontWidth - 1);
            command = string.Format("{0}" + command, GS + "!" + Convert.ToChar(widthBits + heigtBits));
            command = string.Format("{0}" + command, ESC + "a" + Convert.ToChar((int) alignment));
            if (bold)
            {
                command = string.Format("{0}" + command + "{1}", ESC + "E" + "\u0001", ESC + "E" + "\u0000");
            }
            if (underline)
            {
                command = string.Format("{0}" + command + "{1}", ESC + "-" + "\u0001", ESC + "-" + "\u0000");
            }

            return Encoding.GetEncoding(codepage).GetBytes(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">Range: 2-6</param>
        /// <param name="height">Range: 1-255</param>
        /// <param name="barcode"></param>
        /// <param name="readable"></param>
        /// <param name="barcodeData"></param>
        /// <returns></returns>
        public static byte[] BarCodeWrite( Barcodes barcode, string barcodeData, bool readable = true, POSFontAlignment align = POSFontAlignment.CENTER, int width = 3, int height = 162)
        {
            string printCmd = GS + "k";
            StringBuilder sb = new StringBuilder();
            sb.Append(ESC + "a" + Convert.ToChar((int)align));
            if (readable)
                sb.Append(GS + "H" + Convert.ToChar(2));
            else
                sb.Append(GS + "H\0");

            if (width < 2) width = 2;
            if (width > 6) width = 6;
            sb.Append(GS + "w" + Convert.ToChar(width));

            if (height < 1) height = 1;
            if (height > 255) height = 255;
            sb.Append(GS + "h" + Convert.ToChar(height));

            
            switch (barcode.Type)
            {
                case BarcodeType.INTERLEAVED_2OF5:
                    sb.Append(printCmd + Convert.ToChar(5) + barcodeData + "\0");
                    break;
                case BarcodeType.CODE39_STD_EXT:
                    sb.Append(printCmd + Convert.ToChar(4) + barcodeData + "\0");
                    break;
                case BarcodeType.CODABAR:
                    sb.Append(printCmd + Convert.ToChar(6) + barcodeData + "\0");
                    break;
                case BarcodeType.UPC_A:
                    sb.Append(printCmd + Convert.ToChar(0) + barcodeData + "\0");
                    break;
                case BarcodeType.UPC_E:
                    sb.Append(printCmd + Convert.ToChar(1) + barcodeData + "\0");
                    break;
                case BarcodeType.EAN8:
                    sb.Append(printCmd + Convert.ToChar(3) + barcodeData + "\0");
                    break;
                case BarcodeType.EAN13:
                    sb.Append(printCmd + Convert.ToChar(2) + barcodeData + "\0");
                    break;
                default:
                    throw new ApplicationException("Barcode not yet supported by LabelPrinter library or printer language.");
            }
            return  Encoding.GetEncoding(850).GetBytes(sb.ToString());
        }

    }
}
