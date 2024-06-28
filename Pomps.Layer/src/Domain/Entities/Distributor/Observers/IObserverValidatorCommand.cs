using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Entities.Distributor.Observers
{
    interface IObserverValidatorCommand 
    {
        void SetResetDisplayFromValidator();
        void SetEngineStateCommandFromValidator(EngineState value);
        void SetEnginePumpingCommandFromValidator(TriggerState trigger);
        void SetRefuelingDoneFromValidator();
    }

    
}
