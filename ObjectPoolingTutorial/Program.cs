using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Employee employee = factory.GetEmployee();
            Console.WriteLine("First object");

            Employee employee2 = factory.GetEmployee();
            Console.WriteLine("Second object");
        }
    }
}
