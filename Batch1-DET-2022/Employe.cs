using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Employe
    {
        //data declared inside class are known as "fields"
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;

        public static int Empno { get; internal set; }
        public static string Ename { get; internal set; }
        public static int ESal { get; internal set; }
        public static int Deptno { get; internal set; }
        public static string EJob { get; internal set; }

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Employe(int id, string name, DateOnly doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public Employe()
        {
            id = -1; name = "no name";
        }
        public Employe(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }


    }
}
