using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyGest.Print.Commands
{
    interface ICommand
    {
        EasyGest.Print.Printing.PrinterSettings PrinterSetting { get; set; }

        byte[] PrinterSettup(EasyGest.Print.Printing.PrinterSettings st);



    }
}
