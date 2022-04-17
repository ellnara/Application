using ConsoleApp6.Enum;
using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Group grup = new Group();
            while (true)
            {
                Console.WriteLine($"                                                      MENU: \n1. Create a Group " +
                    $"\n2. Show All the Groups " +
                    $"\n3. Edit Group Name " +
                    $"\n4. Show Group Students" +
                    $"\n5. Show All Students " +
                    $"\n6. Create a Student");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("                                           Enter the Group Info:");
                        Console.WriteLine($"Choose Group Category: \n\n1.Programming\n2.Design\n3.System Administration");
                        int input2 = int.Parse(Console.ReadLine());
                        Categories category = new Categories();
                        switch (input2)
                        {
                            case 1:
                                category = Categories.Programming;
                                break;
                            case 2:
                                category = Categories.Design;
                                break;
                            case 3:
                                category = Categories.SystemAdministration;
                                break;
                            default:
                                Console.WriteLine("Chose correctly");
                                break;
                        }

                        int online;
                        bool isonline = false;

                        while (true)
                        {
                            Console.WriteLine($"\n1. Online \n2. Offline");
                            int defaultt = 0;
                            online = int.Parse(Console.ReadLine());
                            switch (online)
                            {
                                case 1:
                                    isonline = true;
                                    break;
                                case 2:
                                    isonline = false;
                                    break;
                                default:
                                    defaultt++;
                                    break;
                            }
                            if (defaultt == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease Enter Valid Number");
                            }
                        }
                        Group group = new Group(category, isonline);
                        group.AddGroup(group);
                        break;
                    case 2:
                        ShowGroups();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Group Number:");
                        ShowGroups();
                        string Number = Console.ReadLine();
                        Console.WriteLine("Enter the New Group Number:");
                        int newNumber = int.Parse(Console.ReadLine());
                        grup.EditGroup(Number, newNumber);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Group Number:");
                        string no = Console.ReadLine();
                        grup.ShowGroupStudents(no);
                        break;
                    case 5:
                        Student students = new Student();
                        students.ShowAllStudents();
                        break;
                    case 6:
                        Console.WriteLine("Enter Student's Full Name: ");
                        string name = Console.ReadLine();
                        int type;
                        bool stuType = false;
                        while (true)
                        {
                            Console.WriteLine("Enter the Student Type: ");
                            Console.WriteLine($"\n1. Zemanetli \n2. Zemanetsiz");
                            type = int.Parse(Console.ReadLine());
                            int defaultt = 0;
                            switch (type)
                            {
                                case 1:
                                    stuType = true;
                                    break;
                                case 2:
                                    stuType = false;
                                    break;
                                default:
                                    defaultt++;
                                    break;
                            }
                            if (defaultt == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease Enter Valid Number");
                            }
                        }
                        bool isExist = false;
                        string No;
                        while (true)
                        {
                            Console.WriteLine("Enter the Group Number: ");
                            No = Console.ReadLine();
                            foreach (var item in Group.Groups)
                            {
                                if (item.No == No)
                                {
                                    isExist = true;
                                }
                            }
                            if (isExist == false)
                            {
                                Console.WriteLine("Group doesn't exist");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Student student = new Student(name, No, stuType);
                        if (Group.Groups.Count > 0)
                        {
                            foreach (var item in Group.Groups)
                            {
                                if (item.No == No)
                                {
                                    item.AddStudent(student);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Create a Group First!");
                        }
                        student.AddAllStudents(student);
                        break;
                    default:
                        break;
                }
            }
        }
        public static void ShowGroups()
        {
            foreach (var item in Group.Groups)
            {
                item.ShowInfo();
            }
        }
    }
}


