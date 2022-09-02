using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class linq
    {
        public static void Main()
        {
            // the three parts of linq queery: differed execution
            // 1.data source.
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2.query creation.sql  type

            // lamda exp
            //var numQuery = numbers.Select(x => x);
            ////var numQuery = from num in numbers
            //               select num;

            //early execution
            //var numQuery = (from num in numbers
            //                select num).ToList();


            // lamda exp
            var numQuery = numbers.Where(x => x > 102);

            // 3. query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0}", num);
                //num.Dump();//this is fot linqpad not for vs

            }
            Console.ReadLine();

        }
    }
}
