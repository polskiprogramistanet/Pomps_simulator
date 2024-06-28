using Pomps.Layer.src.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Application
{
    public interface IDisplayValues
    {
        decimal Amount { get; }
        decimal Volume { get; }
        decimal Price { get; }
        DistributorEnbEnum TurnOnState { get; }
    }
}
