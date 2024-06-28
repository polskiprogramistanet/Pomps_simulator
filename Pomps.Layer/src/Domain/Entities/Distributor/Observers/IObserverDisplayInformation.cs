using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Application;

namespace Pomps.Layer.src.Domain.Entities.Distributor.Observers
{
   public interface IObserverDisplayInformation
    {
        void SetPumpingInformationFromDisplay(IDisplayValues value);
    }
}
