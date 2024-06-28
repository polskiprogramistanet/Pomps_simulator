using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Application
{
    interface IDistributorOperation
    {
        //event EventHandler<IInformationValue> InformationHandler;
        //event EventHandler<IDisplayValues> DisplayInformationHandler;
        //event EventHandler<IDisplayValues> EndOfTransaction;
        int NozzlesCount { get; }
        int DistributorNumber { get; }

        void PickUpNozzle(int number);
        void PutDownNozzle(int number);

        void TurnOn();
        void TurnOff();
        void PressTriggerInTheGun();
        void RelaseTriggerInTheGun();
        void SetPresselectionAmount(decimal amount);
    }
}
