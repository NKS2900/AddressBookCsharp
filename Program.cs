using System;
using System.Collections.Generic;
namespace AddressBookApp
{
    class Program
    {
        public static LinkedList<UserInfo> userList = new LinkedList<UserInfo>();

		public static void Main(string[] args)
		{
			Console.WriteLine("******WELCOME TO ADDRESS BOOK******");
			addUser();			
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
            Console.WriteLine("Details Added Successfully. \n");
        }
    }
}
