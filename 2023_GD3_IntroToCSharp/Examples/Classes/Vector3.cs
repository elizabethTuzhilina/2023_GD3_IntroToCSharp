namespace GD
{
    public class Vector3
    {
        #region Variables

        private double x, y, z;

        #endregion Variables

        #region Properties

        public double X
        {
            get { return x; }
            set
            {
                //ternary operator
                x = value < 0 ? 0 : value;
            }
        }

        public double Y
        {
            //classes with getter only properties - IMMUTABLE
            get { return y; }
        }

        #endregion Properties

        #region Constructors

        //public Vector3()
        //{
        //    this.x = 0; this.y = 0; this.z = 0;
        //}
        public Vector3() : this(0, 0, 0)
        {
        }

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion Constructors

        /*
         * Add ToString, GetHashCode, Equals, Clone, GetShallowCopy, operator overloading
         */

        public override string ToString()
        {
            return $"({x},{y},{z}])";
        }

        public override bool Equals(object obj)
        {
            return obj is Vector3 vector &&
                   x == vector.X &&
                   y == vector.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = 373119288;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + z.GetHashCode();
            return hashCode;
        }

        //public override bool Equals(object obj)
        //{
        //    Vector3 other = obj as Vector3;

        //    if (other == null)
        //        new ArgumentException("obj is not a Vector3!");

        //    return x == other.X &&
        //           y == other.Y;
        //}
    }
}