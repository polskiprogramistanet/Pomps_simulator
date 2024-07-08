using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Stateless;
using Pomps.Layer.src.Domain.Models.Services;

namespace Pomps.Layer.src.Domain.Models.Dispenser
{
    internal class PompEngineModel
    {
        IPompEngineService service;
        bool eng;
        Task pomping;
        public decimal Value { get; private set; }
        public PompEngineModel(IPompEngineService service)
        {
            this.service = service;

        }
        public void PompOn()
        {
            this.eng = true;
            this.pomping = new Task(engine);
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
            try
            {
                while (eng)
                {
                    this.Value += 0.25m;
                    this.service.SetPompEngineValue(Value);
                    this.pomping.Wait(500);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    
}
