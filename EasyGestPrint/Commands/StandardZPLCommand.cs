using System;
using System.Collections.Generic;
using System.Text;

namespace EasyGest.Print.Commands
{
    public partial class ZPLCommands
    {
        public static int InterpretCodePage(Codepage8 code) {
            switch (code)
            {
                case Codepage8.DOS_437:
                    return 0;
                case Codepage8.DOS_851:
                    return 2;
                case Codepage8.DOS_863:
                    return 8;
                case Codepage8.DOS_850:
                    return 13;
                case Codepage8.Windows_1250:
                    return 31;
                case Codepage8.Windows_1251:
                    return 33;
                case Codepage8.Windows_1252:
                    return 27;
                case Codepage8.Windows_1253:
                    return 34;
                case Codepage8.Windows_1254:
                    return 35;
                case Codepage8.Windows_1255:
                    return 36;
                default:
                    return 0;
            }
        }
        public static byte[] SetupPrinter(Printing.PrinterSettings settings)
        {
            //^MMT: Tear off Mode.  ^PRp,s,b: print speed (print, slew, backfeed) (2,4,5,6,8,9,10,11,12).  
            //~TA###: Tear off position (must be 3 digits).  ^LHx,y: Label home. ^SD##x: Set Darkness (00 to 30). ^PWx: Label width
            //^XA^MMT^PR4,12,12~TA000^LH0,12~SD19^PW750
            StringCounter = 0;
            PrinterSettings = settings;
            StringBuilder sb = new StringBuilder();
            if (settings.PrintSpeed >= 0) sb.AppendFormat("^PR{0},12,12", settings.PrintSpeed);
            sb.AppendFormat("~SD{0:00}", settings.Darkness);
            sb.AppendFormat("^PW{0}", settings.Height);
            sb.AppendFormat("^LL{0}", settings.Width);
            sb.AppendFormat("^CI{0}", InterpretCodePage(settings.PrinterCodePage));

            return Encoding.GetEncoding(850).GetBytes(sb.ToString());
        }        

        public static byte[] PrintBuffer(int copies)
        {
            return Encoding.GetEncoding(850).GetBytes(copies > 1 ? string.Format("^PQ{0}", copies) : "");
        }

        public static void CloseCommand(ref List<byte> command)
        {
            command.AddRange(Encoding.GetEncoding(850).GetBytes("^XZ"));
            command.InsertRange(0, Encoding.GetEncoding(850).GetBytes("^XA"));
        }

        public static byte[] BarCodeWrite(int left, int top, int height, ElementDrawRotation rotation, Barcode barcode, bool readable, string barcodeData)
        {
            string encodedReadable = readable ? "Y" : "N";
            char encodedRotation = Rotation.ZPLRotationMap[(int)rotation];
            switch (barcode.Type)
	        {
                case BarcodeType.CODE39_STD_EXT:
                    return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^BY{2}^B3{3},N,{4},{5}^FD{6}^FS", left, top, 
                        barcode.BarWidthNarrow, encodedRotation, height, encodedReadable, barcodeData));
                case BarcodeType.CODE128_AUTO:
                    return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^BY{2}^BC{3},{4},{5}^FD{6}^FS", left, top, 
                        barcode.BarWidthNarrow, encodedRotation, height, encodedReadable, barcodeData));
                case BarcodeType.UPC_A:
                    return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^BY{2}^BU{3},{4},{5}^FD{6}^FS", left, top, 
                        barcode.BarWidthNarrow, encodedRotation, height, encodedReadable, barcodeData));
                case BarcodeType.UPC_E:
                    return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^BY{2}^B9{3},{4},{5}^FD{6}^FS", left, top,
                        barcode.BarWidthNarrow, encodedRotation, height, encodedReadable, barcodeData));
                case BarcodeType.EAN8:
                    return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^BY{2}^B8{3},{4},{5}^FD{6}^FS", left, top,
                        barcode.BarWidthNarrow, encodedRotation, height, encodedReadable, barcodeData));
                case BarcodeType.EAN13:
                    return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^BY{2}^BE{3},{4},{5}^FD{6}^FS", left, top,
                        barcode.BarWidthNarrow, encodedRotation, height, encodedReadable, barcodeData));
		        default:
                    throw new ApplicationException("Barcode not yet supported by LabelPrinter library or printer language.");                
	        }
        }

        public static byte[] TextWrite(int left, int top, ElementDrawRotation rotation, ZPLFont font, int height, int width, string text, int codepage = 1252)
        {
            return Encoding.GetEncoding(codepage).GetBytes(string.Format("^FO{0},{1}^A{2}{3},{4},{5}^FD{6}^FS", left, top, (char)font,
                 Rotation.ZPLRotationMap[(int)rotation], height, width, text));
        }

        public static int FontHeight(ZPLFont font, int? altoFuenteDescripcion)
        {
            int height = 10;
            if (altoFuenteDescripcion.HasValue) height = altoFuenteDescripcion.Value;
            switch (font)
            {
                case ZPLFont.FONT_A:
                    return 5;
                case ZPLFont.FONT_B:
                    return 7;
                case ZPLFont.FONT_C:
                case ZPLFont.FONT_D:
                    return 10 ;
                case ZPLFont.FONT_E:
                    return 20;
                case ZPLFont.FONT_F:
                    return 13;
                case ZPLFont.FONT_G:
                    return 40;
                case ZPLFont.FONT_H:
                    return 22;
                case ZPLFont.FONT_P:
                    return 18;
                case ZPLFont.FONT_Q:
                    return 24;
                case ZPLFont.FONT_R:
                    return 31;
                case ZPLFont.FONT_S:
                    return 35;
                case ZPLFont.FONT_T:
                    return 42;
                case ZPLFont.FONT_U:
                    return 53;
                case ZPLFont.FONT_V:
                    return 71;
                default:
                    return height;
            }
        }

        public static byte[] TextWrite(int left, int top, ElementDrawRotation rotation, int height, string text, int codepage = 1252)
        {
            //uses last specified font
            return Encoding.GetEncoding(codepage).GetBytes(string.Format("^A0{0},{1}^FO{2},{3}^FD{4}^FS", Rotation.ZPLRotationMap[(int)rotation],
                height, left, top, text));
        }

        public static byte[] LineWrite(int left, int top, int right, int bottom, int lineThickness)
        {
            int height = top-bottom;
            int width = right - left;            
            char diagonal = height * width < 0 ? 'L' : 'R';
            int l = Math.Min(left, right);
            int t = Math.Min(top, bottom);
            height = Math.Abs(height);
            width = Math.Abs(width);

            //zpl requires that straight lines are drawn with GB (Graphic-Box)
            if (width < lineThickness)
                return BoxWrite(left-((int)(lineThickness/2)), top, lineThickness, width, height, 0);
            else if (height < lineThickness)
                return BoxWrite(left, top-((int)(lineThickness/2)), lineThickness, width, height, 0);
            else
                return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^GD{2},{3},{4},{5},{6}^FS", l, t, width, height, 
                    lineThickness, "", diagonal));
        }

        public static byte[] BoxWrite(int left, int top, int lineThickness, int width, int height, int rounding)
        {
            return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^GB{2},{3},{4},{5},{6}^FS", left, top, 
                Math.Max(width, lineThickness), Math.Max(height, lineThickness), lineThickness, "", rounding));
        }

    }
}
