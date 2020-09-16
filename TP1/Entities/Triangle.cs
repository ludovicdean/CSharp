using System;

namespace TP1
{
    public class Triangle : Forme
    {
        private double a;
        private double b;
        private double c;
        private double perimetre;
        private double aire;

        public override double Aire
        {
            get { return aire; }
            set { aire = Math.Sqrt(perimetre / 2 *(perimetre / 2 - a) * (perimetre / 2 - b) * (perimetre / 2 - c)); }
        }


        public override double Perimetre
        {
            get { return perimetre; }
            set { perimetre = a + b + c; }
        }


        public double C
        {
            get { return c; }
            set { c = value; }
        }


        public double B
        {
            get { return b; }
            set { b = value; }
        }


        public double A
        {
            get { return a; }
            set { a = value; }
        }

    }
}