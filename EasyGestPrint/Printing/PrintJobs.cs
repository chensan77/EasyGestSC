using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyGestControllers.Data.Entity;

namespace EasyGest.Print.Printing
{
    public class PrintJobs
    {
        public const string PRINTETIQUETAJOB = "ETIQUETA";
        public const string PRINTVALEJOB = "VALE";
        public const string PRINTRECIBOJOB = "RECIBO";

        public IPrinter Printer { get; set; }
        public delegate void PrintingErrorDelgate(Exception ex);

        private PrintingErrorDelgate _delegado;
        private Dictionary<string, object> _tareas = new Dictionary<string, object>();
        private bool _printBussy = false;

        public void AddJob(string tarea, object param)
        {
            if (string.IsNullOrEmpty(tarea))
                return;
            _tareas.Add(tarea, param);
        }

        public void ClearJobs()
        {
            if (!_printBussy)
                _tareas.Clear();
        }

        public void SetErrorDelgate(PrintingErrorDelgate delegado)
        {
            _delegado = delegado;
        }

        public void Print()
        {
            if (Printer == null) throw new ApplicationException("No defined printer");
            _printBussy = true;
            foreach (string tarea in _tareas.Keys)
            {
                switch (tarea)
                {
                    case PRINTVALEJOB:
                        PrintVale(_tareas[tarea]);
                        break;
                    case PRINTETIQUETAJOB:
                        PrintVale(_tareas[tarea]);
                        break;
                    case PRINTRECIBOJOB:
                        PrintRecibo(_tareas[tarea]);
                        break;
                }
            }

            _printBussy = false;
        }

        public void PrintVale(object param)
        {
            if (Printer == null) throw new ApplicationException("No defined printer");
            Object[] arg = (Object[])param;
            VWVales vale;
            Empresas empresa;
            List<byte> datas = new List<byte>();
            Barcodes bar = new Barcodes();
            try
            {
                bar.Type = BarcodeType.CODE39_STD_EXT;
                vale = (VWVales)arg[0];
                empresa = (Empresas)arg[1];
                datas.AddRange(Commands.POSCommand.SetupPrinter(Printer.Settings));
                datas.AddRange(Commands.POSCommand.TextWrite("VALE COMPRA\n", POSFont.Font_A, true, false, POSFontAlignment.CENTER, 3, 3));
                datas.AddRange(Commands.POSCommand.FeedLines(2));
                // datos vale
                datas.AddRange(Commands.POSCommand.TextWrite("Número: " + vale.Numero + "\n", POSFont.Font_A));
                datas.AddRange(Commands.POSCommand.TextWrite("Emitido en: " + vale.FEmision.ToString("g") + "\n", POSFont.Font_A));
                if (vale.FValidez != null)
                    datas.AddRange(Commands.POSCommand.TextWrite("Válidez hasta: " + vale.FValidez.Value.ToString("d") + "\n", POSFont.Font_A));
                else
                    datas.AddRange(Commands.POSCommand.TextWrite("Válidez hasta: NO CADUCA\n", POSFont.Font_A));
                if (vale.FComienzo != null)
                    datas.AddRange(Commands.POSCommand.TextWrite("Usar a partir de: " + vale.FComienzo.Value.ToString("d") + "\n", POSFont.Font_A));
                if (vale.idCliente != null)
                    datas.AddRange(Commands.POSCommand.TextWrite("Titular: " + vale.Cliente + "\n", POSFont.Font_A));
                // Importe
                datas.AddRange(Commands.POSCommand.FeedLines(1));
                datas.AddRange(Commands.POSCommand.TextWrite((vale.EsPunto ? string.Format("Puntos: {0:N2}",  vale.Importe) : string.Format("Importe: {0:C2}", vale.Importe) ) + "\n", POSFont.Font_A, true,false,POSFontAlignment.CENTER,2,2));
                datas.AddRange(Commands.POSCommand.FeedLines(1));
                // Zona de sellar
                datas.AddRange(Commands.POSCommand.TextWrite("Firma y/o sello del comercio:\n", POSFont.Font_A));
                datas.AddRange(Commands.POSCommand.TextWrite("-".PadLeft(Printer.Settings.CharacterNumberPerLine-3, Char.Parse("-")) + "\n", POSFont.Font_B, true, false, POSFontAlignment.CENTER));
                datas.AddRange(Commands.POSCommand.FeedLines(10));
                datas.AddRange(Commands.POSCommand.TextWrite("-".PadLeft(Printer.Settings.CharacterNumberPerLine-3, Char.Parse("-")) + "\n", POSFont.Font_B, true, false,POSFontAlignment.CENTER));
                datas.AddRange(Commands.POSCommand.TextWrite("Sin la firma y/o sello, este vale carece la válidez.\n", POSFont.Font_B));
                // Codigo Barra
                datas.AddRange(Commands.POSCommand.BarCodeWrite(bar, vale.Numero, true, POSFontAlignment.CENTER, 2, 170));
                //Datos Empresa
                datas.AddRange(Commands.POSCommand.FeedLines(1));
                datas.AddRange(Commands.POSCommand.TextWrite("Comercio: " + empresa.NombreComercial + "\n", POSFont.Font_A));
                datas.AddRange(Commands.POSCommand.TextWrite("NIF: " + empresa.NIF + "\n", POSFont.Font_A));
                if (Printer.Settings.SupportCutter)
                    datas.AddRange(Commands.POSCommand.CutPaper(5));
                else
                    datas.AddRange(Commands.POSCommand.FeedLines(10));
                Printer.Print(datas.ToArray());
            }
            catch (Exception e)
            {
                _delegado?.Invoke(e);
            }

        }

        public void PrintRecibo(object param)
        {
            if (Printer == null) throw new ApplicationException("No defined printer");
        }

        public void PrintEtiqueta(object param)
        {
            if (Printer == null) throw new ApplicationException("No defined printer");
        }

        private string[] SplitText(int numCaracter, string text)
        {
            List<string> lineas = new List<string>();
            int numLineas = 0;
            int longitud = text.Length;
            numLineas = (int)Math.Ceiling((double)longitud / (double)numCaracter);
            for (int i = 1; i <= numLineas; i++)
            {
                if (i == numLineas)
                {
                    lineas.Add(text.Substring((i - 1) * numCaracter).Trim());
                }
                else
                {
                    lineas.Add(text.Substring((i - 1) * numCaracter, numCaracter).Trim());

                }
            }
            return lineas.ToArray();
        }
    }
}
