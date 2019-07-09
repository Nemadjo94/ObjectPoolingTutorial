using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolingTutorial
{
    class Employee
    {
        private string _Firstname;
        public static int Counter = 0;

        public Employee()
        {
            ++Counter;
        }

        public string Firstname
        {
            get
            {
                return _Firstname;
            }
            set
            {
                _Firstname = value;
            }
        }
    }
}
