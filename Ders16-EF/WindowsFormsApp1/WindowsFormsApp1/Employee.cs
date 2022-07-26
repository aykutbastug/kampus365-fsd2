using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Company { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
