using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using EasyGest.Print.Printing;

namespace EasyGest.Print.Commands
{
    public partial class ZPLCommands
    {
        private static int stringCounter;
        private static Printing.PrinterSettings printerSettings;

        public static int StringCounter
        {
            get
            {
                return stringCounter;
            }

            set
            {
                stringCounter = value;
            }
        }

        public static PrinterSettings PrinterSettings
        {
            get
            {
                return printerSettings;
            }

            set
            {
                printerSettings = value;
            }
        }


        /// <summary>
        /// Write any windows-supported text in any windows-supported font style to the printer - including international characters!
        /// Note that if your printer's RAM drive letter is something other than 'E', you must set it in printer settings before calling ZPLCommands.ClearPrinter!
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="rotation"></param>
        /// <param name="font"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] CustomStringWrite(int left, int top, ElementDrawRotation rotation, Font font, string text)
        {
            var s = new CustomString {Font = font, Rotation = rotation, Text = text};
            return CustomStringWrite(left, top, s);
        }

        public static byte[] CustomStringWrite(int left, int top, CustomString customString)
        {
            StringCounter++;
            var name = "SZT" + string.Format("{0:00000}", StringCounter);
            var res = new List<byte>();
            res.AddRange(GraphicStore(customString.CustomImage, PrinterSettings.RamDrive, name));
            res.AddRange(GraphicWrite(left, top, name, PrinterSettings.RamDrive));
            return res.ToArray();
        }

        public static byte[] GraphicWrite(int left, int top, string imageName, char storageArea)
        {
            return Encoding.GetEncoding(850).GetBytes(string.Format("^FO{0},{1}^XG{2}:{3}.GRF^FS", left, top, storageArea, imageName));
        }

        public static byte[] GraphicStore(Bitmap image, char storageArea, string imageName)
        {    
            //Note that we're using the RED channel to determine if each pixel of an image is enabled.  
            //No dithering is done: values of red higher than 128 are on.
            List<byte> res = new List<byte>();
            int byteWidth = image.Width % 8 == 0 ? image.Width / 8 : (int)(image.Width / 8) + 1;
            res.AddRange(Encoding.GetEncoding(850).GetBytes(string.Format("~DG{0}:{1},{2},{3},", storageArea, imageName,
                image.Height * byteWidth, byteWidth)));

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < byteWidth; x++)
                {
                    BitArray ba = new BitArray(8);
                    int scanx = x * 8;
                    for (int k = 7; k >= 0; k--)
                    {
                        if (scanx >= image.Width)
                            ba[k] = false;
                        else
                            ba[k] = image.GetPixel(scanx, y).R < 128;
                        scanx++;
                    }
                    res.AddRange(Encoding.GetEncoding(850).GetBytes(string.Format("{0:X2}", convertToByte(ba))));                    
                }
                res.AddRange(Encoding.GetEncoding(850).GetBytes("\n"));
            }
            return res.ToArray(); 
        }

        public static byte[] GraphicDelete(char storageArea, string imageName)
        {
            return Encoding.GetEncoding(850).GetBytes(string.Format("^ID{0}:{1}.GRF^FS", storageArea, imageName));
        }
        
        private static byte convertToByte(BitArray bits)
        {
            byte value = 0x00;

            for (byte x = 0; x < 8; x++)
            {
                value |= (byte)((bits[x] == true) ? (0x01 << x) : 0x00);
            }
            return value;
        }

        public class CustomString
        {
            private Font _font;
            private ElementDrawRotation _rotation;
            private string _text;
            private Bitmap _customImage;

            public string Text
            {
                get { return Text1; }
                set
                {
                    if (value == Text1) return;
                    Text1 = value;
                    initGraphic();
                }
            }

            public Font Font
            {
                get { return Font1; }
                set
                {
                    if (value == Font1) return;
                    Font1 = value;
                    initGraphic();
                }
            }

            public ElementDrawRotation Rotation
            {
                get { return Rotation1; }
                set
                {
                    if (value == Rotation1) return;
                    Rotation1 = value;
                    initGraphic();                    
                }
            }

            public Bitmap CustomImage
            {
                get { return CustomImage1; }
            }

            public int TextWidth
            {
                get { return CustomImage1 == null ? 0 : CustomImage1.Width; }
            }

            public int TextHeight
            {
                get { return CustomImage1 == null ? 0 : CustomImage1.Height; }
            }

            public Font Font1
            {
                get
                {
                    return _font;
                }

                set
                {
                    _font = value;
                }
            }

            public ElementDrawRotation Rotation1
            {
                get
                {
                    return _rotation;
                }

                set
                {
                    _rotation = value;
                }
            }

            public string Text1
            {
                get
                {
                    return _text;
                }

                set
                {
                    _text = value;
                }
            }

            public Bitmap CustomImage1
            {
                get
                {
                    return _customImage;
                }

                set
                {
                    _customImage = value;
                }
            }

            private void initGraphic()
            {
                if (Font1 == null || string.IsNullOrEmpty(Text1))
                {
                    CustomImage1 = null;
                    return;
                }
                
                CustomImage1 = new Bitmap(1,1);
                var graphics = Graphics.FromImage(CustomImage1);
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                var sWidth = (int)graphics.MeasureString(Text1, Font1).Width;
                var sHeight = (int)graphics.MeasureString(Text1, Font1).Height;
                CustomImage1 = new Bitmap(CustomImage1, sWidth, sHeight);

                using (Graphics g = Graphics.FromImage(CustomImage1))
                {                    
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                    var stringFormat = new StringFormat()
                    {
                        Alignment = StringAlignment.Near,
                        LineAlignment = StringAlignment.Near,
                        Trimming = StringTrimming.None
                    };
                    
                    g.Clear(Color.White);
                    g.DrawString(Text1, Font1, new SolidBrush(Color.Black), 0, 0, stringFormat);
                    g.Flush();
                }                 
                switch (Rotation1)
                {
                    case ElementDrawRotation.ROTATE_90_DEGREES:
                        CustomImage1.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case ElementDrawRotation.ROTATE_180_DEGREES:
                        CustomImage1.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case ElementDrawRotation.ROTATE_270_DEGREES:
                        CustomImage1.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }                
            }
        }
    }

}
