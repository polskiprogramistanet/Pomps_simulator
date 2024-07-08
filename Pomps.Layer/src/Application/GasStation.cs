using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Pomps.Layer.src.Domain.Models.Dispenser;
using Pomps.Layer.src.Persistence;
using Pomps.Layer.src.Common;

namespace Pomps.Layer.src.Application
{
    public class GasStation : IGasStationOperation
    {
        INozzlesRepositoryOperation nozzles = null;
        IPompsRepositoryOperation pomps = null;
        IPricesRepositoryOperation prices = null;
        ISimulationOperations sim = null;

        public GasStation()
        {
            prices = new PricesRepository();
            prices.Execute();
            nozzles = new NozzlesRepository(prices);
            nozzles.Execute();
            pomps = new PompsRepository(nozzles);
            pomps.Execute();

            Monitoring.ShowSetDistributors(pomps.GetItems());
        }
        public int GetCountDistributors => pomps.Count;
        public void StartSimulation()
        {
            try
            {
                if (this.GetCountDistributors == 0) throw new Exception("Brak dystrybutorów...");
                sim = new SimulatorEngine(pomps);
                sim.StartSimulation();
                Thread thr = new Thread(sim.StartSimulation);
                thr.Start();

            }
            catch (Exception ex)
            {
                Console.WriteLine("GasStation.StartSimulation: {0}", ex.Message); 
            }
        }
    }
}
