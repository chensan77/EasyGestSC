namespace EasyGest.Print.Printing
{
    public interface IPrinter
    {
        void Print(byte[] Data);
        PrinterSettings Settings { get; set; }     
    }

    public class PrinterSettings
    {
        public int id { get; set; }
        public char PrinterType { get; set; }
        public string PrinterLanguaje { get; set; }
        public string PrinterName { get; set; }
        public int PrinterPort { get; set; }
        public int AlignLeft { get; set; }
        public int AlignTop { get; set; }
        public int AlignTearOff { get; set; }
        public int Darkness { get; set; }
        public int PrintSpeed { get; set; }
        public int PrinterResolution { get; set; }
        public Codepage8 PrinterCodePage { get; set; }
        public bool AdjustLabelSize { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int LabelGapLength { get; set; }
        public string MeasurementUnit { get; set; }
        public char RamDrive { get; set; }
        public bool SupportCutter { get; set; }
        public int CharacterNumberPerLine { get; set; }
        public PrinterSettings()
        {
            RamDrive = 'R';
            AdjustLabelSize = false;
            PrinterCodePage = Codepage8.Windows_1250;
            MeasurementUnit = string.Empty;
            SupportCutter = false;
        }
    }
}