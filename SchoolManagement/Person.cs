using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    abstract class Person
    {
        protected string Name;
        protected string Birthday;
        protected string Address;
        protected string Email;

        public string getName()
        {
            return Name;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public string getBithday()
        {
            return Birthday;
        }
        public void setBithday(string Bithday)
        {
            this.Birthday = Bithday;
        }
        public string getAddress()
        {
            return Address;
        }
        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        public string getEmail()
        {
            return Email;
        }
        public void setEmail(string Email)
        {

            this.Email = Email;

        }

        public virtual void Input()
        {
            do
            {
                Console.Write(" + Enter Name: ");
                setName(Console.ReadLine());
                if (string.IsNullOrEmpty(getName()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(getName()));

            do
            {
                Console.Write(" + Enter Date Of Birth: ");
                setBithday(Console.ReadLine());
                if (string.IsNullOrEmpty(getBithday()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(getBithday()));
            do
            {
                Console.Write(" + Enter Address: ");
                setAddress(Console.ReadLine());
                if (string.IsNullOrEmpty(getAddress()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(getAddress()));

            do
            {
                Console.Write(" + Enter Email: ");
                setEmail(Console.ReadLine());
                if (this.Email == null || !this.Email.Contains("@") || this.Email.Contains(" "))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Error Input! Please Input again. Email must have @ and not have Space! \n");
                    Console.ResetColor();
                }
            } while (this.Email == null || !this.Email.Contains("@") || this.Email.Contains(" "));
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($" || Name: {getName()}\t| Birthday: {getBithday()}\t| Address: {getAddress()}\t | Email: {getEmail()}\t ");
        }
    }
}
