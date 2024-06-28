using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE.Intrfaces
{
    internal interface IDisplayValues
    {
        decimal Amount { get; set; }
        decimal Volume { get; set; }
        decimal Price { get; set; }
    }
}
