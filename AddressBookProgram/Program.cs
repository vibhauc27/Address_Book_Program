using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressbook = new AddressBookMain();
            addressbook.AddAddressBook();
            addressbook.WriteToFile();
            addressbook.ReadFile();

        }
    }
}