using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GOood
{
    internal class Class2{
        int go;
        string name;
        string age;
        string phone;
        public  Class2()
    {
        
    }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetAge(string age)
        {
            this.age = age;
        }
        public string GetAge()
        {
            return this.age;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public string GetPhone()
        {
            return this.phone;
        }

        public void goig(string sz)
        {
            this.go = this.go + int.Parse(sz);

        }

        public int getAllDistance()
        { return this.go; }

    }
}