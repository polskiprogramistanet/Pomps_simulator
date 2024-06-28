using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Application
{
    public interface IGasStationOperation
    {
        int GetCountDistributors { get;}
        void StartSimulation();        
    }
}
