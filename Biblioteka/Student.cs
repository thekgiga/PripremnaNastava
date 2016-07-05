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
        string brIndeksa;
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
    }
}
