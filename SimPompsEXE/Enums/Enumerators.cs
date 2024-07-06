using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE.Enums
{
    internal enum DispenserEnblEnum
    {
        OFF = 0,
        ON = 1
    }
    internal enum OperationModeEnum
    {
        Manual = 0,
        Auto = 1
    }
    internal enum NozzleStateEnum
    {
        Down,
        Up
    }
    internal enum PompEngineEnblEnum
    {
        OFF,
        ON
    }
    internal enum ProtocolEnum 
    { 
        EHL, 
        Logitron, 
        Petromis
    }
}
