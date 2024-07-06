using SimPompsEXE.Enums;
using System;

namespace SimPompsEXE
{
    internal interface IDispenser
    {
        event EventHandler<DisplayValues> DisplayValues;
        event EventHandler<StateValuesComplete> StateValues;
        event EventHandler<DispenserEnblEnum> DispenserEnbl;
        event EventHandler<NozzleStateEnum> NozzleState;
        event EventHandler<PompEngineEnblEnum> PompEngineEnbl;
        void PickUpNozzle(int num);
        void PressTriggerInGun();
        void PutDownNozzle();
        void ReleaseTriggerInGun();
        void SetPrice(PriceModel price, int nozzleNum);
        void TurnOff();
        void TurnOn();
    }
}