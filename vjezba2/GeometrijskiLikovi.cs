namespace vjezba2
{
    public abstract class GeometrijskiLikovi
    {
        public abstract double Opseg();
        public abstract double Povrsina();

        private double a;
        public double A
        {
            get{
                return a;
            }

            set {

                a = value;
            }
            
        }
    }
}