using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolingTutorial
{
    class Factory
    {
        //Maximum objects allowed!
        private static int _PoolMaxSize = 2;
        //My Collection Pool
        private static readonly Queue objPool = new Queue(_PoolMaxSize);

        public Employee GetEmployee()
        {
            Employee oEmployee;

            if(Employee.Counter >= _PoolMaxSize && objPool.Count > 0)
            {
                //Retrieve from pool
                oEmployee = RetrieveFromPool();
            }
            else
            {
                oEmployee = GetNewEmployee();
            }
            return oEmployee;
        }

        private Employee GetNewEmployee()
        {
            //Creates new employee
            Employee oEmp = new Employee();
            objPool.Enqueue(oEmp);
            return oEmp;
        }

        protected Employee RetrieveFromPool()
        {
            Employee oEmp;
            //if there is any objects in my collection
            if(objPool.Count > 0)
            {
                oEmp = (Employee)objPool.Dequeue();
                Employee.Counter--;
            }
            else
            {
                //return a new object
                oEmp = new Employee();
            }
            return oEmp;
        }

    }
}
