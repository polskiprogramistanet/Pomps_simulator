using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Models.Dispenser
{
    class PriceModel
    {
        public int Id {  get; set; }    
        public int FuelId { get; set; }
        public decimal Value { get; set; }
        public string ProductCode { get; set; }
        public int NozzleNum { get; set; }
    }
}
