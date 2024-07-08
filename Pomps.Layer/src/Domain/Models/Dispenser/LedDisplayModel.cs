using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Application;
using Pomps.Layer.src.Common;
using Pomps.Layer.src.Domain.Models.Services;

namespace Pomps.Layer.src.Domain.Models.Dispenser
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
}
