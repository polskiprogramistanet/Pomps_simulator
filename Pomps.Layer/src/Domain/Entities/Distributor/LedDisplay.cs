using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Application;
using Pomps.Layer.src.Common;
using Pomps.Layer.src.Domain.Entities.Distributor.Observers;

namespace Pomps.Layer.src.Domain.Entities.Distributor
{
    public class LedDisplay : IDisplayValues
    {
        public decimal Amount { get;private set; }
        public decimal Volume { get;private set; }
        public decimal Price { get;private set; }
        public DistributorEnbEnum TurnOnState { get; private set; }

        IObserverDisplayInformation observer;
       
        public LedDisplay(IObserverDisplayInformation observer)
        {
            this.observer = observer;

        }
        public void Display_On()
        {
            TurnOnState = DistributorEnbEnum.ON;
            
        }
        public void Display_Off()
        {
            TurnOnState = DistributorEnbEnum.OFF;
        }
        public void Display_Reset()
        {
            this.Amount = 0;
            this.Volume = 0;
            this.Price = 0;
        }
        public void SetVolume(decimal volume)
        {
            this.Volume = volume;
            this.Amount = this.Volume * this.Price;
            observer.SetPumpingInformationFromDisplay(this);

        }
        public void SetPriceActive(int productCode)
        {
            if (productCode < 1 || productCode > 4) throw new Exception("Błędny wąż");
            this.Price = Memory.Prices[productCode];
        }
    }
}
