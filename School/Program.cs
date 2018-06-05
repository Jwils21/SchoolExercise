using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Program {
		static void Main(string[] args) {
			Instructor Greg = new Instructor("Greg", "greg@email.com", "702-654-3210", "BootCampInstr", 100000, "CSharp");
			Student Jonathan = new Student("Jonathan", "jon@email.com", "702-555-5555", false, false, 4.0, Greg);
			Student Jerry = new Student("Jerry", "Jerry@email.com", "555-555-6666", false, true, 3.6, Greg);
			Sales Sam = new Sales("Sam", "sam@email.com", "123-456-7890", "Sales Director", 150000, "East", 1500000);
			Sam.TotalSales = 23000;
			Operations Bartholomew = new Operations("Bartholomew", "bt@email.com", "321-789-6540", "Payroll Manager", 40000);

			List<Person> People = new List<Person>();
			People.Add(Greg);
			People.Add(Jonathan);
			People.Add(Jerry);
			People.Add(Sam);
			People.Add(Bartholomew);

			decimal totalSales = 0;
			foreach( Person person in People) {
				Sales sales = person as Sales;
				if(sales != null) {
					totalSales += sales.TotalSales;
					Console.WriteLine($"Total sales is {totalSales}");
				}

				

			}
		}
	}
}
