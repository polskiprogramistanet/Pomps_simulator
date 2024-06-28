using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Stateless;
using Pomps.Layer.src.Domain.Entities.Distributor.Observers;

namespace Pomps.Layer.src.Domain.Entities.Distributor
{
    class Engine
    {
        IObserverEngineInformation observer;
        Thread thread;
        public decimal Value { get; set; }
        public EngineState State { get; private set; }
        TriggerState Trigger { get; set; }
        public Engine(IObserverEngineInformation observer)
        {
            this.observer = observer;
        }
        public void Run()
        {
            if(State == EngineState.OFF)
            {
                State = EngineState.On;
                thread = new Thread(Pumping);
                thread.Start();
                 
                observer.SetEngineStateInfoFromEngine(EngineState.On);
            }
            
        }
        public void Stop()
        {
            State = EngineState.OFF;
            observer.SetEngineStateInfoFromEngine(EngineState.OFF);
        }
        public void SetTriggerState(TriggerState state)
        {
            this.Trigger = state;
        }
        void Pumping()
        {
            while (State == EngineState.On)
            {
                Thread.Sleep(1500);
                if (Trigger == TriggerState.ON)
                {
                    
                    Value = Value + 1.25M;
                    //observer.SetPumpingInformationFromEngine(Value);
                }
                observer.SetPumpingInformationFromEngine(Value);
            }
            observer.SetEngineStateInfoFromEngine(EngineState.OFF);
            observer.SetPumpingInformationFromEngine(Value);
            if(thread != null)
                thread.Abort();
        }
    }

   public enum EngineState { OFF, On, Stopping}
}
