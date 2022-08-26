using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle c = new Circle(50);
            Console.WriteLine($"the area of circle is{c.getArea()}"); ;
        }
    }
}
