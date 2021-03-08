using System;
using System.Collections.Generic;

namespace TryCatch
{
    public class AddressBook
    {
        /* A dictionary is ike an object that has a key/value pair
           For this example, email as the key
        */
        public Dictionary<string, Contact> AddressDictionary = new Dictionary<string, Contact>();
        public void AddContact(Contact person)
        {
            try
            {
                // Dot notation to access the Email property
                AddressDictionary.Add(person.Email, person);
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Dictionary try catch");
            }
        }


        // Method to access dictionary
        public Contact GetByEmail(string taco)
        {
            // How to access the keys in a dictionary
            try
            {
                return AddressDictionary[taco];
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Email address not found.");
                return null;
            }

        }

    }

}
