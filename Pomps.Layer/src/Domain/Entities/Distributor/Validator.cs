using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Entities.Distributor.Observers;

namespace Pomps.Layer.src.Domain.Entities.Distributor
{
    class Validator
    {
        Distributor pomp;
        PompState state;
        //IObserverValidatorCommand observer;

        public Validator(IObserverValidatorCommand observer)
        {
            state = PompState.READY;
            PompState.observer = observer;
        }
        public void Validate(Distributor pomp)
        {
            this.pomp = pomp;
            state.Validate(this.pomp);
        }
        public PompState GetState
        {
            get
            {
                return state;
            }
        }
        public void SetState(PompState state)
        {
            this.state = state;
        }
    }
    abstract class PompState
    {
        public static readonly PompState READY = new Ready();
        public static readonly PompState BLOCK = new Block();
        public static readonly PompState NOZZLE_UP = new NozzleUp();
        public static readonly PompState REFUELING_PROGRESS = new RefuelingProgress();
        public static readonly PompState REFUELING_DONE = new RefuelingDone();
        internal static IObserverValidatorCommand observer;
        public abstract void Validate(Distributor pomp);
    }
    class Ready : PompState
    {
        Distributor pomp;
        public override void Validate(Distributor pomp)
        {
            this.pomp = pomp;
            if (!pomp.Auto && pomp.nozzActive.NozzleState == NozzleState.UP)
            {
                //observer.SetResetDisplayFromValidator();
                observer.SetEngineStateCommandFromValidator(EngineState.On);
                pomp.validator.SetState(PompState.NOZZLE_UP);
            }
        }
    }
    class Block : PompState
    {
        public override void Validate(Distributor pomp)
        {
            throw new NotImplementedException();
        }
    }
    class NozzleUp : PompState
    {
        public override void Validate(Distributor pomp)
        {
            
            if (pomp.nozzActive.Trigger == TriggerState.ON)
            {
                observer.SetEnginePumpingCommandFromValidator(TriggerState.ON);
                pomp.validator.SetState(PompState.REFUELING_PROGRESS);
            }
            else
            {
                if(pomp.nozzActive.NozzleState== NozzleState.DOWN)
                    pomp.validator.SetState(PompState.REFUELING_DONE);
                else
                    pomp.validator.SetState(PompState.NOZZLE_UP);
            }
        }
    }
    class RefuelingProgress : PompState
    {
        public override void Validate(Distributor pomp)
        {
            if (pomp.nozzActive.Trigger == TriggerState.ON && pomp.Display.Amount <= Distributor.preselectionAmount)
            {
                observer.SetEnginePumpingCommandFromValidator(TriggerState.ON);
            }
            else
            {
                
                //pomp.nozzActive.Trigger = TriggerState.OFF;

                if (pomp.nozzActive.NozzleState == NozzleState.DOWN)
                {
                    pomp.validator.SetState(PompState.REFUELING_DONE);
                    observer.SetEngineStateCommandFromValidator(EngineState.OFF);
                }
                //observer.SetEnginePumpingCommandFromValidator(TriggerState.OFF);
            }
        }
    }
    class RefuelingDone : PompState
    {
        public override void Validate(Distributor pomp)
        {
            observer.SetRefuelingDoneFromValidator();
            if (!pomp.Auto)
            {
                pomp.validator.SetState(PompState.READY);
            }
        }
    }
}
