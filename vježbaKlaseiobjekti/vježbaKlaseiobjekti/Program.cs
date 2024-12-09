using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbaKlaseiobjekti
{
    class Zrakoplov
    {
        string marka;
        string brojSasije;
        int snaga;
        int godinaProizvodnje;

        public string BrojSasije { get => brojSasije; set => brojSasije = value; }
        public int Snaga { get => snaga; set => snaga = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }

        public void setMarka(string marka)
        {

            this.marka = marka;
        }
        public string getMarka()
        {
            return this.marka;
        }
        public Zrakoplov()
        {

        }
        public Zrakoplov(string marka, string brojSasije, int snaga, int godinaProizvodnje)
        
        {
            this.snaga = snaga;
            this.marka = marka;
            this.godinaProizvodnje = godinaProizvodnje;
            this.BrojSasije = brojSasije;


        }

        public override string ToString()
        {
            string ispis = "Marka:" + this.marka + "\n Broj Šasije:" + this.brojSasije + "\n Snaga:" + this.snaga + "\n KS:" + "\n Godina proivodnje:" + this.godinaProizvodnje;
        }
    }
    
}
