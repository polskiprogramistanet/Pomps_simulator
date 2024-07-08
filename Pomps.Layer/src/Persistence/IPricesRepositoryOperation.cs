using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Persistence
{
    interface IPricesRepositoryOperation
    {
        void Execute();
        PriceModel GetPRice(int FuelId);
    }
}