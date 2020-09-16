namespace TP1
{
    public class Rectangle : Forme
    {
        private double longueur;
        private double largeur;
        private double perimetre;
        private double aire;

        public double Largeur { get; set; }
        public double Longueur { get; set; }

        public override double Perimetre
        {
            get { return perimetre; }
            set { perimetre = 2*longueur + 2*largeur; }
        }


        public override double Aire
        {
            get { return aire; }
            set { aire = longueur * largeur; }
        }
    }
}