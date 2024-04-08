using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl
{
    internal class ObjtoStl
    {
        public void Writer(Triangulation triangulation)
        {

            using (StreamWriter outFile = new StreamWriter("E:\\Abhishek\\08-C#\\Translater_Csharp\\02-ObjToStl\\ObjToStl\\STLFile\\cube.stl"))
            {
                if (outFile == null)
                {
                    Console.WriteLine("Error while opening the file.");
                    return;
                }

                List<Point3D> points = triangulation.UniquePoints;
                List<Triangle> triangles = triangulation.Triangles;
                List<Point3D> normals = triangulation.UniqueNormals;

                // Writing Obj to Stl in STL file Format
                outFile.WriteLine("solid exported ");

                foreach (Triangle triangle in triangles)
                {
                    outFile.WriteLine(" facet normal " + normals[triangle.TriangleNormal].X + " " + normals[triangle.TriangleNormal].Y + " " + normals[triangle.TriangleNormal].Z);
                    outFile.WriteLine("      outer loop");
                    outFile.WriteLine("         vertex " + points[triangle.V1].X + " " + points[triangle.V1].Y + " " + points[triangle.V1].Z);
                    outFile.WriteLine("         vertex " + points[triangle.V2].X + " " + points[triangle.V2].Y + " " + points[triangle.V2].Z);
                    outFile.WriteLine("         vertex " + points[triangle.V3].X + " " + points[triangle.V3].Y + " " + points[triangle.V3].Z);
                    outFile.WriteLine("      endloop");
                    outFile.WriteLine("     endfacet");
                }
                outFile.WriteLine("End ");
            }
        }
    }
}
