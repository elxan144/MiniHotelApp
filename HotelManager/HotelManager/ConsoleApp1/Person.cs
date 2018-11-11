using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Person
	{
		public string name { get; set; }
		public int ID { get; set; }
		public string TurAgenti { get; set;}

		public Person(string _name,int _id ,string _TurAgenti)
		{
			name = _name;
			ID = _id;
			TurAgenti = _TurAgenti;
		}
	}
}
