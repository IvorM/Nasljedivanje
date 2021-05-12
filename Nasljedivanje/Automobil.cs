using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    abstract class Automobil
    {
        public string Naziv { get; set; }

        public abstract string DohvatiNaziv();
    }
}
