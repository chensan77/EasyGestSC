using System.Collections.Generic;
using System.Text;
using EasyGest.Print.Commands;
using System.Drawing;
using EasyGest.Print.Printing;
using System;

namespace EasyGest.Print.Commands
{
    public partial class TSCPLCommands
    {
        public static int InterpretCodePage(Codepage8 code)
        {
            switch (code)
            {
                case Codepage8.DOS_437:
                    return 437;
                case Codepage8.DOS_737:
                    return 737;
                case Codepage8.DOS_850:
                    return 850;
                case Codepage8.DOS_851:
                    return 851;
                case Codepage8.DOS_852:
                    return 852;
                case Codepage8.DOS_855:
                    return 855;
                case Codepage8.DOS_857:
                    return 857;
                case Codepage8.DOS_860:
                    return 860;
                case Codepage8.DOS_861:
                    return 861;
                case Codepage8.DOS_862:
                    return 862;
                case Codepage8.DOS_863:
                    return 863;
                case Codepage8.DOS_865:
                    return 865;
                case Codepage8.DOS_866:
                    return 866;
                case Codepage8.DOS_869:
                    return 869;
                case Codepage8.Windows_1250:
                    return 1250;
                case Codepage8.Windows_1251:
                    return 1251;
                case Codepage8.Windows_1252:
                    return 1252;
                case Codepage8.Windows_1253:
                    return 1253;
                case Codepage8.Windows_1254:
                    return 1254;
                case Codepage8.Windows_1255:
                    return 1255;
                default:
                    return 437;
            }
        }

        public static byte[] SetupPrinter(Print.Printing.PrinterSettings settings)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SIZE {0} {1}, {2} {1}\n", settings.Width, settings.MeasurementUnit, settings.Height);
            if (settings.LabelGapLength >= 0) sb.AppendFormat("GAP {0},0\n", settings.LabelGapLength);
            sb.AppendFormat("CODEPAGE {0}\n", InterpretCodePage(settings.PrinterCodePage));
            sb.AppendFormat("DENSITY {0}\n", settings.Darkness);
            if (settings.PrintSpeed > 0)  sb.AppendFormat("SPEED {0}\n", settings.PrintSpeed);
            sb.AppendLine("DIRECTION 1");
            sb.AppendLine("CLS");
            return Encoding.GetEncoding(850).GetBytes(sb.ToString());  
        }

        public static byte[] PrintBuffer(int copies)
        {
            return Encoding.GetEncoding(850).GetBytes(string.Format("PRINT {0}, 1\n", copies));
        }

        public static byte[] BarCodeWrite(int left, int top, int height, ElementDrawRotation rotation, Barcode barcode, bool readable, 
            string barcodeData)
        {
            string encodedReadable = readable ? "1" : "0";
            string bartype = BarcodeTypeMap.TSCPLBarcodeTypeMap[(int)barcode.Type];
            if (bartype == string.Empty) throw new ApplicationException("Barcode not yet supported by LabelPrinter library or printer language."); 
            return Encoding.GetEncoding(850).GetBytes(string.Format("BARCODE {0},{1},\"{2}\",{3},{4},{5},{6},{7},\"{8}\"\n", left, 
                top, bartype, height, encodedReadable, Rotation.TSCPLRotationMap[(int)rotation], barcode.BarWidthNarrow, barcode.BarWidthWide, barcodeData));
        }

        public static byte[] TextWrite(int left, int top, ElementDrawRotation rotation, TSCFont font,
                                                int horizontalMult, int verticalMult,  string text, int codepage = 1252)
        {

            return Encoding.GetEncoding(codepage).GetBytes(string.Format("TEXT {0},{1},\"{2}\",{3},{4},{5},\"{6}\"\n", left , 
                top , (int)font, Rotation.TSCPLRotationMap[(int)rotation], horizontalMult, verticalMult,  
                text.Replace(@"\", @"\\").Replace("\"", "\\\"")));            
        }

        public static int FontHeight(TSCFont font, int? altoFuenteDescripcion)
        {
            int heightMult = 1;
            if (altoFuenteDescripcion.HasValue) heightMult = altoFuenteDescripcion.Value;
            switch (font)
            {
                case TSCFont.STANDARD_SMALLEST:
                    return 12 * heightMult;
                case TSCFont.STANDARD_SMALL:
                    return 20 * heightMult;
                case TSCFont.STANDARD_NORMAL:
                    return 24 * heightMult;
                case TSCFont.STANDARD_LARGE:
                    return 32 * heightMult;
                case TSCFont.STANDARD_LARGEST:
                    return 48 * heightMult;
                default:
                    return heightMult;
            }
        }

        public static byte[] LineWrite(int left, int top, int right, int bottom, int lineThickness)
        {
            return Encoding.GetEncoding(437).GetBytes(string.Format("DIAGONAL {0}, {1}, {2}, {3}, {4}\n", left, top, right, bottom, lineThickness));
        }

        public static IEnumerable<byte> LineWrite(int left, int top, int width, int height)
        {
            return Encoding.GetEncoding(437).GetBytes(string.Format("BAR {0},{1},{2},{3}\n", left, top, width, height));
        }

        public static byte[] BoxWrite(int left, int top,  int right, int bottom, int lineThickness, int radiuCorner)
        {
            return Encoding.GetEncoding(850).GetBytes(string.Format("BOX {0},{1},{2},{3},{4},{5}\n", left, top, right , bottom , lineThickness, radiuCorner));
        }

        //public static byte[] LineDraw(int left, int top, int width, int height)
        //{
        //    return Encoding.GetEncoding(850).GetBytes(string.Format("BAR {0}, {1}, {2}, {3}\n",  left, top , width, height));
        //}

    }
}