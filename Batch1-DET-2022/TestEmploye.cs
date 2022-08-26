using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmploye
    {
        public static void Main()
        {
            Employe e = new Employe(5050, "mary", new DateOnly(2020, 8, 1));
            Console.WriteLine($"yeras of experience{e.GetYearsofExp()}"); ;
        }
    }
}
