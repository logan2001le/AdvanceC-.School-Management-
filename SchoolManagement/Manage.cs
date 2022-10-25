using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    class Manage
    {
        private List<Student> listStudent = new List<Student>();
        private List<Lecturer> listLecturer = new List<Lecturer>();
        public void Input()
        {
            String choose;
            do
            {
                Console.WriteLine("\t **************************");
                Console.WriteLine("\t *   [1]. Manage Lecturer *");
                Console.WriteLine("\t *   [2]. Manage Student  *");
                Console.WriteLine("\t *   [3]. Exit            *");
                Console.WriteLine("\t **************************");
                Console.Write("\t => Please Choose: ");

                choose = Console.ReadLine();

                if (choose != "1" && choose != "2" && choose != "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
                Console.Clear();
            } while (choose != "1" && choose != "2" && choose != "3");
            switch (Convert.ToInt32(choose))
            {
                case 1:
                    menuLecturer();
                    break;
                case 2:
                    menuStudent();
                    break;
                case 3:
                    break;

            }
        }

        public void menuStudent()
        {
            Student st = new Student();

            String menuStudentChoose;

            do
            {
                Console.WriteLine("\n\t  ***************************");
                Console.WriteLine("\t  * [1]. Add new Student    *");
                Console.WriteLine("\t  * [2]. View All Student   *");
                Console.WriteLine("\t  * [3]. Search Student     *");
                Console.WriteLine("\t  * [4]. Delete Student     *");
                Console.WriteLine("\t  * [5]. Update Student     *");
                Console.WriteLine("\t  * [6]. Back To Main Menu  *");
                Console.WriteLine("\t  ***************************");
                Console.Write("\t\t => Please Choose: ");
                menuStudentChoose = Console.ReadLine();

                if (menuStudentChoose != "1" && menuStudentChoose != "2" &&
                    menuStudentChoose != "3" && menuStudentChoose != "4" &&
                    menuStudentChoose != "5" && menuStudentChoose != "6")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (menuStudentChoose != "1" && menuStudentChoose != "2" &&
                    menuStudentChoose != "3" && menuStudentChoose != "4" &&
                    menuStudentChoose != "5" && menuStudentChoose != "6");

            switch (Convert.ToInt32(menuStudentChoose))
            {
                case 1:
                    Console.WriteLine("");
                    st.Input();
                    listStudent.Add(st);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t => Add ! Enter to back Menu. \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    menuStudent();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("========= List Off All Student's Information =========");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (Student std in listStudent)
                    {
                        std.ShowInfo();
                    }
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\n\n => Enter to back Menu!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    menuStudent();
                    break;
                case 3:
                    Console.Write("\n * Please enter Student ID that you want to find: ");
                    String stSearch = Console.ReadLine();
                    int stCountFind = 0;
                    foreach (Student std in listStudent)
                    {
                        if (std.SID == stSearch)
                        {
                            stCountFind++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n *** Result ***");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            std.ShowInfo();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n\t => Enter to back Menu!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            menuStudent();
                        }
                    }
                    if (stCountFind == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" => Can't find information of that student! Enter to back Menu. ");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    menuStudent();
                    break;
                case 4:
                    Console.WriteLine("\n  * Please enter Student ID that you want to delete: ");
                    String stDel = Console.ReadLine();
                    int stCountDel = 0;
                    foreach (Student std in listStudent.ToArray())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t Deleted Successfully !");

                        if (std.SID == stDel)
                        {
                            stCountDel++;
                            listStudent.Remove(std);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("========= List Off All Student's Information =========");
                            Console.ForegroundColor = ConsoleColor.Green;
                            foreach (Student stList in listStudent)
                            {
                                stList.ShowInfo();
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n\t => Enter to back Menu.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    if (stCountDel == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" => Can't find this name! Enter to back Menu. ");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Console.ResetColor();
                    menuStudent();
                    break;
                case 5:
                    Console.WriteLine("\n  * Please enter Student Name that you want to Update: ");
                    String stUpdate = Console.ReadLine();
                    int stCountUpdate = 0;
                    foreach (Student std in listStudent)
                    {
                        if (std.SID == stUpdate)
                        {
                            stCountUpdate++;
                            st.Input();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n\t => UPDATED! Enter to back Menu.");
                            Console.ResetColor();
                            st.ShowInfo();
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    if (stCountUpdate == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" => Can't find this name! Enter to back Menu. ");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    menuStudent();
                    break;
                case 6:
                    Input();
                    break;
            }


        }
        public void menuLecturer()
        {
            Lecturer lec = new Lecturer();
            String menuLectureChoose;
            do
            {
                Console.WriteLine("\n\t  ***************************");
                Console.WriteLine("\t  * [1]. Add new Lecturer    *");
                Console.WriteLine("\t  * [2]. View All Lecturer   *");
                Console.WriteLine("\t  * [3]. Search Lecturer     *");
                Console.WriteLine("\t  * [4]. Delete Lecturer     *");
                Console.WriteLine("\t  * [5]. Update Lecturer     *");
                Console.WriteLine("\t  * [6]. Back To Main Menu   *");
                Console.WriteLine("\t  ***************************");
                Console.Write("\t\t => Please Choose: ");
                menuLectureChoose = Console.ReadLine();

                if (menuLectureChoose != "1" && menuLectureChoose != "2" &&
                    menuLectureChoose != "3" && menuLectureChoose != "4" &&
                    menuLectureChoose != "5" && menuLectureChoose != "6")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (menuLectureChoose != "1" && menuLectureChoose != "2" &&
                    menuLectureChoose != "3" && menuLectureChoose != "4" &&
                    menuLectureChoose != "5" && menuLectureChoose != "6");

            switch (Convert.ToInt32(menuLectureChoose))
            {
                case 1:
                    Console.WriteLine("");
                    lec.Input();
                    listLecturer.Add(lec);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t => Add ! Enter to back Menu. \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    //   Console.Clear();
                    menuLecturer();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("========= List Off All Lecturer's Information =========");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (Lecturer lect in listLecturer)
                    {
                        lect.ShowInfo();
                    }
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\n\n => Enter to back Menu!");
                    Console.ResetColor();
                    Console.ReadKey();
                    //  Console.Clear();
                    menuLecturer();
                    break;
                case 3:
                    Console.Write("\n * Please enter Lecture ID that you want to find: ");
                    String lecFind = Console.ReadLine();
                    int lecCountFind = 0;
                    foreach (Lecturer lect in listLecturer)
                    {
                        if (lect.LecID == lecFind)
                        {
                            lecCountFind++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n *** Result ***");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            lect.ShowInfo();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n\t => Enter to back Menu!");
                            Console.ResetColor();
                            Console.ReadKey();
                            //  Console.Clear();
                            menuLecturer();
                        }
                    }
                    if (lecCountFind == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" => Can't find information of that lecturer! Enter to back Menu. ");
                        Console.ResetColor();
                        Console.ReadKey();
                        // Console.Clear();
                    }
                    menuLecturer();
                    break;
                case 4:
                    Console.WriteLine("\n  * Please enter Lecturer ID that you want to delete: ");
                    String lecDel = Console.ReadLine();
                    int lecCountDel = 0;
                    foreach (Lecturer lect in listLecturer.ToArray())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t Deleted Successfully !");

                        if (lect.LecID == lecDel)
                        {
                            lecCountDel++;
                            listLecturer.Remove(lect);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("========= List Off All Lecturer's Information =========");
                            Console.ForegroundColor = ConsoleColor.Green;
                            foreach (Lecturer lecList in listLecturer)
                            {
                                lecList.ShowInfo();
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n\t => Enter to back Menu.");
                            Console.ResetColor();
                            Console.ReadKey();
                            // Console.Clear();
                        }
                    }
                    if (lecCountDel == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" => Can't find this name! Enter to back Menu. ");
                        Console.ResetColor();
                        Console.ReadKey();
                        //  Console.Clear();
                    }
                    Console.ResetColor();
                    menuLecturer();
                    break;
                case 5:
                    Console.WriteLine("\n  * Please enter Lecturer ID that you want to Update: ");
                    String lecUpdate = Console.ReadLine();
                    int lecCountUpdate = 0;
                    foreach (Lecturer lect in listLecturer)
                    {
                        if (lect.LecID == lecUpdate)
                        {
                            lecCountUpdate++;
                            lect.Input();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n\t => UPDATED! Enter to back Menu.");
                            Console.ResetColor();
                            lect.ShowInfo();
                            Console.ReadKey();
                            //Console.Clear();
                        }
                    }
                    if (lecCountUpdate == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" => Can't find this name! Enter to back Menu. ");
                        Console.ResetColor();
                        Console.ReadKey();
                        // Console.Clear();
                    }
                    menuLecturer();
                    break;
                case 6:
                    Input();
                    break;
            }
        }
    }

}
