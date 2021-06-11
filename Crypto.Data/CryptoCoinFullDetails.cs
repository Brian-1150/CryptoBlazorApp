using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Data
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class CryptoCoinFullDetails
    {
        [JsonProperty("TYPE")]
        public string TYPE { get; set; }

        [JsonProperty("MARKET")]
        public string MARKET { get; set; }

        [JsonProperty("FROMSYMBOL")]
        public string FROMSYMBOL { get; set; }

        [JsonProperty("TOSYMBOL")]
        public string TOSYMBOL { get; set; }

        [JsonProperty("FLAGS")]
        public string FLAGS { get; set; }

        [JsonProperty("PRICE")]
        public double PRICE { get; set; }

        [JsonProperty("LASTUPDATE")]
        public int LASTUPDATE { get; set; }

        [JsonProperty("MEDIAN")]
        public double MEDIAN { get; set; }

        [JsonProperty("LASTVOLUME")]
        public double LASTVOLUME { get; set; }

        [JsonProperty("LASTVOLUMETO")]
        public double LASTVOLUMETO { get; set; }

        [JsonProperty("LASTTRADEID")]
        public string LASTTRADEID { get; set; }

        [JsonProperty("VOLUMEDAY")]
        public double VOLUMEDAY { get; set; }

        [JsonProperty("VOLUMEDAYTO")]
        public double VOLUMEDAYTO { get; set; }

        [JsonProperty("VOLUME24HOUR")]
        public double VOLUME24HOUR { get; set; }

        [JsonProperty("VOLUME24HOURTO")]
        public double VOLUME24HOURTO { get; set; }

        [JsonProperty("OPENDAY")]
        public double OPENDAY { get; set; }

        [JsonProperty("HIGHDAY")]
        public double HIGHDAY { get; set; }

        [JsonProperty("LOWDAY")]
        public double LOWDAY { get; set; }

        [JsonProperty("OPEN24HOUR")]
        public double OPEN24HOUR { get; set; }

        [JsonProperty("HIGH24HOUR")]
        public double HIGH24HOUR { get; set; }

        [JsonProperty("LOW24HOUR")]
        public double LOW24HOUR { get; set; }

        [JsonProperty("LASTMARKET")]
        public string LASTMARKET { get; set; }

        [JsonProperty("VOLUMEHOUR")]
        public double VOLUMEHOUR { get; set; }

        [JsonProperty("VOLUMEHOURTO")]
        public double VOLUMEHOURTO { get; set; }

        [JsonProperty("OPENHOUR")]
        public double OPENHOUR { get; set; }

        [JsonProperty("HIGHHOUR")]
        public double HIGHHOUR { get; set; }

        [JsonProperty("LOWHOUR")]
        public double LOWHOUR { get; set; }

        [JsonProperty("TOPTIERVOLUME24HOUR")]
        public double TOPTIERVOLUME24HOUR { get; set; }

        [JsonProperty("TOPTIERVOLUME24HOURTO")]
        public double TOPTIERVOLUME24HOURTO { get; set; }

        [JsonProperty("CHANGE24HOUR")]
        public double CHANGE24HOUR { get; set; }

        [JsonProperty("CHANGEPCT24HOUR")]
        public double CHANGEPCT24HOUR { get; set; }

        [JsonProperty("CHANGEDAY")]
        public double CHANGEDAY { get; set; }

        [JsonProperty("CHANGEPCTDAY")]
        public double CHANGEPCTDAY { get; set; }

        [JsonProperty("CHANGEHOUR")]
        public double CHANGEHOUR { get; set; }

        [JsonProperty("CHANGEPCTHOUR")]
        public double CHANGEPCTHOUR { get; set; }

        [JsonProperty("CONVERSIONTYPE")]
        public string CONVERSIONTYPE { get; set; }

        [JsonProperty("CONVERSIONSYMBOL")]
        public string CONVERSIONSYMBOL { get; set; }

        [JsonProperty("SUPPLY")]
        public double SUPPLY { get; set; }

        [JsonProperty("MKTCAP")]
        public double MKTCAP { get; set; }

        [JsonProperty("MKTCAPPENALTY")]
        public int MKTCAPPENALTY { get; set; }

        [JsonProperty("TOTALVOLUME24H")]
        public double TOTALVOLUME24H { get; set; }

        [JsonProperty("TOTALVOLUME24HTO")]
        public double TOTALVOLUME24HTO { get; set; }

        [JsonProperty("TOTALTOPTIERVOLUME24H")]
        public double TOTALTOPTIERVOLUME24H { get; set; }

        [JsonProperty("TOTALTOPTIERVOLUME24HTO")]
        public double TOTALTOPTIERVOLUME24HTO { get; set; }

        [JsonProperty("IMAGEURL")]
        public string IMAGEURL { get; set; }
    }


}
