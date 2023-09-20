﻿namespace GD.Examples.Classes
{
    public class Vector3
    {
        #region Variables

        private double x, y, z;

        #endregion Variables

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
    }
}