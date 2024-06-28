using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PompsSimulator.ConfigForms
{
    public partial class providerForm : Form
    {
        public string Provider { get; set; }
        public providerForm(string provider)
        {
            InitializeComponent();
            this.rtxProvider.Text = provider;
        }
    }
}
