﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek
{
    public class MailOrder:IOdemeTipi
    {
        public string OdemeYap(double tutar)
        {
            return "Mail Order ile " + tutar + " ödeme yapıldı";
        }
    }
}
