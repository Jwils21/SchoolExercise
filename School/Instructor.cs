using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Instructor : Employee {

		public string Technology { get; set; }
		public bool TeachBootCamps { get; set; } = false;

		public Instructor(string name, string email, string phone, string jobTitle, decimal salary, string technology) 
			: base(name,email,phone,jobTitle,salary) {
			Technology = technology;
		}

		public Instructor() {
		}
	}
}
