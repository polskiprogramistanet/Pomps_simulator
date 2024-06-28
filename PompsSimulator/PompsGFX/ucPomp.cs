using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pomps.Layer.src.Domain.Entities.Distributor;
using Pomps.Layer.src.Application;

namespace PompsSimulator.PompsGFX
{
    public partial class ucPomp : UserControl
    {
        Distributor distributor;

        public ucPomp(Point position)
        {
            InitializeComponent();
            this.Location = position;
            distributor = new Distributor();
            distributor.DisplayInformationHandler += Distributor_DisplayInformationHandler;
        }

        private void Distributor_DisplayInformationHandler(object sender, IDisplayValues e)
        {
            if(e.TurnOnState == Pomps.Layer.src.Common.DistributorEnbEnum.ON)
            {
                this.lblAmount.BackColor = Color.Gold;
                this.lblVolume.BackColor = Color.Gold;
                this.lblPrice.BackColor = Color.Gold;
            }

            else
            {
                this.lblAmount.BackColor = Color.Gray;
                this.lblVolume.BackColor = Color.Gray;
                this.lblPrice.BackColor = Color.Gray;
            }
                
        }

        public int Number
        {
            set
            {
                this.lblNumber.Text = value.ToString();
            }
        }
        public decimal Price
        {
            set
            {
                this.lblPrice.Text = value.ToString();
            }
        }
        public decimal Volume
        {
            set
            {
                this.lblVolume.Text = value.ToString();
            }

        }

        private void Pomp_Load(object sender, EventArgs e)
        {

        }

        private void tsmPowerSwitch_Click(object sender, EventArgs e)
        {
            if(distributor.TurnOnState == Pomps.Layer.src.Common.DistributorEnbEnum.OFF)
                distributor.TurnOn();
            else
                distributor.TurnOff();
        }
    }
}
