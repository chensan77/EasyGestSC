using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System;

namespace EasyGest.Print.Commands
{
    public partial class TSCPLCommands
    {
        private static int stringCounter;
        //private static Printing.PrinterSettings printerSettings;

        public class CustomString
        {
            private Font _font;
            private ElementDrawRotation _rotation;
            private string _text;
            private Bitmap _customImage;

            public string Text
            {
                get { return _text; }
                set
                {
                    if (value == _text) return;
                    _text = value;
                    initGraphic();
                }
            }

            public Font Font
            {
                get { return _font; }
                set
                {
                    if (value == _font) return;
                    _font = value;
                    initGraphic();
                }
            }

            public ElementDrawRotation Rotation
            {
                get { return _rotation; }
                set
                {
                    if (value == _rotation) return;
                    _rotation = value;
                    initGraphic();                    
                }
            }

            public Bitmap CustomImage
            {
                get { return _customImage; }
            }

            public int TextWidth
            {
                get { return _customImage == null ? 0 : _customImage.Width; }
            }

            public int TextHeight
            {
                get { return _customImage == null ? 0 : _customImage.Height; }
            }

            private void initGraphic()
            {
                if (_font == null || string.IsNullOrEmpty(_text))
                {
                    _customImage = null;
                    return;
                }
                
                _customImage = new Bitmap(1,1);
                var graphics = Graphics.FromImage(_customImage);
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                var sWidth = (int)graphics.MeasureString(_text, _font).Width;
                var sHeight = (int)graphics.MeasureString(_text, _font).Height;
                _customImage = new Bitmap(_customImage, sWidth, sHeight);

                using (Graphics g = Graphics.FromImage(_customImage))
                {                    
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                    var stringFormat = new StringFormat()
                    {
                        Alignment = StringAlignment.Near,
                        LineAlignment = StringAlignment.Near,
                        Trimming = StringTrimming.None
                    };
                    
                    g.Clear(Color.White);
                    g.DrawString(_text, _font, new SolidBrush(Color.Black), 0, 0, stringFormat);
                    g.Flush();
                }                 
                switch (_rotation)
                {
                    case ElementDrawRotation.ROTATE_90_DEGREES:
                        _customImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case ElementDrawRotation.ROTATE_180_DEGREES:
                        _customImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case ElementDrawRotation.ROTATE_270_DEGREES:
                        _customImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }                
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
            stringCounter++;
            var name = "SZT" + string.Format("{0:00000}", stringCounter);
            var res = new List<byte>();
            res.AddRange(GraphicWrite(left, top, name));
            return res.ToArray();
        }

        public static byte[] GraphicWrite(int left, int top, string imageName)
        {
            return Encoding.GetEncoding(850).GetBytes(string.Format("PUTBMP {0},{1},\"{2}\"\n", left, top, imageName));
        }

    }
}
