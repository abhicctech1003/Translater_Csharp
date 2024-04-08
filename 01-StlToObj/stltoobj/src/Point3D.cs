using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stltoobj
{
    internal class Point3D
    {
        private float mX;
        private float mY;
        private float mZ;

        public Point3D()
        {
            mX = 0.0f;
            mY = 0.0f;
            mZ = 0.0f;
        }

        public Point3D(float inX, float inY, float inZ)
        {
            mX = inX;
            mY = inY;
            mZ = inZ;
        }

        public float X
        {
            get { return mX; }
            set { mX = value; }
        }

        public float Y
        {
            get { return mY; }
            set { mY = value; }
        }

        public float Z
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
