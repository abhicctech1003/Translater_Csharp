using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl 
{
    internal interface ITriangulation
    {
        List<Triangle> Triangles { get; }
        List<Point3D> UniquePoints { get; }
        List<Point3D> UniqueNormals { get; }
    }
}
