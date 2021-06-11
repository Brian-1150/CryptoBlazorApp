using Crypto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Data.Interfaces
{
   public interface ICryptoApiService
    {
        Task<CryptoCoinModel> GetCryptoCoins(string symbol, double amount);
    }
}
