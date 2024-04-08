using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stltoobj
{
    internal class Triangle
    {
        private int mV1;
        private int mV2;
        private int mV3;
        private int mNormal;
        private Point3D mPointP1;
        private Point3D mPointP2;
        private Point3D mPointP3;

        public Triangle()
        {
        }

        public Triangle(Point3D inP1, Point3D inP2, Point3D inP3)
        {
            mPointP1 = inP1;
            mPointP2 = inP2;
            mPointP3 = inP3;
        }

        public Triangle(int inV1, int inV2, int inV3, int inNormal)
        {
            mV1 = inV1;
            mV2 = inV2;
            mV3 = inV3;
            mNormal = inNormal;
        }

        public Point3D PointP1
        {
            get { return mPointP1; }
            set { mPointP1 = value; }
        }

        public Point3D PointP2
        {
            get { return mPointP2; }
            set { mPointP2 = value; }
        }

        public Point3D PointP3
        {
            get { return mPointP3; }
            set { mPointP3 = value; }
        }

        public int V1
        {
            get { return mV1; }
        }

        public int V2
        {
            get { return mV2; }
        }

        public int V3
        {
            get { return mV3; }
        }

        public int N
        {
            get { return mNormal; }
        }
    }
}
