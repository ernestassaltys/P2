using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plyta
{
    class Plyta
    {
        private int ilgis,
                    plotis,
                    aukstis;
        public Plyta(int ilgis, int plocioReiksme, int aukscioReiksme)
        {
            this.ilgis = ilgis;
            plotis = plocioReiksme;
            aukstis = aukscioReiksme;
        }
        public int ImtiIlgi() { return ilgis; }
        public int ImtiPloti() { return plotis; }
        public int ImtiAuksti() { return aukstis; }
    }
    class Siena
    {
        private double   ilgis,
                         aukstis;
        public Siena(double ilgis, double aukscioReiksme)
        {
            this.ilgis = ilgis;
            aukstis = aukscioReiksme;
        }
        public double ImtiIlgi() { return ilgis; }
        public double ImtiAuksti() { return aukstis; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int k1;
            int k2;
            int k3;
            int k4;
            int kTotal;

            int K1;
            int K2;
            int K3;
            int K4;
            int KTotal;

            Plyta p1;
            Plyta p2;
            Siena s1;
            Siena s2;
            Siena s3;
            Siena s4;

            Console.WriteLine("Iveskite pirmos plytos ilgi, ploti ir auksti (mm)");
            p1 = new Plyta(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Iveskite antros plytos ilgi, ploti ir auksti (mm)");
            p2 = new Plyta(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Iveskite pirmos sienos ilgi ir auksti (m)");
            s1 = new Siena(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Iveskite antros sienos ilgi ir auksti (m)");
            s2 = new Siena(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Iveskite trecios sienos ilgi ir auksti (m)");
            s3 = new Siena(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Iveskite ketvirtos sienos ilgi ir auksti (m)");
            s4 = new Siena(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            k1 = VienaSiena(p1, s1.ImtiIlgi(), s1.ImtiAuksti());
            k2 = VienaSiena(p1, s2.ImtiIlgi(), s2.ImtiAuksti());
            k3 = VienaSiena(p1, s3.ImtiIlgi(), s3.ImtiAuksti());
            k4 = VienaSiena(p1, s4.ImtiIlgi(), s4.ImtiAuksti());
            kTotal = k1 + k2 + k3 + k4;

            K1 = VienaSiena(p2, s1.ImtiIlgi(), s1.ImtiAuksti());
            K2 = VienaSiena(p2, s2.ImtiIlgi(), s2.ImtiAuksti());
            K3 = VienaSiena(p2, s3.ImtiIlgi(), s3.ImtiAuksti());
            K4 = VienaSiena(p2, s4.ImtiIlgi(), s4.ImtiAuksti());
            KTotal = K1 + K2 + K3 + K4;

            Console.WriteLine("1-o tipo plytu reikia: ");
            Console.WriteLine("1-ai sienai: {0, 6:d}", k1);
            Console.WriteLine("2-ai sienai: {0, 6:d}", k2);
            Console.WriteLine("3-ai sienai: {0, 6:d}", k3);
            Console.WriteLine("4-ai sienai: {0, 6:d} \n", k4);
            Console.WriteLine("Is viso: {0, 6:d} \n", kTotal);

            Console.WriteLine("2-o tipo plytu reikia: ");
            Console.WriteLine("1-ai sienai: {0, 6:d}", K1);
            Console.WriteLine("2-ai sienai: {0, 6:d}", K2);
            Console.WriteLine("3-ai sienai: {0, 6:d}", K3);
            Console.WriteLine("4-ai sienai: {0, 6:d} \n", K4);
            Console.WriteLine("Is viso: {0, 6:d} \n", KTotal);
            Console.WriteLine("Programa baige darba.");
        }
        static int VienaSiena(Plyta p, double sienosIlgis, double sienosAukstis)
        {
            int result = (int)(sienosIlgis * 1000 / p.ImtiIlgi() * sienosAukstis * 1000 / p.ImtiAuksti());
            if (sienosIlgis * 1000 % p.ImtiIlgi() > 0 || sienosAukstis * 1000 % p.ImtiAuksti() > 0)
                result++;

            return result; 
        }
        
    }
}
