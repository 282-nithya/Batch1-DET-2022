using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class EmployeDetails
    {
        int id;
        string name;
        string address;
        int pin;
        int phone;
        float gsalary;
        int pf;
        public EmployeDetails(int id, string name, string address, int pin, int phone, float gsalary, int pf)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.pin = pin;
            this.phone = phone;
            this.gsalary = gsalary;
            this.pf = pf;
        }

        public float getnetsalary()
        {
            return (gsalary - pf);
        }
        public string getgrade()
        {
            float net = getnetsalary();
            if (net > 10000)
            {
                return "A";
            }
            else if (net > 5000 && net < 5000)
            {
                return "c";
            }
            else
            {
                return "c";
            }
        }
    }
}
