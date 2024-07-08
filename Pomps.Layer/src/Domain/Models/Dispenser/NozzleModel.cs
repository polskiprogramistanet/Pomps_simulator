using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Domain.Models.Dispenser
{
   internal class NozzleModel
    {
        public int Id { get; set; }
        public int PompId { get; set; }
        public int Number { get; set; }
        public int ProductCode { get; set; }
        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public string FuelSymbol { get; set; }
        public PriceModel Price { get; set; }
        public decimal Totalizer { get; set; }
    }
}
