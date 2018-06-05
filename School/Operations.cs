using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Operations : Employee {

		public Operations(string name, string email, string phone, string jobTitle, decimal salary)
			: base(name, email, phone, jobTitle, salary) {
		}

		public Operations() {
		}
	}
}
