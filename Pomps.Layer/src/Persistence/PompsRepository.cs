using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Persistence
{
    class PompsRepository : IDataBase, IPompsRepositoryOperation
    {
        readonly string query;
        List<Distributor> distributors = null;
        readonly INozzlesRepositoryOperation nozzles = null;
        public int Count => distributors.Count;
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
                distributors = new List<Distributor>();

                while (rd.Read())
                {
                    Distributor distributor = new Distributor();
                    if((int)rd[4]==1)
                        distributor.Auto = true;
                    distributor.Nozzles = this.nozzles.GetNozzles((int)rd[0]);
                    distributor.DistributorNumber = (int)rd[2];
                    distributors.Add(distributor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("PompsRepository.DbReader: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Załadowano {0} zestawów dystrybutorów...", distributors.Count);
            }
            return null;
        }
        public IList<Distributor> GetItems()
        {
            return distributors;
        }
        public Distributor GetItem(int num)
        {
            return distributors.Find(i => i.DistributorNumber == num);
        }
    }
}
