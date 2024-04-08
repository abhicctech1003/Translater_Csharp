using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl
{
    internal class Triangulation : ITriangulation
    {
        private List<Triangle> mTriangles = new List<Triangle>();
        private List<Point3D> mUniquePoints = new List<Point3D>();
        private List<Point3D> mUniqueNormals = new List<Point3D>();
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
