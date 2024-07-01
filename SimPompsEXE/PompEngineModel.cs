using SimPompsEXE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class PompEngineModel
    {
        IPompEngineService service;
        bool eng;
        Thread pomping;
        public decimal Value { get; private set; }
        public PompEngineModel(IPompEngineService service) 
        { 
            this.service = service;
            this.pomping = new Thread(engine);
        }
        public void PompOn()
        {
            this.eng = true;
            this.pomping.Start();
        }
        public void PompOff() 
        {
            this.eng = false;
        }
        public void ResetValue()
        {
            this.Value = 0;
        }
        void engine()
        {
            while (eng) 
            {
                this.Value += 0.25m;
                this.service.SetPompEngineValue(Value);
                Thread.Sleep(500);
            }
        }
    }
}
