using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Casse
{
    public class Cassa
    {
        private static int totBiglietti;
        private int bigliettiVenduti;
        public static int TotBiglietti
        {
            get { return totBiglietti; }
            set
            {
                totBiglietti = value;
            }
        }
        public int BigliettiVenduti
        {
            get { return bigliettiVenduti; }
            set
            {
                bigliettiVenduti = value;
            }
        }
        public Cassa()
        {
            BigliettiVenduti = 0;
        }
        public void VendiBiglietto()
        {
            if (BigliettiVenduti + 1 > 100 || TotBiglietti + 1 > 250)
            {
                throw new ArgumentException("Biglietti esauriti");
            }
            BigliettiVenduti += 1;
            TotBiglietti += 1;
        }
        public void VendiBiglietto(int n)
        {
            if (BigliettiVenduti + n > 100 || TotBiglietti + n > 250)
            {
                throw new ArgumentException("Biglietti esauriti");
            }
            BigliettiVenduti += n;
            TotBiglietti += n;
        }
        public void AnnullaBiglietto()
        {
            if (BigliettiVenduti - 1 < 0 || TotBiglietti - 1 < 0)
            {
                throw new ArgumentException("Nessun biglietto venduto, impossibile annullare");
            }                
            BigliettiVenduti -= 1;
            TotBiglietti -= 1;
        }
        public void AnnullaBiglietto(int n)
        {
            if (BigliettiVenduti - n < 0 || TotBiglietti - n < 0)
            {
                throw new ArgumentException("Nessun biglietto venduto, impossibile annullare");
            }
            BigliettiVenduti -= n;
            TotBiglietti -= n;
        }
        public int GetBigliettiVenduti()
        {
            return bigliettiVenduti;
        }
        public int GetBigliettiTot()
        {
            return TotBiglietti;
        }
    }
}
