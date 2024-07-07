using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimPompsEXE
{
    using Pomps.Layer.src.Application;
    using System.Reflection;
    using System.Runtime.Hosting;

    class Program
    {
        
        static void Main(string[] args)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.Title = $"Gas station sim. ver.: {version}";
            DispenserModel dispenser;
            Employee employee;
            try
            {
                dispenser = new DispenserModel();
                dispenser.SetPrice(new PriceModel() { Value = 4.55m, NozzleNum = 1 }, 1);
                dispenser.SetPrice(new PriceModel() { Value = 6.55m, NozzleNum = 2 }, 2);
                dispenser.SetPrice(new PriceModel() { Value = 7.55m, NozzleNum = 3 }, 3);
                dispenser.SetPrice(new PriceModel() { Value = 2.55m, NozzleNum = 4 }, 4);

                employee = new Employee(dispenser);
                employee.Init();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
                
            }
            
        }
       
    }

    
}
