using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Ispit
    {
        enum ispitniRok{januar, februar, jun, jul, septembar, oktobar}

        string predmet;
        int ocena;
        ispitniRok rok;
        DateTime datum;
        
        public string Predmet
        {
            get
            {
                return predmet;
            }

            set
            {
                predmet = value;
            }
        }

        public int Ocena
        {
            get
            {
                return ocena;
            }

            set
            {
                ocena = value;
            }
        }

        private ispitniRok Rok
        {
            get
            {
                return rok;
            }

            set
            {
                rok = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }
    }
}
