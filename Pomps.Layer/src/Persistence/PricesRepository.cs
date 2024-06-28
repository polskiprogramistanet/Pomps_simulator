using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Persistence
{
    class PricesRepository : IDataBase, IPricesRepositoryOperation
    {
        readonly string query = null;
        List<Price> prices = null;
        public PricesRepository()
        {
            this.query = "SELECT [tc_IdTowar],[tc_CenaBrutto1] FROM [dbo].[tw_Cena] A LEFT JOIN  [dbo].[tw__Towar] B ON A.tc_IdTowar=B.tw_Id WHERE B.tw_Pole2='paliwo';";
        }
        public void Execute()
        {
            DataService.SetQuery(this.query, this);
        }
        public object DbReader(IDataReader rd)
        {
            try
            {
                prices = new List<Price>();
                while (rd.Read())
                {
                    Price price = new Price();
                    price.FuelId = (int)rd[0];
                    price.PriceValue = (decimal)rd[1];

                    prices.Add(price);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("PriceRepository: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Załadowano {0} pozycji cenowych...", prices.Count);
            }
            return null;
        }
        public decimal GetPRice(int FuelId)
        {
            return prices.Find(x => x.FuelId == FuelId).PriceValue;
        }
    }
}
