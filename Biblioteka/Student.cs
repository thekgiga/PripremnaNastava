using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Student
    {
        string ime;
        string brIndeksa; // pocinje sa smerom
        List<Ispit> spisakIspita;



        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string BrIndeksa
        {
            get
            {
                return brIndeksa;
            }

            set
            {
                brIndeksa = value;
            }
        }

        public List<Ispit> SpisakIspita
        {
            get
            {
                return spisakIspita;
            }

            set
            {
                spisakIspita = value;
            }
        }

        public string drugaMetoda(Predmet p)
        {
            string pom = "";

            foreach (Ispit i in spisakIspita)
            {
                if(i.Predmet.Equals(p) && i.Ocena>5 && i.Ocena < 11)
                {
                    pom = "polozio";
                }
                else
                {
                    pom = "pao";
                }

            }


            return pom;
        }

        public int trecaMetoda(Predmet p)
        {
            int br = 0;

            foreach (Ispit i in spisakIspita)
            {
                if (i.Predmet.Equals(p))
                {
                    br++;
                }
            }

            return br;
        }
    }
}
