using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Common
{
    static class Monitoring
    {
        public static void ShowSetDistributors(IList<DispenserModel> items)
        {
            try
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine("Załadowany zestaw: ");
                foreach (var pomp in items)
                {
                    Console.WriteLine("Dystrybutor nr: {0}", pomp.Number);
                    foreach(var nozz in pomp.Nozzles)
                    {
                        Console.WriteLine(" + wąż: {0} {1} {2}", nozz.Number, nozz.FuelName.Trim(), nozz.Price.Value.ToString("#.00 zł"));
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
