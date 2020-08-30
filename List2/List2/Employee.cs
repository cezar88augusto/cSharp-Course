using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace List2 {
    class Employee {

        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public Employee(int id, string name, double salary) {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void increaeSalary(double percentage) {

            salary *= (1+(percentage/100));
        }

        public override string ToString() {
            return id
                + ", "
                + name
                + ", "
                + salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
