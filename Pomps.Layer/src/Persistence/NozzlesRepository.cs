using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Persistence
{
    class NozzlesRepository : IDataBase, INozzlesRepositoryOperation
    {
        string query;
        List<Nozzle> nozzles;
        IPricesRepositoryOperation prices = null;
        public NozzlesRepository(IPricesRepositoryOperation prices)
        {
            this.prices = prices;
            this.query = "SELECT [noz_Id],[noz_IdPomp],[noz_DSN],[noz_IdDef],[noz_Nazwa],[noz_Symbol],[noz_NrNozzle],[noz_Total_Aktualny],[noz_PRC]FROM [dbo].[Fuel_Nozzle];";
        }
        public void Execute()
        {
            DataService.SetQuery(this.query, this);
        }
        public object DbReader(IDataReader rd)
        {
            try
            {
                nozzles = new List<Nozzle>();
                while (rd.Read())
                {
                    Nozzle nozzle = new Nozzle();
                    nozzle.Num = (int)rd[6];
                    nozzle.ProductCode = (int)rd[8];
                    nozzle.IdPomp = (int)rd[1];
                    nozzle.FuelId = (int)rd[3];
                    nozzle.FuelName = rd[4].ToString();
                    nozzle.FuelSymbol = rd[5].ToString();
                    nozzle.Price = prices.GetPRice(nozzle.FuelId);
                    nozzle.Totalizer = (decimal)rd[7];
                    nozzles.Add(nozzle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Załadowano zestaw {0} węży...", nozzles.Count);
            }
            return null;
        }
        public List<Nozzle> GetNozzles(int idPomp)
        {
            return nozzles.FindAll(x => x.IdPomp == idPomp);
        }
                
    }
}
