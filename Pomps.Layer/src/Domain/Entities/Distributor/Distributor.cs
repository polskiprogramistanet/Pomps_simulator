using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Application;
using Pomps.Layer.src.Domain.Entities.Distributor.Observers;
using Pomps.Layer.src.Common;

namespace Pomps.Layer.src.Domain.Entities.Distributor
{
   public class Distributor : IDistributorOperation, IObserverValidatorCommand, IObserverEngineInformation, IObserverDisplayInformation
    {
        Engine engine;
        internal Nozzle nozzActive { get; set; }
        internal static decimal preselectionAmount { get; set; }
        internal Validator validator = null;
        
        //public event EventHandler<LedDisplay> DistributorStateEnable;
        public event EventHandler<IDisplayValues> DisplayInformationHandler;
        //public event EventHandler<IInformationValue> InformationHandler;
        //public event EventHandler<IDisplayValues> EndOfTransaction;
        IInformationValue InformationOfPomp;
        public int DistributorNumber { get; set; }
        public ProtocolEnum Protocol { get; private set; }
        public LedDisplay Display { get; private set; }
        public List<Nozzle> Nozzles { get; set; }
        public bool Auto { get; set; }
        public DistributorEnbEnum TurnOnState { get; set; }
        public int NozzlesCount => Nozzles.Count;

        public Distributor()
        {
            this.Display = new LedDisplay(this);
            this.engine = new Engine(this);
            this.validator = new Validator(this);
            
        }
        public void PickUpNozzle(int number)
        {
            nozzActive = this.Nozzles.Find(x => x.Num == number);
            this.nozzActive.Nozzle_UP();
            validator.Validate(this);
        }
        public void PutDownNozzle(int number)
        {
            nozzActive.Nozzle_DOWN();
            validator.Validate(this);
        }
        public void TurnOn()
        {
            if (TurnOnState == DistributorEnbEnum.OFF)
            {
                this.TurnOnState = DistributorEnbEnum.ON;
                Display.Display_On();
                DisplayInformationHandler?.Invoke(this, Display);
            }
                
        }
        public void TurnOff()
        {
            IInformationValue information = new InformationValue { DistributorNumber = this.DistributorNumber, Value = "Dystrybutor wyłączony" };
            if (TurnOnState == DistributorEnbEnum.ON)
            {
                this.TurnOnState = DistributorEnbEnum.OFF;
                Display.Display_Off();
                DisplayInformationHandler?.Invoke(this, Display);
            }
        }
        public void SetPresselectionAmount(decimal amount)
        {
            preselectionAmount = amount;
        }
        public void PressTriggerInTheGun()
        {
            nozzActive.Trigger_ON();
            validator.Validate(this);
        }
        public void RelaseTriggerInTheGun()
        {
            nozzActive.Trigger_OFF();
            validator.Validate(this);
        }

        #region "FROM VALIDATOR"

        public void SetResetDisplayFromValidator()
        {
            Display.Display_Reset();
            Display.SetPriceActive(nozzActive.ProductCode);

            InformationOfPomp = new InformationValue { DistributorNumber = this.DistributorNumber, Value = "Dystrybutor zresetował liczydło" };
            //InformationHandler?.Invoke(this, InformationOfPomp);

            //DisplayInformationHandler?.Invoke(this, this.Display);
        }
        public void SetEngineStateCommandFromValidator(EngineState value)
        {
            if (value == EngineState.On)
                engine.Run();
            else if (value == EngineState.OFF)
                engine.Stop();
            else if(value == EngineState.Stopping)
                engine.Stop();
        }
        public void SetEnginePumpingCommandFromValidator(TriggerState trigger)
        {
            engine.SetTriggerState(trigger);
            if (trigger == TriggerState.ON)
            {
                InformationOfPomp = new InformationValue { DistributorNumber = this.DistributorNumber, Value = "Tankowanie w toku" };
                //InformationHandler?.Invoke(this, InformationOfPomp);
            }
            else
            {
                InformationOfPomp = new InformationValue { DistributorNumber = this.DistributorNumber, Value = "Wstrzymano tankowanie" };
                //InformationHandler?.Invoke(this, InformationOfPomp);
            }
        }
        public void SetRefuelingDoneFromValidator()
        {
            //EndOfTransaction?.Invoke(this, this.Display);
        }
        #endregion
        
        #region "FROM ENGINE"

        public void SetPumpingInformationFromEngine(decimal value)
        {
            if(this.nozzActive.Trigger == TriggerState.ON)
                this.Display.SetVolume(value);
            //validator.Validate(this);
        }
        public void SetEngineStateInfoFromEngine(EngineState state)
        {
            if (state == EngineState.On)
                InformationOfPomp = new InformationValue { DistributorNumber = this.DistributorNumber, Value = "Dystrybutor załączył pompę" };
            else
            {
                InformationOfPomp = new InformationValue { DistributorNumber = this.DistributorNumber, Value = "Dystrybutor wyłączył pompę" };
                validator.Validate(this);
            }
                
            //InformationHandler?.Invoke(this, InformationOfPomp);

            //DisplayInformationHandler?.Invoke(this, this.Display);
        }
        public void SetEngineStateInfoFromEngine(TriggerState state)
        {
            if(state == TriggerState.OFF)
            {
               // validator.Validate(this);
            }
        }
        
        #endregion

        public void SetPumpingInformationFromDisplay(IDisplayValues value)
        {
            //DisplayInformationHandler?.Invoke(this, this.Display);
        }

    }

    class InformationValue : IInformationValue
    {
        public int DistributorNumber { get; set; }
        public string Value { get; set ; }
    }

}
