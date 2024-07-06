using SimPompsEXE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimPompsEXE.Services;

namespace SimPompsEXE
{
    internal class MemoryModel
    {
        IMemoryService memoryService;
        public int Number { get; set; }
        public char Adress { get; set; }
        public DispenserEnblEnum DispenserEnbl { get; private set; }
        public NozzleStateEnum NozzleState { get; private set; }
        public PompEngineEnblEnum PompEngineEnbl { get; private set; }
        public int ActiveNozzleNum { get; private set; }
        public Dictionary<int, PriceModel> Prices { get; private set; }
       
        public MemoryModel(IMemoryService memoryService) 
        {
            Prices = new Dictionary<int, PriceModel>();
            this.memoryService = memoryService;
        }
        public void SetDispenserEnbl(DispenserEnblEnum value)
        {
            this.DispenserEnbl = value;
        }
        public void SetNozzleState(NozzleStateEnum value)
        {
            this.NozzleState = value;
        }
        public void SetPompEngineEnbl(PompEngineEnblEnum value)
        {
            this.PompEngineEnbl = value;
        }
        public void SetPrice(PriceModel value, int nozzNum)
        {
            this.Prices[nozzNum] = value;
        }
        public void SetActiveNozzle(int num)
        {
            this.ActiveNozzleNum = num; 
        }

    }
}
