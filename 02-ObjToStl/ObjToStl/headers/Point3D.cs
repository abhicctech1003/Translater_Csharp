using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl
{
    internal class Point3D
    {
        private double mX;
        private double mY;
        private double mZ;

        public Point3D()
        {
            mX = 0.0;
            mY = 0.0;
            mZ = 0.0;
        }

        public Point3D(double inX, double inY, double inZ)
        {
            mX = inX;
            mY = inY;
            mZ = inZ;
        }

        public double X
        {
            get { return mX; }
            set { mX = value; }
        }

        public double Y
        {
            get { return mY; }
            set { mY = value; }
        }

        public double Z
        {
            get { return mZ; }
            set { mZ = value; }
        }

        public bool LessThan(Point3D other)
        {
            if (mX < other.mX)
                return true;
            if (mX > other.mX)
                return false;

            if (mY < other.mY)
                return true;
            if (mY > other.mY)
                return false;

            return mZ < other.mZ;
        }
    }
}
