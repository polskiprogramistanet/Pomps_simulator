using System;
using System.Collections.Generic;
using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Persistence
{
    interface IPompsRepositoryOperation
    {
        int Count { get; }
        void Execute();
        IList<DispenserModel> GetItems();
        DispenserModel GetItem(int num);
    }
}