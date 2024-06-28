using System.Collections.Generic;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Persistence
{
    interface INozzlesRepositoryOperation
    {
        void Execute();
        List<Nozzle> GetNozzles(int idPomp);
    }
}