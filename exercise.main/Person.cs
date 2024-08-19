using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Person
    {
        public string position { get; set; } = "Customer";

        public Person(string position) { 
        this.position = position;
        }
    }
}
