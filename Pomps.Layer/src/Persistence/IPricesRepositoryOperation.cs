namespace Pomps.Layer.src.Persistence
{
    interface IPricesRepositoryOperation
    {
        void Execute();
        decimal GetPRice(int FuelId);
    }
}