using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek
{
    public class CoinOdeme:IOdemeTipi
    {
        public string OdemeYap(double tutar)
        {
            return "Coin Odeme ile " + tutar + " ödeme yapıldı";
        }
    }
}
