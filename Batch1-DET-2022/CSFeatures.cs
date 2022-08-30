using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"hai {name}"); };

            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"hai {s1}" + $"you said {s2}"); };
            Action<string, int, string> printemp = (string name, int id, string email) => { Console.WriteLine($"name={name} , id={id} , email{email}"); };

            action.Invoke("NITHYA");
            action1.Invoke("nithya", " am in bly");
            printemp("nithya", 5098, "s.nithya@sonata-software.com");


            //fun deligate
            Func<int, int, long> multiply = (x, y) =>
            {
                return x * y;
            };
            long result = multiply(100, 100);
            Console.WriteLine(result);
        }

        
    }
}
    