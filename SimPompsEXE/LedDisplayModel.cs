using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class LedDisplayModel
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public LedDisplayModel() 
        { 
        
        }
        public void DisplayOn()
        {

        }
        public void DisplayOff() 
        { 
        
        }
        public void DisplayReset()
        {

        }
    }
    internal class DisplayValues
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
    }
}
