﻿using Pomps.Layer.src.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Models.Dispenser
{
    internal class StateValuesComplete
    {
        public DispenserEnblEnum DispenserEnbl { get; set; }
        public OperationModeEnum OperationMode { get; set; }
        public NozzleStateEnum NozzleState { get; set; }
        public PompEngineEnblEnum PompEngineEnbl { get; set; }
        public int NozzleActiveNum { get; set; }
        public int DispenserNum { get; set; }
    }
}