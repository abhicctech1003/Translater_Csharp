using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl
{
    internal class Triangle
    {
        private int mV1;
        private int mV2;
        private int mV3;
        private int mNormal;

        public Triangle()
        {
        }

        public Triangle(int inV1, int inV2, int inV3, int inNormal)
        {
            mV1 = inV1;
            mV2 = inV2;
            mV3 = inV3;
            mNormal = inNormal;
        }

        public int V1
        {
            get { return mV1; }
            set { mV1 = value; }
        }

        public int V2
        {
            get { return mV2; }
            set { mV2 = value; }
        }

        public int V3
        {
            get { return mV3; }
            set { mV3 = value; }
        }

        public int TriangleNormal
        {
            get { return mNormal; }
        }
    }
}
