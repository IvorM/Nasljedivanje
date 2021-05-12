using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime,string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public Osoba()
        {

        }

        public virtual string PredstaviSe()
        {
            return "Ja sam osoba";
        }
    }
}
