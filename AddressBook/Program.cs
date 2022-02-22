﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookMain addressbook = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.Add Contact."
                                + "\n 2.Edit Contact."
                                + "\n 3.Delete Contact."
                                + "\n 4.Exit.\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.AddContact();
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name To Edit Contact : ");
                        string firstName = Convert.ToString(Console.ReadLine());
                        addressbook.EditContact(firstName);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name To Delete Contact : ");
                        string firstNameToDelete = Convert.ToString(Console.ReadLine());
                        addressbook.DeleteContact(firstNameToDelete);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!!!");
                        break;
                }
            }
        }
    }
}