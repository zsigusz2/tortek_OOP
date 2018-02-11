using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortek
{
    class Tortek
    {
        //Bal oldali tört
        private int szamlalo1;
        private int nevezo1;

        //Jobb oldali tört
        private int szamlalo2;
        private int nevezo2;

        //Propertyk
        public int Szamlalo1
        {
            get { return szamlalo1; }
            set { szamlalo1 = value; }
        }

        public int Nevezo1
        {
            get { return nevezo1; }

            set
            {
                if (value == 0)
                {
                    nevezo1 = 1;
                }
                else
                {
                    nevezo1 = value;
                }
            }
        }

        public int Szamlalo2
        {
            get { return szamlalo2; }
            set { szamlalo2 = value; }
        }

        public int Nevezo2
        {
            get { return nevezo2; }

            set
            {
                if (value == 0)
                {
                    nevezo2 = 1;
                }
                else
                {
                    nevezo2 = value;
                }
            }
        }

        //Konstruktor
        public Tortek(int s1, int n1, int s2, int n2)
        {
            Szamlalo1 = s1;
            Nevezo1 = n1;
            Szamlalo2 = s2;
            Nevezo2 = n2;
        }

        //Összeadás függvény:
        public double Osszeadas()
        {
            double kozosnevezo;

            if (nevezo1==nevezo2)
            {
                kozosnevezo = nevezo1;
            }
            else
            {
                kozosnevezo = nevezo1 * nevezo2;
            }

            double sz1db = kozosnevezo / nevezo1;
            double sz2db = kozosnevezo / nevezo2;
            szamlalo1 = (int)(szamlalo1 * sz1db);
            szamlalo2 = (int)(szamlalo2 * sz2db);

            double eredmeny = (szamlalo1 + szamlalo2) / kozosnevezo;
            return eredmeny;
        }

        //Kivonás függvény:
        public double Kivonas()
        {
            double kozosnevezo;

            if (nevezo1 == nevezo2)
            {
                kozosnevezo = nevezo1;
            }
            else
            {
                kozosnevezo = nevezo1 * nevezo2;
            }

            double sz1db = kozosnevezo / nevezo1;
            double sz2db = kozosnevezo / nevezo2;
            szamlalo1 = (int)(szamlalo1 * sz1db);
            szamlalo2 = (int)(szamlalo2 * sz2db);

            double eredmeny = (szamlalo1 - szamlalo2) / kozosnevezo;
            return eredmeny;
        }

        //Szorzás függvény:
        public double Szorzas()
        {
            double SZeredmeny = szamlalo1 * szamlalo2;
            double Neredmeny = nevezo1 * nevezo2;
            double eredmeny = SZeredmeny / Neredmeny;
            return eredmeny;
        }

        //Osztás függvény:
        public double Osztas()
        {
            double SZeredmeny = szamlalo1 * nevezo2;
            double Neredmeny = nevezo1 * szamlalo2;
            double eredmeny = SZeredmeny / Neredmeny;
            return eredmeny;
        }
    }
}
