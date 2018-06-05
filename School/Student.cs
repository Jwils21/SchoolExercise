using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Student : Person {
		//private static int nextID = 1;

		public bool IsVet { get; set; } = false;
		public int StudentId { get; set; }
		public double GPA { get; set; }
		public Instructor Instructor { get; set; }

		public Student(string Name, string email, string phone, bool isEmployee, bool isVet, double gpa, Instructor instructor) 
			: base(Name, email, phone, isEmployee = false) {
			IsVet = isVet;
			GPA = gpa;
			Instructor = instructor;
		}

		public Student() {

		}
			
	}
}
