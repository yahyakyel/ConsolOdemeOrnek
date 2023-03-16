using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek
{
    public class OdemeIslemi
    {
        public IOdemeTipi odemeTipi;

        public OdemeIslemi(IOdemeTipi iOdemeTipi)
        {
            this.odemeTipi = iOdemeTipi;
        }
        public string Ode(double tutar)
        {
            return odemeTipi.OdemeYap(tutar);
        }
    }
}
