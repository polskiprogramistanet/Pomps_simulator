using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimPompsEXE
{
    using Pomps.Layer.src.Application;

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Symulator dystrybutorów. ver.: 1.0.1";
           
            try
            {
                TestDispenser testDispenser = new TestDispenser();
                



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
