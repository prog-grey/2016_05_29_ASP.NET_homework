using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2016_05_29_homework.Models
{
	public class User
	{
		private string login;
		private string email;
		private string phone;
		private string address;
		private bool active;

		public string Login { get { return login; } }
		public string Email { get { return email; } }
		public string Phone { get { return phone; } }
		public string Address { get { return address; } }
		public bool Active { get { return active; } set { active = value; } }

		public User() { }

		public User(string login, string email, string phone, string address, bool active)
		{
			this.login = login;
			this.email = email;
			this.phone = phone;
			this.address = address;
			this.active = active;
		}
		public string info()
		{
			return this.login + " " + this.email + " " + this.phone + " " + this.address + " " + this.active;
		}
	}

	public class UserModel {
		private List<User> userList;

		public UserModel() {
			userList = new List<User>();
			userList.Add(new User("grey", "prog.grey@gmail.com", "066 77 00 265", "Poltava", false));
			userList.Add(new User("user_1", "user_1@mail.ru", "050 123 45 67", "Lvov", true));
			userList.Add(new User("user_2", "user_2@ukr.net", "095 987 65 43", "Dnepr", false));
			userList.Add(new User("user_3", "user_3@.ex.ua", "067 893 48 36", "Odessa", true));
			userList.Add(new User("user_4", "user_4@.yandex.ru", "123 456 78 90", "Horishni Plavni", true));
		}

		public List<User> getUserList() {
			return this.userList;
		}

	}
}