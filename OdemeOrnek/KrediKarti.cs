﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek
{
    public class KrediKarti:IOdemeTipi
    {
        public string OdemeYap(double tutar)
        {
            return "Kredi kartı ile " + tutar + " ödeme yapıldı";
        }
    }
}
