using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl
{
    internal class ObjReader
    {
        public ObjReader()
        {
        }

        public void ReadObj(Triangulation triangulation)
        {
            using (StreamReader inputfile = new StreamReader("E:\\Abhishek\\08-C#\\Translater_Csharp\\02-ObjToStl\\ObjToStl\\resources\\cube.obj"))
            {
                string line;

                while ((line = inputfile.ReadLine()) != null)
                {
                    // checking for "v" in line string
                    if (line.Contains("v"))
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length >= 4 && parts[0] == "v")
                        {
                            double x = Convert.ToDouble(parts[1]);
                            double y = Convert.ToDouble(parts[2]);
                            double z = Convert.ToDouble(parts[3]);

                            Point3D P1 = new Point3D(x, y, z);
                            triangulation.UniquePoints.Add(P1);
                        }
                    }

                    // checking for "vn" in line string
                    if (line.Contains("vn"))
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length >= 4 && parts[0] == "vn")
                        {
                            double x = Convert.ToDouble(parts[1]);
                            double y = Convert.ToDouble(parts[2]);
                            double z = Convert.ToDouble(parts[3]);

                            Point3D Vn = new Point3D(x, y, z);
                            triangulation.UniqueNormals.Add(Vn);
                        }
                    }

                    // checking for "f" in line string
                    if (line.Contains("f"))
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length >= 4 && parts[0] == "f")
                        {
                            string[] v1Parts = parts[1].Split('/');
                            string[] v2Parts = parts[2].Split('/');
                            string[] v3Parts = parts[3].Split('/');

                            int v1 = Convert.ToInt32(v1Parts[0]) - 1;
                            int v2 = Convert.ToInt32(v2Parts[0]) - 1;
                            int v3 = Convert.ToInt32(v3Parts[0]) - 1;

                            int vn1 = Convert.ToInt32(v1Parts[2]) - 1;

                            Triangle T2 = new Triangle(v1, v2, v3, vn1);
                            triangulation.Triangles.Add(T2);
                        }
                    }
                }
            }
        }
    }
}
