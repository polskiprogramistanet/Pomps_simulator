using SimPompsEXE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    
    internal class PompEngineModel
    {
        IPompEngineService service;
        public decimal Value { get; private set; }
        public PompEngineModel(IPompEngineService service) 
        { 
            this.service = service;
        }
        public void PompOn()
        {

        }
        public void PompOff() 
        { 
        
        }

    }
}
