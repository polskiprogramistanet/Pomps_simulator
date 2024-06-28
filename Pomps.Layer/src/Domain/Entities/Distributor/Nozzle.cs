using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Entities.Distributor
{
   public class Nozzle
    {
        public int Num { get; set; }
        public int IdPomp { get; set; }
        public string FuelSymbol { get; set; }
        public string FuelName { get; set; }
        public int FuelId { get; set; }
        public decimal Price { get; set; }
        public TriggerState Trigger { get; set; }
        public int ProductCode { get; set; }
        public NozzleState NozzleState { get; private set; }
        public void Trigger_OFF()
        {
            this.Trigger = TriggerState.OFF;
        }
        public void Trigger_ON()
        {
            this.Trigger = TriggerState.ON;
        }
        public decimal Totalizer { get; set; }
        public void Nozzle_UP()
        {
            this.NozzleState = NozzleState.UP;
        }
        public void Nozzle_DOWN()
        {
            this.NozzleState = NozzleState.DOWN;
        }
    }

    
    public enum TriggerState { OFF, ON}
    public enum NozzleState { DOWN, UP}
}
