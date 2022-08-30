using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int  Getprice(string Name);
    }
   
    class BMW : ICar
    {
        public int Getprice(string Name)
        {
            if (Name == "M3")
                return 1300000;
            else if (Name == "x7")
                return 9600000;
            else
                return 1000000;
        }
    }
    class Hyundai: ICar
    {
        public int Getprice(string Name)
        {
            if (Name == "kona")
                return 2400000;
            else if (Name == "alcazar")
                return 1500000;
            else
                return 700000;
        }
    }
    class TestICar
    {
        public static void Main()
        {
            Author a = new Author { Name = "mary", EMail = "mary.s", Gender = 'F' };
            SITLAuthor sa = new SITLAuthor { Name = "roja", EMail = "roja.p", Gender = 'F' };

            Console.WriteLine(a.SendEMail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEMail());
        }
    }
}
