using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Persistence;

namespace Pomps.Layer.src.Application
{
    public class PresenterPanel : IPresenterPanel
    {
        IViewPanel view = null;
        ISimulationOperations operations = null;
        IPompsRepositoryOperation pomps = null;
        INozzlesRepositoryOperation nozzles = null;
        IPricesRepositoryOperation prices = null;

        public PresenterPanel(IViewPanel view)
        {
            this.view = view;
        }

        public void Init()
        {
            prices = new PricesRepository();
            prices.Execute();
            nozzles = new NozzlesRepository(prices);
            nozzles.Execute();
            pomps = new PompsRepository(nozzles);
            pomps.Execute();
            operations = new SimulatorEngine(pomps);
            
            view.ShowPomps(pomps.GetItems());
        }

        public void StartEngine()
        {
            operations.StartSimulation();
        }
    }
}
