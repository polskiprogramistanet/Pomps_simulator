using SimPompsEXE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class LedDisplayModel
    {
        ILedDisplayService service;
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public LedDisplayModel(ILedDisplayService service) 
        { 
            this.service = service;
        }
        public void DisplayOn()
        {

        }
        public void DisplayOff() 
        { 
            
        }
        public void DisplayReset()
        {
            this.Amount = 0;
            this.Volume = 0;
        }
    }
    internal class DisplayValues
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public int NozzleNum { get; set; }
        public void Reset()
        {
            this.Amount = 0;
            this.Volume = 0;
            this.Price = 0;
        }
    }
}
