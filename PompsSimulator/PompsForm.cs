using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pomps.Layer.src.Application;
using Pomps.Layer.src.Domain.Entities.Distributor;
using PompsSimulator.PompsGFX;

namespace PompsSimulator
{
    public partial class PompsForm : Form, IViewPanel
    {
        IPresenterPanel panel = null;
        List<ucPomp> pomps = null;

        public PompsForm()
        {
            InitializeComponent();
            pomps = new List<ucPomp>();
            panel = new PresenterPanel(this);
        }

        public void ShowPomps(IList<Distributor> items)
        {
            ucPomp pomp = new ucPomp(new Point(10, 10));
            int horizontal = 10;
            foreach (var item in items)
            {
                Point point = new Point(horizontal, 10);
                pomp = new ucPomp(point);
                pomp.Price = item.Nozzles[0].Price;
                
                this.pnlPomps.Controls.Add(pomp);
                horizontal = pomp.Width + 10;
            }
        }

        private void PompsForm_Load(object sender, EventArgs e)
        {
            panel.Init();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task t = new Task(panel.StartEngine);
            t.Start();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
