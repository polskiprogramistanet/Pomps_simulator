using SimPompsEXE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class DispenserModel : IPompEngineService
    {
        public event EventHandler<IDisplayValues> DispenserChanged;
        public HeaderModel HeaderModel;
        public PompEngineModel PompEngine;
        public DispenserModel()
        {
            HeaderModel = new HeaderModel();
            PompEngine = new PompEngineModel(this);
        }
        public void TurnOn()
        {
        }
        public void TurnOff()
        {
        }
        public void PickUpNozzle(int num)
        {
        }
        public void PutDownNozzle()
        {
        }
        public void PressTriggerInGun()
        {
        }
        public void ReleaseTriggerInGun()
        {
        }
        public void SetPrice(PriceModel price, int nozzle)
        {

        }

        void IPompEngineService.SetPompEngineValue(decimal value)
        {
            
        }
    }
}
