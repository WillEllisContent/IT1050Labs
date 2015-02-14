using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Person
    {
        public string firstname;
        public string lastname;
        public string fullname()
        {
            string fName = this.firstname;
            string lName = this.lastname;
            return fName + " " + lName;
        }
    }
}
