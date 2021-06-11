using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Data.Models
{
    public class CryptoCoinModel
    {
     
        public string Symbol { get; set; }
        public double AmountOwned { get; set; }

        public double USD { get; set; }
        public double EUR { get; set; }
        public double BTC { get; set; }
    }
}
