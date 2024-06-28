using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Pomps.Layer.src.Persistence;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Application
{
    class SimulatorEngine : ISimulationOperations
    {
        IPompsRepositoryOperation pomps;
        
        public SimulatorEngine(IPompsRepositoryOperation pomps)
        {
            this.pomps = pomps;
        }
        public void StartSimulation()
        {
            //wylosuj dystrybutor który jest free
            
            try
            {
                while (true)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, pomps.Count + 1);
                    Distributor pomp = pomps.GetItem(num);
                    if(pomp.nozzActive == null)
                    {
                        int nozzNum = rnd.Next(1, pomp.NozzlesCount + 1);
                        pomp.PickUpNozzle(nozzNum);

                    }
                    Thread.Sleep(5000);
                    //Console.WriteLine("Random pomp: {0}", pomp.);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SimulatorEngine.StartSimulation: {0}", ex.Message); ;
            }
        }

        
    }
}
