using System;

namespace TP1
{
    public class Cercle : Forme
    {
        private int rayon;
        private double perimetre;
        private double aire;

        public int Rayon { get; set; }

        public override double Perimetre
        {
            get { return perimetre; }
            set { perimetre = Math.PI * 2 * rayon; }
        }
                     
        public override double Aire
        {
            get { return aire; }
            set { aire = Math.PI * rayon * rayon; }
        }

        public Cercle(int rayon)
        {
            this.rayon = rayon;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}