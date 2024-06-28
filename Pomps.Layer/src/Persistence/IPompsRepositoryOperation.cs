using System;
using System.Collections.Generic;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Persistence
{
    interface IPompsRepositoryOperation
    {
        int Count { get; }
        void Execute();
        IList<Distributor> GetItems();
        Distributor GetItem(int num);
    }
}