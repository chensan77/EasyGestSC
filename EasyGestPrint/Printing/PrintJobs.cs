using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyGest.Print.Printing
{
    class PrintJobs
    {
        public PrinterSettings PrinterSetting { get; set; }
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

        public void SetPrinterName (String name)
        {
            Printing.PrinterSettings ps;
            ps = new PrinterSettings();
            ps.PrinterName = name;

            PrinterSetting = ps;

        }
        public void Print()
        {

        }
    }
}
