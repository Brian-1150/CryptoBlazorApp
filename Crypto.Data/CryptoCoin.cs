using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Data
{
   public class CryptoCoin
    {
        //fsym is name of parameter on api side
        public string Symbol { get; set; }

        public double AmountOwned { get; set; }

        //[JsonProperty("USD")]
        public double USD { get; set; }
        public double EUR { get; set; }
        public double BTC { get; set; }
    }
}
