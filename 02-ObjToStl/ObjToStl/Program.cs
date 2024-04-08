using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulation triangulation = new Triangulation();
            ObjReader reader = new ObjReader();
            reader.ReadObj(triangulation);

            // Instantiate ObjtoStl object and write triangulation data to STL file
            ObjtoStl obj = new ObjtoStl();
            obj.Writer(triangulation);

            Console.WriteLine("Conversion completed successfully.");
        }
    }
}
