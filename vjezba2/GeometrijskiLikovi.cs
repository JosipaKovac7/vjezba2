namespace vjezba2
{
    abstract class GeometrijskiLikovi
    {
        public abstract double opseg();
        public abstract double povrsina();

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