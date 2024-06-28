using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Common
{
    static class Monitoring
    {
        public static void ShowSetDistributors(IList<Distributor> items)
        {
            try
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine("Załadowany zestaw: ");
                foreach (var pomp in items)
                {
                    Console.WriteLine("Dystrybutor nr: {0}", pomp.DistributorNumber);
                    foreach(var nozz in pomp.Nozzles)
                    {
                        Console.WriteLine(" + wąż: {0} {1} {2}", nozz.Num, nozz.FuelName.Trim(), nozz.Price.ToString("#.00 zł"));
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = color;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ShowSetDistributors: {0}", ex.Message);       
            }
        }
    }
}
