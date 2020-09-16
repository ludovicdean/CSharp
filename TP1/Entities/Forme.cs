namespace TP1
{
    public abstract class Forme
    {
        private double perimetre;
        private double aire;

        public virtual double Perimetre { get => perimetre; set => perimetre = value; }
        public virtual double Aire { get => aire; set => aire = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}