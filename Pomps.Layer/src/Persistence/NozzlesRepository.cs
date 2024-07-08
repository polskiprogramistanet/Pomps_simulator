using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Persistence
{
    class NozzlesRepository : IDataBase, INozzlesRepositoryOperation
    {
        string query;
        List<NozzleModel> nozzles;
        readonly IPricesRepositoryOperation prices = null;
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
                nozzles = new List<NozzleModel>();
                while (rd.Read())
                {
                    NozzleModel nozzle = new NozzleModel();
                    nozzle.Number = (int)rd[6];
                    nozzle.ProductCode = (int)rd[8];
                    nozzle.PompId = (int)rd[1];
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
        public List<NozzleModel> GetNozzles(int pompId)
        {
            return nozzles.FindAll(x => x.PompId == pompId);
        }
                
    }
}
