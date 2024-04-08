using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stltoobj
{
    internal class Triangulation
    {
        private List<Triangle> mTriangles;
        private List<Point3D> mUniquePoints;
        private List<Point3D> mUniqueNormals;

        public Triangulation()
        {
            mTriangles = new List<Triangle>();
            mUniquePoints = new List<Point3D>();
            mUniqueNormals = new List<Point3D>();
        }

        public List<Triangle> Triangles
        {
            get { return mTriangles; }
        }

        public List<Point3D> UniquePoints
        {
            get { return mUniquePoints; }
        }

        public List<Point3D> UniqueNormals
        {
            get { return mUniqueNormals; }
        }

    }
}
