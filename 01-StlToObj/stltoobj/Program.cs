using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stltoobj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StlReader stlReader = new StlReader();
            Triangulation triangulation = new Triangulation();

            // Reading the triangulation data from a STL file
            stlReader.ReadFile1(triangulation);

            StlToObj obj = new StlToObj();
            obj.Writer(triangulation);

            Console.WriteLine("Conversion completed successfully.");
        }
    }
}
