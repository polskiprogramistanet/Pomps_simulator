using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Application
{
    interface IInformationValue
    {
        int DistributorNumber { get; set; }
        string Value { get; set; }
    }
}
