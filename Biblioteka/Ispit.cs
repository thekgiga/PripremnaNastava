using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Ispit
    {
        public enum ispitniRok{januar, februar, jun, jul, septembar, oktobar} //jebeni enum mora da bude public

        Predmet predmet;
        int ocena;
        ispitniRok rok;
        DateTime datum;
        
        

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

        public ispitniRok Rok
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

        public Predmet Predmet
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
    }
}
