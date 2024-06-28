using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomps.Layer.src.Domain.Entities.Distributor;

namespace Pomps.Layer.src.Application
{
    public interface IViewPanel
    {
        void ShowPomps(IList<Distributor> items);

    }
}
