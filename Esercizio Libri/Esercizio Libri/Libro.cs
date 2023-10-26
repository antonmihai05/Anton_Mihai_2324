using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Libri
{
    internal class Libro
    {
        private string titolo;
        private string autore;
        private int numeroPagine;
        private string genere;
        private bool raccolta;
        private float costo;
         

        
        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }
        public int NumeroPagine
        {
            get { return numeroPagine; }
            set { numeroPagine = value; }
        }
        public string Genere
        {
            get { return genere; }
            set { genere = value; }
        }
        public Libro(string t, string a, int np, string g, bool r)
        {
            Titolo = t;
            Autore = a;
            NumeroPagine = np;
            Genere = g;
            raccolta = r;
        }
        public float costoLibro()
        {
            costo = NumeroPagine * 0.01F;
            if(numeroPagine<=100)
            {
                return costo;
            }
            else if(numeroPagine>100 && numeroPagine<=200)
            {
                costo += costo *0.01F;
                
            }
            else if(numeroPagine>200&&numeroPagine<=500)
            {
                costo += costo * 0.03F;
            }
            if (numeroPagine > 500)
            {
                costo += costo * 0.05F;
                
            }
            return costo;
        }
        public override string ToString()
        {
            return $"{Titolo} - {Autore} - {Genere} - {NumeroPagine} - {raccolta}";  
        }
    }
}
