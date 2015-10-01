using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart_W1D3
{
    class Employee
    {   
        //property
        public string Name { get; set; }
                        //field
        private Employee _supervisor;
        public Employee Supervisor
        {
            get
            {   //public Employee GetSupervisor
                return _supervisor;
            }
          set
            {   // public void SetSupervisor(Employee value)
                _supervisor = value;
                value.Minions.Add(this);
            }
        }
        public IList<Employee> Minions { get; set; }

        //list needs to be initialized by a CONSTRUCTOR
        public Employee(string name)
        {
            Name = name;
            Minions = new List<Employee>();
        }
        // step 1 ^

        public int ReportCount
        {
            get
            {
                return Minions.Count;
            }
        }       
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sam = new Employee("Sam");
            var jane = new Employee("Jane");
            var bill = new Employee("Bill");
            var fred = new Employee("Fred");
            var alice = new Employee("Alice");
            sam.Supervisor = bill;
            fred.Supervisor = bill;
            jane.Supervisor = bill;

            alice.Supervisor = fred;
            //step 1 ^

            Console.WriteLine("{0} has {1} minions", bill.Name, bill.ReportCount);
            Console.ReadLine();
        }
    }

}

