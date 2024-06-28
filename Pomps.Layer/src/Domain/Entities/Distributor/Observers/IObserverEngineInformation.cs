﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Entities.Distributor.Observers
{
    interface IObserverEngineInformation
    {
        void SetPumpingInformationFromEngine(decimal value);
        void SetEngineStateInfoFromEngine(EngineState state);
        void SetEngineStateInfoFromEngine(TriggerState state);
    }
}