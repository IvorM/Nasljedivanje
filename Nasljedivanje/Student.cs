using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    class Student:Osoba
    {
        private static int BrojIstanci = 0;
        public int GodinaStudija { get; set; }

        public Student(string ime,string prezime,int godinaStudija)
            :base(ime,prezime)
        {
            GodinaStudija = godinaStudija;
            BrojIstanci++;
        }

        public int GetBrojIstanci()
        {
            return BrojIstanci;
        }

        public override string PredstaviSe()
        {
            return "Ja sam Student";
        }
    }
}
