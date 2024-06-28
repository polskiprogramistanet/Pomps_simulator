using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class HeaderModel
    {
        public MemoryModel Memory { get; set; }
        public HeaderModel() 
        { 
            Memory = new MemoryModel();
        }    
    }
}
