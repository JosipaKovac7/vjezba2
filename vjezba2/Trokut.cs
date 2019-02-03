namespace vjezba2
{
    class Trokut : GeometrijskiLikovi
    {
        public Trokut(double A)
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
        public override double Opseg()
        {
            return IzracunajOpseg();
        }

        public override double Povrsina()
        {
            return IzracunajPovrsinu();
        }
        public override string ToString()
        {
            return "Trokut povrsine: " + Povrsina() + " opsega: " + Opseg();
        }
    }
}