using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba2
{
    public class Kugla
    {

        double polumjer;


        public double DohvatiPolumjer()
        {
            return polumjer;
        }

        public void PostaviPolumjer(double polumjer)
        {
            if (polumjer < 0)
            {
                throw new ArgumentOutOfRangeException("Polumjer ne može biti manji od nule");
            }

            else
            {
                this.polumjer = polumjer;
            }
        }

        public double Polumjer
        {
            get
            {
                return polumjer;
            }
            set
            {
                polumjer = value;
            }
        }

        public Kugla(double polumjer)
        {
            this.polumjer = polumjer;
        }
        public double Volumen()
        {
            double volumen = 4 / 3 * Polumjer * 3.14;
            return volumen;
        }
        public double Oplošje()
        {
            double oplošje = 4 * (Polumjer * Polumjer) * 3.14;
            return oplošje;
        }

        public override string ToString()
        {
            return "Kugla polumjer: " + Polumjer + "\tVolumen: " + Volumen() + "\tOplošje: " + Oplošje();
        }
        public static void IspisiPodatke()
        {
            List<Kugla> kugle = new List<Kugla>();
            kugle.Add(new Kugla(1));
            kugle.Add(new Kugla(2));
            kugle.Add(new Kugla(3));
            kugle.Add(new Kugla(4));
            kugle.Add(new Kugla(5));
            kugle.ForEach(Console.WriteLine);
        }
    }
}
