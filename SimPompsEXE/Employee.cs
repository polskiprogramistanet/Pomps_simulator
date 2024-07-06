using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class Employee
    {
        IDispenser dispenser;
        
        int time = 0;
        int nozzNum = 0;
        decimal volume = 0;
        Random rnd = new Random();
        public Employee(IDispenser dispenser) 
        { 
            this.dispenser = dispenser;
            this.dispenser.DisplayValues += Dispenser_DispenserValues;
            this.dispenser.StateValues += Dispenser_StateValues;
            this.dispenser.DispenserEnbl += Dispenser_DispenserEnbl;
            this.dispenser.PompEngineEnbl += Dispenser_PompEngineEnbl;
            this.dispenser.NozzleState += Dispenser_NozzleState;
        }

        public void Init() 
        {
            this.time = rnd.Next(500, 5000);
            this.dispenser.TurnOn();
            Task tNozzleUp = new Task(nozzleUp);
            tNozzleUp.Wait(time);
            tNozzleUp.Start();
        }
        private void nozzleUp()
        {
            nozzNum = rnd.Next(1, 4);
            Console.WriteLine($"time = {time} Nozzle {nozzNum} is Up!");
            dispenser.PickUpNozzle(nozzNum);
        }
       
        private void Dispenser_NozzleState(object sender, Enums.NozzleStateEnum e)
        {
            if(e == Enums.NozzleStateEnum.Up)
            {
                this.volume = rnd.Next(5, 10);
                Task trigger = new Task(dispenser.PressTriggerInGun);
                this.time = rnd.Next(1500, 5000);
                Console.WriteLine($"Trigger time: {time}");
                trigger.Wait(time);
                trigger.Start();
            }
            else
            {
                Console.WriteLine($"Koniec tankowania");
                this.time = rnd.Next(1500, 5000);
                Task tNozzleUp = new Task(nozzleUp);
                tNozzleUp.Wait(time);
                tNozzleUp.Start();
            }
            
        }
        private void Dispenser_StateValues(object sender, StateValuesComplete e)
        {
            Console.WriteLine($"State value: pEnb={e.PompEngineEnbl} nState={e.NozzleState} nActiveNum={e.NozzleActiveNum}");
        }
        private void Dispenser_DispenserValues(object sender, DisplayValues e)
        {
            Console.WriteLine($"Cena: {e.Price}zł Ilość: {e.Volume}L. Wartość: {e.Amount}zł | limit: {volume}L.");
            if (e.Volume > volume)
            {
                this.time = rnd.Next(500, 5000);
                dispenser.ReleaseTriggerInGun();
                Task nozzle = new Task(dispenser.PutDownNozzle);
                nozzle.Wait(time);
                nozzle.Start();
            }
                
        }
        private void Dispenser_DispenserEnbl(object sender, Enums.DispenserEnblEnum e)
        {
            Console.WriteLine($"Dystrybutor status: {e.ToString()}");
        }
        private void Dispenser_PompEngineEnbl(object sender, Enums.PompEngineEnblEnum e)
        {
            Console.WriteLine($"Pompa status: {e.ToString()}");
        }

    }
}
