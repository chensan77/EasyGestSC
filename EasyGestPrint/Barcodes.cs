using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyGest.Print
{
    public class Barcodes
    {
        private BarcodeType type;
        public BarcodeType Type
        {
            get { return type; }
            set
            {
                type = value;
                P4Value = P4ValueList[(int)type];
                BarWidthNarrowMin = P5MinList[(int)type];
                BarWidthNarrowMax = P5MaxList[(int)type];
                if (!P5MinList[(int)type].Equals(null))
                {
                    barWidthNarrow = P5MinList[(int)type] == 1 ? 2 : P5MinList[(int)type];
                    barWidthWide = 4;
                }
                else
                {
                    barWidthNarrow = null;
                    barWidthWide = 4;
                }
            }
        }
        public string P4Value { get; private set; }
        public int? BarWidthNarrowMin { get; private set; }
        public int? BarWidthNarrowMax { get; private set; }
        private int? barWidthNarrow;
        public int? BarWidthNarrow
        {
            get { return barWidthNarrow; }
            set
            {
                if (P5MinList[(int)type].Equals(null))
                    barWidthNarrow = null;
                else
                {
                    //if (value < P5MinList[(int)type] || value > P5MaxList[(int)type])
                    //    throw new ApplicationException("Invalid barcode narrow bar width setting");
                    //else
                    barWidthNarrow = value;
                }
            }
        }
        private int barWidthWide;
        public int BarWidthWide
        {
            get { return barWidthWide; }
            set
            {
                //if (value < 2 || value > 30)
                //    throw new ApplicationException("Invalid barcode wide bar width setting");
                //else
                barWidthWide = value;
            }
        }

        private readonly string[] P4ValueList = {"3", "3C", "9", "0", "1", "1A", "1B", "1C", "K", "E80", "E82",
                                           "E85", "E30", "E32", "E35", "2G", "2", "2C", "2D", "P", "J",
                                           "1E", "UA0", "UA2", "UA5", "UE0", "UE2", "UE5", "2U", "L",
                                           "M"};
        private readonly int?[] P5MinList = {1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 1, 1, 1, null, null,
                                                1, 2, 2, 2, 2, 2, 2, 1, null, null};
        private readonly int?[] P5MaxList = {10, 10, 10, 10, 10, 10, 10, 10, 10, 4, 4, 4, 4, 4, 4, 4, 10, 10, 10,
                                                null, null, 10, 4, 4, 4, 4, 4, 4, 10, null, null};

        public static int GetChecksumEAN13(ref string numero)
        {
            string numEan = numero;
            int digito = 0;
            if (!IsEAN13(numEan))
            {
                throw new System.NotSupportedException("Not valid EAN13 Format");
            }

            numEan = numEan.Substring(0, 12);
            digito = GetDCBarcode(ref numEan);

            numero = numEan;
            return digito;
        }

        public static int GetChecksumEAN8(ref string numero)
        {
            string numEan = numero;
            int digito = 0;
            if (!IsEAN8(numEan))
            {
                throw new System.NotSupportedException("Not valid EAN8 Format");
            }

            numEan = numEan.Substring(0, 7);
            digito = GetDCBarcode(ref numEan);

            numero = numEan;
            return digito;
        }

        public static int GetChecksumUPCA(ref string numero)
        {
            string numEan = numero;
            int digito = 0;
            if (!IsUPCA(numEan))
            {
                throw new System.NotSupportedException("Not valid UPC-A Format");
            }

            numEan = numEan.Substring(0, 11);
            digito = GetDCBarcode(ref numEan);

            numero = numEan;
            return digito;
        }

        private static int GetDCBarcode(ref string numero)
        {
            // Si el número no cumple con el formato EAN13, EAN8, la función
            // devolverá una excepción de argumentos no válidos. 
            // Para ello, la cadena deberá tener 12 caracteres de
            // longitud, y contener sólo números.
            //
            int checkLongitud = numero.Length;
            int x = 0;
            int digito = 0;
            int sumaCod = 0;
            // Extraigo el valor del dígito, y voy
            // sumando los valores resultantes.
            for (x = checkLongitud - 1; x >= 0; x += -1)
            {
                digito = Convert.ToInt32(numero.Substring(x, 1));
                if (x % 2 == 0)
                {
                    // Las posiciones pares se multiplican por 1
                    sumaCod += (digito * 1);
                }
                else {
                    // Las posiciones impares se multiplican por 3
                    sumaCod += (digito * 3);
                }
            }
            // Calculo la decena superior
            digito = (sumaCod % 10);
            // Calculo el dígito de control
            digito = 10 - digito;
            // Código de barras completo
            numero += Convert.ToString(digito);
            return digito;
        }

        public static bool IsEAN13(string numero)
        {
            long num;
            if ((numero == null))
                throw new ArgumentNullException();
            if (Int64.TryParse(numero, out num))
            {
                return numero.Length == 13 | numero.Length == 12;
            }
            else {
                return false;
            }
        }

        public static bool IsEAN8(string numero)
        {
            long num;
            if ((numero == null))
                throw new ArgumentNullException();
            if (Int64.TryParse(numero, out num))
            {
                return numero.Length == 8 | numero.Length == 7;
            }
            else {
                return false;
            }
        }

        public static bool IsUPCA(string numero)
        {
            long num;
            if ((numero == null))
                throw new ArgumentNullException();
            if (Int64.TryParse(numero, out num))
            {
                return numero.Length == 12 | numero.Length == 11;
            }
            else {
                return false;
            }
        }
    }
    public enum BarcodeType
    {
        CODE39_STD_EXT = 0,
        CODE39_CHECK,
        CODE93,
        CODE128_UCC,
        CODE128_AUTO,
        CODE128_A,
        CODE128_B,
        CODE128_C,
        CODABAR,
        EAN8,
        EAN8_2DIGIT_ADDON,
        EAN8_5DIGIT_ADDON,
        EAN13,
        EAN13_2DIGIT_ADDON,
        EAN13_5DIGIT_ADDON,
        GERMAN_POST_CODE,
        INTERLEAVED_2OF5,
        INTERLEAVED_2OF5_CHECK_MOD10,
        INTERLEAVED_2OF5_CHECK_READABLE,
        POSTNET,
        POSTNET_JAPANESE,
        UCC_EAN128,
        UPC_A,
        UPC_A_2DIGIT_ADDON,
        UPC_A_5DIGIT_ADDON,
        UPC_E,
        UPC_E_2DIGIT_ADDON,
        UPC_E_5DIGIT_ADDON,
        UPC_INTERLEAVED_2OF5,
        PLESSEY_CHECK,
        MSI_3_CHECK
    }

}
