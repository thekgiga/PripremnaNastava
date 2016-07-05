using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        static void Main(string[] args)
        {
        }
    }
}
