using System;
using System.Collections.Generic;

namespace Nasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivor","Maric",1);
            Student student2 = new Student("Ivor", "Maric", 1);
            Osoba o = new Osoba();
            Console.WriteLine(o.PredstaviSe());
            Console.WriteLine(student.PredstaviSe());
            Console.WriteLine(MathHelper.PI());
            Audi a = new Audi();
            Console.WriteLine(student.GetBrojIstanci());
            //Profesor profesor = new Profesor();

            //List<Osoba> osobe = new List<Osoba>();
            //osobe.Add(student);
            //osobe.Add(profesor);

            //List<Student> studenti = new List<Student>();
            //studenti.Add(student);

           
      

           

        }
    }
}
