using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Persistence
{
    class PompsRepository : IDataBase, IPompsRepositoryOperation
    {
        readonly string query;
        List<DispenserModel> dispensers = null;
        readonly INozzlesRepositoryOperation nozzles = null;
        public int Count => dispensers.Count;
        public PompsRepository(INozzlesRepositoryOperation nozzles)
        {
            this.nozzles = nozzles;
            query = "SELECT [pom_Id],[pom_Adress],[pom_Nr],[pom_LNozzle],[pom_AutoGaz],[pom_ActivPomp],[pom_TrybPracy],[pom_DSN],[pom_SaveTrans],[pom_LastIdTrans] FROM [dbo].[Fuel_Pomps];";
            
        }
        public void Execute()
        {
            DataService.SetQuery(query, this);
        }
        public object DbReader(IDataReader rd)
        {
            try
            {
                dispensers = new List<DispenserModel>();

                while (rd.Read())
                {
                    DispenserModel dispenser = new DispenserModel();
                    
                    dispenser.SetNozzles(this.nozzles.GetNozzles((int)rd[0]));
                    dispenser.SetNumbersConfig((char)rd[1], (int)rd[2], (int)rd[4]);
                    dispensers.Add(dispenser);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("PompsRepository.DbReader: {0}", ex.Message);
            }
            
            return null;
        }
        public IList<DispenserModel> GetItems()
        {
            return dispensers;
        }
        public DispenserModel GetItem(int num)
        {
            return dispensers.Find(i => i.Number == num);
        }
    }
}
