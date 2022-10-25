using System;
using System.Collections.Generic;
using System.Text;


namespace SchoolManagement
{
    class Student : Person
    {
        private string stID;
        protected string stClass;
        public string SID { get { return this.stID; } set { this.stID = value; } }

        public override void Input()
        {
            do
            {
                Console.Write(" + Enter Student ID: ");
                stID = (Console.ReadLine());
                if (string.IsNullOrEmpty(SID))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(SID));
            base.Input();
            Console.Write(" + Enter Class:");
            stClass = (Console.ReadLine());
        }

        public override void ShowInfo()
        {
            Console.Write($"\n + Student ID\t: {stID} ");
            base.ShowInfo();
            Console.Write($"\n + Class: {stClass} ");
            Console.WriteLine("\n ___________________________________________________________________________________________________________");
        }
    }
}

