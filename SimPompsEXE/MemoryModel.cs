using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class MemoryModel
    {
        public int Number { get; set; }
        public char Adress { get; set; }
        public Dictionary<string, PriceModel> Prices { get; set; }
        public MemoryModel() 
        {
            Prices = new Dictionary<string, PriceModel>();
        }
    }
}
