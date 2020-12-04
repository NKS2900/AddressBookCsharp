using System;
using System.Collections.Generic;
namespace AddressBookApp
{
	class Program
	{
		public static LinkedList<UserInfo> userList = new LinkedList<UserInfo>();
		public static void Main(string[] args)
		{
			bool flag = true;

			while (flag)
			{
				Console.WriteLine(" ");
				Console.WriteLine("******WELCOME TO ADDRESS BOOK******");
				Console.WriteLine("1. Add_Contact \n2. Display_Contact \n3. Exit");
				Console.WriteLine("Enter Your Choice:");
				int input = Convert.ToInt32(Console.ReadLine());

				switch (input)
				{

					case 1:
						addUser();
						Console.WriteLine("Details Added Successfully. \n");
						break;
					case 2:
						Display();
						break;
					case 3:
						flag = false;
						break;
					default:
						Console.WriteLine("Invalid option ???");
						break;
				}
			}
		}
		public static void addUser()
		{
			Console.WriteLine("Enter FirstName: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Enter LastName: ");
			string lastName = Console.ReadLine();
			Console.WriteLine("Enter Address : ");
			string address = Console.ReadLine();
			Console.WriteLine("Enter Contact No: ");
			string contact = Console.ReadLine();
			Console.WriteLine("Enter State : ");
			string state = Console.ReadLine();
			Console.WriteLine("Enter zip : ");
			string zip = Console.ReadLine();
			UserInfo user = new UserInfo(firstName, lastName, address, contact, state, zip);
			userList.AddFirst(user);
			user.print();
		}
		public static void Display()
		{
			Console.WriteLine("FirstName    LastName     City     State   Contact      Zip");
			foreach (var item in userList)
			{
				UserInfo p = item;
				p.print();				
			}
		}
	}
}
