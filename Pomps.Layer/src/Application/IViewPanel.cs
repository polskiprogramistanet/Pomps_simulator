using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Models.Dispenser;

namespace Pomps.Layer.src.Application
{
    internal interface IViewPanel
    {
        void ShowPomps(IList<DispenserModel> items);

    }
}
