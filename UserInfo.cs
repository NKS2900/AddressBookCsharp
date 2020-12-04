using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
	public class UserInfo
	{		
		String firstName;
		String lastName;
		String address;
		String contact;
		String state;
		String zip;

		public UserInfo(String firstName, String lastName, String address, String contact, String state, String zip)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.address = address;
			this.contact = contact;
			this.state = state;
			this.zip = zip;
		}
		public void print()
		{

			Console.WriteLine(firstName + " \t  " + lastName +" \t  " + address + " \t  " + state + " \t   " +
								contact + " \t " + zip); ;
		}
	}
}