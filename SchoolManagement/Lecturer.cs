using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagement;

namespace SchoolManagement
{
    class Lecturer : Person
    {
        private string lecID;
        protected string lecDept;
        public string LecID { get { return this.lecID; } set { this.lecID = value; } }

        public override void Input()
        {
            do
            {
                Console.Write(" + Enter Lecturer ID: ");
                lecID = (Console.ReadLine());
                if (string.IsNullOrEmpty(LecID))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(LecID));
            base.Input();

            do
            {
                Console.Write(" + Enter Department :  ");
                Console.WriteLine(" [A]cademic or [B]usiness or [C]omputing or [D]esign ");
                lecDept = (Console.ReadLine());

                if (lecDept == "A" || lecDept == "a")
                {
                    lecDept = "Academic";
                }

                if (lecDept == "b" || lecDept == "B")
                {
                    lecDept = "Business";
                }

                if (lecDept == "c" || lecDept == "C")
                {
                    lecDept = "Computing";
                }

                if (lecDept == "D" || lecDept == "d")
                {
                    lecDept = "Design";
                }
                if (lecDept != "A" && lecDept != "B" && lecDept != "C" &&
                    lecDept != "D" && lecDept != "a" && lecDept != "b" &&
                    lecDept != "c" && lecDept != "d" && lecDept != "Academic" &&
                    lecDept != "Business" && lecDept != "Computing" && lecDept != "Design")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.WriteLine(" [A]cademic or [B]usiness or [C]omputing or [D]esign ");
                    Console.ResetColor();
                }
            } while (lecDept != "A" && lecDept != "B" && lecDept != "C" &&
                    lecDept != "D" && lecDept != "a" && lecDept != "b" &&
                    lecDept != "c" && lecDept != "d" && lecDept != "Academic" &&
                    lecDept != "Business" && lecDept != "Computing" && lecDept != "Design");
        }
        public override void ShowInfo()
        {
            Console.Write($"\n + Lecturer ID\t: {lecID} ");
            base.ShowInfo();
            Console.Write($"\n + Department : {lecDept} ");
            Console.WriteLine("\n ___________________________________________________________________________________________________________");
        }
    }
}