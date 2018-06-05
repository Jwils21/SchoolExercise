using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	abstract class Employee : Person {

		public int EmployeeId { get; set; }
		public Decimal Salary { get; private set; }
		public string JobTitle { get; set; }

		public void SetSalary(decimal NewSalary) {
			if(NewSalary <= 0) { 
				throw new ApplicationException("Salary must be postive");
			}
			Salary = NewSalary;
		}

		public Employee() { }

		public Employee(string name, string email, string phone, string jobTitle, decimal salary)
		: base(name, email, phone, true) {
			JobTitle = jobTitle;
			SetSalary(salary);
		}

	}
}
