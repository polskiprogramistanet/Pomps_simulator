using Pomps.Layer.src.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Models.Services;

namespace Pomps.Layer.src.Domain.Models.Dispenser
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
        internal List<NozzleModel> Nozzles { get; private set; }
        public int Number { get => memory.Number; }
        public DispenserModel()
        {
            memory = new MemoryModel(this);
            displayValues = new DisplayValues();
            stateValues = new StateValuesComplete();
            PompEngine = new PompEngineModel(this);
            ledDisplayModel = new LedDisplayModel(this);
            Nozzles = new List<NozzleModel>();
            for (int i = 1; i < 5; i++)
            {
                NozzleModel nozzle = new NozzleModel();
                PriceModel price = new PriceModel() { NozzleNum = i, Value = 0.00m };
                nozzle.Price = price;
                nozzle.Number = i;
                Nozzles.Add(nozzle);
            }
        }
        public void SetNozzles(List<NozzleModel> nozzles)
        {
            this.Nozzles = nozzles;
        }
        public void SetNumbersConfig(char address, int number, int auto)
        {
            this.memory.Adress = address;
            this.memory.Number = number;
            this.memory.Auto = auto;
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
            this.Nozzles.FirstOrDefault(x => x.Number == nozzleNum).Price = price;
        }
        void IPompEngineService.SetPompEngineValue(decimal value)
        {
            displayValues.Volume = value;
            displayValues.Price = Nozzles.ElementAtOrDefault(memory.ActiveNozzleNum).Price.Value;
            displayValues.Amount = decimal.Round(displayValues.Price * displayValues.Volume, 2);
            DisplayValues(this, displayValues);
        }
        void ILedDisplayService.DisplayReset()
        {


        }
    }
}
