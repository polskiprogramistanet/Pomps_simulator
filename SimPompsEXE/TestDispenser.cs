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
        Employee employee;
        public TestDispenser()
        {
            model = new DispenserModel();
             
            model.SetPrice(new PriceModel() { Value = 4.55m, NozzleNum = 1 }, 1);
            model.SetPrice(new PriceModel() { Value = 6.55m, NozzleNum = 2 }, 2);
            model.SetPrice(new PriceModel() { Value = 7.55m, NozzleNum = 3 }, 3);
            model.SetPrice(new PriceModel() { Value = 2.55m, NozzleNum = 4 }, 4);
            employee = new Employee(model);
            employee.Init();
        }

        
    }
}
