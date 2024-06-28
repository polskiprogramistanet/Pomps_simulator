using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Entities.Distributor
{
    static class Memory
    {
        public static Dictionary<int, decimal> Prices = new Dictionary<int, decimal>();
        public static decimal[] Total { get; set; } = new decimal[4];
        public static string Protocol { get; set; }
    }
}
