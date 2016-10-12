using System;
namespace EasyGest.Print
{
    public class Rotation
    {
        public static char[] ZPLRotationMap = { 'N', 'R', 'I', 'B' };
        public static int[] TSCPLRotationMap = { 0, 90, 180, 270 };
    }

    public class BarcodeTypeMap
    {
        public static string[] TSCPLBarcodeTypeMap = { "39", "39C", "93", "128", "128", "", "", "", "CODA", "EAN8", "EAN8+2", "EAN8+5", "EAN13", "EAN13+2", "EAN13+5",
                                                        "DPI", "25", "25C", "25C", "POST", "", "EAN128", "UPCA", "UPCA+2", "UPCA+5", "UPCE", "UPCE+2", "UPCE+5", "25", "PLESSEY", "MSI"};
    }
    public enum ElementDrawRotation
    {
        NO_ROTATION = 0,
        ROTATE_90_DEGREES,
        ROTATE_180_DEGREES,
        ROTATE_270_DEGREES
    }

    public enum POSFontAlignment
    {
        LEFT,
        CENTER,
        RIGHT
    }

    public enum POSFontFormat
    {
        CPP10 = 0,
        CPP12 = 1,
        PROPORTIONAL = 2,
        COMPRESSED = 4,
        BOLD = 8,
        DOUBLEHEIGHT = 16,
        DOUBLEWIDTH = 32,
        CURSIVE = 64,
        UNDERLINE = 128
    }
    public enum ElementUploadRotation
    {
        NO_ROTATION = 0,
        ROTATE_90_DEGREES,
        BOTH_ROTATIONS
    }

    public enum FontCharsetType
    {
        NUMERIC = 0,
        STANDARD,
        LOWERCASE,
        UPPERCASE,
        LOWERCASE_NUMERIC,
        UPPERCASE_NUMERIC,
        EXTENDED,
        EMSIZE  //emsize is width of the an upper-case M in points.  1 point is 1.3333 pixels.  WPF assumes 96 pixels/inch. Confused yet?
    }

    public class FontCharset
    {
        public static string[] CharList = {"0123456789.- ",
            " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNÑOPQRSTUVWXYZ[\\]^_`abcdefghijklmnñopqrstuvwxyz{|}~",
            "abcdefghijklmnñopqrstuvwxyz ",
            "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ",
            "abcdefghijklmnñopqrstuvwxyz 0123456789.-",
            "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ 0123456789.-",
            " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNÑOPQRSTUVWXYZ[\\]^_`abcdefghijklmnñopqrstuvwxyz{|}~" + 
            "ÇüéâäàåçêëèïîìÄÅÉæÆôöòûùÿÖÜ¢£€¥₧ƒáíóúñÑªº¿⌐¬½¼¡«»αßΓπΣσµτΦΘΩδ∞φε∩≡±≥≤⌠⌡÷≈°∙·√ⁿ² ",
            "M"};
    }

    public enum TSCFont
    {
        SCALABLE_FONT = 0,
        STANDARD_SMALLEST,
        STANDARD_SMALL,
        STANDARD_NORMAL,
        STANDARD_LARGE,
        STANDARD_LARGEST
    }
    public enum ZPLFont
    {        
        SCALABLE_FONT = 48,
        FONT_A = 97,
        FONT_B,
        FONT_C,
        FONT_D,
        FONT_E,
        FONT_F,
        FONT_G,
        FONT_H,
        FONT_I,
        FONT_J,
        FONT_K,
        FONT_L,
        FONT_M,
        FONT_N,
        FONT_O,
        FONT_P,
        FONT_Q,
        FONT_R,
        FONT_S,
        FONT_T,
        FONT_U,
        FONT_V,
        FONT_ALL = 42
    }

    public enum EPLFont
    {
        STANDARD_SMALLEST = 48,
        STANDARD_SMALL,
        STANDARD_NORMAL,
        STANDARD_LARGE,
        STANDARD_LARGEST,
        CUSTOM_A = 97,
        CUSTOM_B,
        CUSTOM_C,
        CUSTOM_D,
        CUSTOM_E,
        CUSTOM_F,
        CUSTOM_G,
        CUSTOM_H,
        CUSTOM_I,
        CUSTOM_J,
        CUSTOM_K,
        CUSTOM_L,
        CUSTOM_M,
        CUSTOM_N,
        CUSTOM_O,
        CUSTOM_P,
        CUSTOM_Q,
        CUSTOM_R,
        CUSTOM_S,
        CUSTOM_T,
        CUSTOM_U,
        CUSTOM_V,
        CUSTOM_W,
        CUSTOM_X,
        CUSTOM_Y,
        CUSTOM_Z,
        CUSTOM_ALL = 42

    }

    public enum Codepage8
    {
        DOS_437 = 0,
        DOS_850,
        DOS_852,
        DOS_860,
        DOS_863,
        DOS_865,
        DOS_857,
        DOS_861,
        DOS_862,
        DOS_855,
        DOS_866,
        DOS_737,
        DOS_851,
        DOS_869,
        Windows_1252,
        Windows_1250,
        Windows_1251,
        Windows_1253,
        Windows_1254,
        Windows_1255
    }

    public enum Codepage7
    {
        USA = 0,
        British,
        German,
        French,
        Danish,
        Italian,
        Spanish,
        Swedish,
        Swiss
    }

    public enum Codepage8KDU
    {
        USA = 1,
        Canada = 2,
        Belguim = 32,
        Denmark = 45,
        Finland = 358,
        France = 33,
        Germany = 49,
        Netherlands = 31,
        Italy = 39,
        Latin_America = 3,
        Noray = 47,
        Portugal = 351,
        South_Africa = 27,
        Spain = 34,
        Sweden = 46,
        Swizerland = 41,
        UK = 44
    }


}
