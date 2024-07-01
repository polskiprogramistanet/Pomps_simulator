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
        public event EventHandler<DisplayValues> DispenserChanged;
        HeaderModel HeaderModel;
        PompEngineModel PompEngine;
        DisplayValues displayValues;
        List<NozzleModel> nozzles;
        public DispenserModel()
        {
            HeaderModel = new HeaderModel();
            displayValues = new DisplayValues();
            PompEngine = new PompEngineModel(this);
            nozzles = new List<NozzleModel>();
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
            this.PompEngine.PompOn();
        }
        public void ReleaseTriggerInGun()
        {
            this.PompEngine.PompOff();
        }
        public void SetPrice(PriceModel price, int nozzle)
        {

        }
        void IPompEngineService.SetPompEngineValue(decimal value)
        {
            displayValues.Volume = value;
            DispenserChanged(this, displayValues);
        }
    }
}
