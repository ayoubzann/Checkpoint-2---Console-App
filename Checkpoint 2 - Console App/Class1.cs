using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age 
        {
            get { return age; } 
            set { age = value; } 
        }
    }

    public class Employee : Person
    {
        public string hireDate;

        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
    }

    class Company
    {
        public string companyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
    }
}
