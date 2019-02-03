namespace vjezba2
{
    public class Kvadrat : GeometrijskiLikovi
    {
        
        public Kvadrat(double A)
        {
            this.A = A;
        }
        private double IzracunajOpseg()
        {
            double opseg = 4 * A;
            return opseg;
        }
        private double IzracunajPovrsinu()
        {
            double povrsina = A * A;
            return povrsina;
        }
        public override double opseg()
        {
            return IzracunajOpseg();
        }

        public override double povrsina()
        {
            return IzracunajPovrsinu();
        }
        public override string ToString()
        {
            return "Kvadrat povrsine: " + povrsina() + " opsega: " + opseg();
        }
    }
}