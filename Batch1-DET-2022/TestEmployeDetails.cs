using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmployeDetails
    {
        public static void Main()
        {
            EmployeDetails ceo = new EmployeDetails(1, "tony", "veatnam", 8056, 8967698, 77000, 7700);
            float Net = ceo.getnetsalary();
            string grade = ceo.getgrade();
            Console.WriteLine($"net salary ={Net},grade = {grade}");
        }
    }
}
