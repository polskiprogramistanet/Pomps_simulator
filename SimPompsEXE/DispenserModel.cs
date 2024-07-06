using SimPompsEXE.Services;
using SimPompsEXE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Application;

namespace SimPompsEXE
{
    internal class DispenserModel : IPompEngineService, IMemoryService, ILedDisplayService, IDispenser
    {
        public event EventHandler<DisplayValues> DisplayValues;
        public event EventHandler<DisplayValues> EndOfTankValues;
        public event EventHandler<StateValuesComplete> StateValues;
        public event EventHandler<DispenserEnblEnum> DispenserEnbl;
        public event EventHandler<NozzleStateEnum> NozzleState;
        public event EventHandler<PompEngineEnblEnum> PompEngineEnbl;

        MemoryModel memory;
        PompEngineModel PompEngine;
        DisplayValues displayValues;
        StateValuesComplete stateValues;
        LedDisplayModel ledDisplayModel;
        List<NozzleModel> nozzles;
        public DispenserModel()
        {
            memory = new MemoryModel(this);
            displayValues = new DisplayValues();
            stateValues = new StateValuesComplete();
            PompEngine = new PompEngineModel(this);
            ledDisplayModel = new LedDisplayModel(this);
            nozzles = new List<NozzleModel>();
            for (int i = 1; i < 5; i++)
            {
                NozzleModel nozzle = new NozzleModel();
                PriceModel price = new PriceModel() { NozzleNum = i, Value = 0.00m };
                nozzle.Price = price;
                nozzle.Number = i;
                nozzles.Add(nozzle);
            }
        }
        public void TurnOn()
        {
            this.memory.SetDispenserEnbl(DispenserEnblEnum.ON);
            this.stateValues.DispenserEnbl = DispenserEnblEnum.ON;
            this.DispenserEnbl?.Invoke(this, DispenserEnblEnum.ON);
        }
        public void TurnOff()
        {
            this.memory.SetDispenserEnbl(DispenserEnblEnum.OFF);
            this.stateValues.DispenserEnbl = DispenserEnblEnum.OFF;
            this.DispenserEnbl?.Invoke(this, DispenserEnblEnum.OFF);
        }
        public void PickUpNozzle(int num)
        {
            this.ledDisplayModel.DisplayReset();
            
            this.memory.SetNozzleState(NozzleStateEnum.Up);
            this.memory.SetActiveNozzle(num);
            this.stateValues.NozzleActiveNum = num;
            this.stateValues.NozzleState = NozzleStateEnum.Up;
            this.NozzleState?.Invoke(this, NozzleStateEnum.Up);
            this.StateValues?.Invoke(this, stateValues);
        }
        public void PutDownNozzle()
        {
            this.memory.SetNozzleState(NozzleStateEnum.Down);
            this.stateValues.NozzleState = NozzleStateEnum.Down;
            this.NozzleState?.Invoke(this, NozzleStateEnum.Down);
        }
        public void PressTriggerInGun()
        {

            PompEngine.ResetValue();
            displayValues.Reset();
           

            this.PompEngine.PompOn();
            this.memory.SetPompEngineEnbl(PompEngineEnblEnum.ON);
            this.stateValues.PompEngineEnbl = PompEngineEnblEnum.ON;
            this.PompEngineEnbl?.Invoke(this, PompEngineEnblEnum.ON);
        }
        public void ReleaseTriggerInGun()
        {
            this.PompEngine.PompOff();
            this.memory.SetPompEngineEnbl(PompEngineEnblEnum.OFF);
            this.stateValues.PompEngineEnbl = PompEngineEnblEnum.OFF;
            this.PompEngineEnbl?.Invoke(this, PompEngineEnblEnum.OFF);
        }
        public void SetPrice(PriceModel price, int nozzleNum)
        {
            this.memory.Prices[nozzleNum] = price;
            this.nozzles.FirstOrDefault(x => x.Number == nozzleNum).Price = price;
        }
        void IPompEngineService.SetPompEngineValue(decimal value)
        {
            displayValues.Volume = value;
            displayValues.Price = nozzles.ElementAtOrDefault(memory.ActiveNozzleNum).Price.Value;
            displayValues.Amount = decimal.Round(displayValues.Price * displayValues.Volume, 2);
            DisplayValues(this, displayValues);
        }
        void ILedDisplayService.DisplayReset() 
        { 
             
            
        }
    }
}
