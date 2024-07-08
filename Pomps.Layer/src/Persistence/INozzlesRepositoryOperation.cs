using System.Collections.Generic;
using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Persistence
{
    interface INozzlesRepositoryOperation
    {
        void Execute();
        List<NozzleModel> GetNozzles(int idPomp);
    }
}