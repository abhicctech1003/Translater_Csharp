using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stltoobj
{
    internal class StlToObj
    {
        // Triangulation 
        public void Writer(Triangulation triangulation)
        {
            using (StreamWriter outFile = new StreamWriter("E:\\Abhishek\\08-C#\\Translater_Csharp\\01-StlToObj\\stltoobj\\output\\cube.obj"))
            {
                List<Point3D> points = triangulation.UniquePoints;
                List<Point3D> normal = triangulation.UniqueNormals;
                List<Triangle> triangles = triangulation.Triangles;

                foreach (Point3D point in points)
                {
                    outFile.WriteLine($"v {point.X} {point.Y} {point.Z}");
                }

                foreach (Point3D norm in normal)
                {
                    outFile.WriteLine($"vn {norm.X} {norm.Y} {norm.Z}");
                }

                foreach (Triangle triangle in triangles)
                {
                    outFile.WriteLine($"f {triangle.V1}//{triangle.N + 1} {triangle.V2}//{triangle.N + 1} {triangle.V3}//{triangle.N + 1}");
                }
            }
        }
    }
}
