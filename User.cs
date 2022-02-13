using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor2_4
{
	internal class User
	{
		string login;
		string name;
		string lastName;
		int age;

		public User(string login, string name, string lastName, int age)
		{
			this.login = login;
			this.name = name;
			this.lastName = lastName;
			this.age = age;

		}
		public void Deconstruct(out string uLogin, out string uName, out string uLastName, out int uAge)
		{
			uLogin = login;
			uName = name;
			uLastName = lastName;
			uAge = age;
		}
	}
}
