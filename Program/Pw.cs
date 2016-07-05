using System;
using System.Collections.Generic;
using Biblioteka;

namespace Program
{
    class Pw
    {
        List<Student> spisakStudenata = new List<Student>();

        public List<Student> prvaMetoda(string smer)
        {
            List<Student> lista = new List<Student>();
            foreach (Student s in spisakStudenata)
            {
                if (s.BrIndeksa.StartsWith(smer))
                {
                    lista.Add(s);
                }
            }

            return lista;

        }

        public List<Ispit> cetvrtaMetoda(DateTime datum)
        {
            List<Ispit> polozeni = new List<Ispit>();
            foreach (Student s in spisakStudenata)
            {
                foreach (Ispit i in s.SpisakIspita)
                {
                    if (i.Datum.CompareTo(datum) < 0 )
                    {
                        polozeni.Add(i);
                    }
                }
            }

            return polozeni;

        }

        public List<Ispit> petaMetoda(Ispit.ispitniRok ispitniRokic)
        {
            List<Ispit> spisak =new List<Ispit>();

            foreach (Student s in spisakStudenata)
            {
                foreach (Ispit i in s.SpisakIspita)
                {
                    if (i.Rok.Equals(ispitniRokic))
                    {
                        if (!spisak.Contains(i))
                        {
                            spisak.Add(i);
                        }
                    }
                }
            }

            return spisak;

        }



        static void Main(string[] args)
        {
        }
    }
}
