using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimPompsEXE
{
    internal class TestDispenser
    {
        DispenserModel model;   
        public TestDispenser()
        {
            model = new DispenserModel();
            model.DispenserChanged += Model_DispenserChanged;
            model.PressTriggerInGun();
        }

        private void Model_DispenserChanged(object sender, DisplayValues e)
        {
            Console.WriteLine(e.Volume);
        }
    }
}
