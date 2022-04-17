using ConsoleApp6.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Group
    {
        public string No { get; set; }
        public bool IsOnline { get; set; }
        private int _limit { get; set; }

        public List<Student> List = new List<Student>();

        public static List<Group> Groups = new List<Group>();

        public Categories Category;
        public static int Bp = 100;
        public static int Dp = 100;
        public static int Sl = 100;
        public Group()
        {

        }
        public Group(Categories category, bool isOnline)
        {
            IsOnline = isOnline;
            switch (category)
            {
                case Categories.Programming:
                    No = $"Bp{Bp}";
                    Bp++;
                    break;
                case Categories.Design:
                    No = $"Dp{Dp}";
                    Dp++;
                    break;
                case Categories.SystemAdministration:
                    No = $"Sl{Sl}";
                    Sl++;
                    break;
                default:
                    Console.WriteLine("not a category");
                    break;
            }
            Category = category;
        }
        public void AddGroup(Group group)
        {
            if (group.IsOnline == true)
            {
                group._limit = 15;

            }
            else
            {
                group._limit = 10;
            }
            Groups.Add(group);
        }
        public void ShowGroups()
        {
            foreach (var item in Groups)
            {
                Console.WriteLine($"    Group: {item.No} \nIsOnline: {item.IsOnline} \nTelebelerin sayi: {List.Count}\n");
            }
        }
        public void AddStudent(Student student)
        {
            if (List.Count < _limit)
            {
                List.Add(student);
            }
            else
            {
                Console.WriteLine("qrup doludur");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"\n Group: {No} \nIsOnline: {IsOnline} \nStudents Count: {List.Count}\n");
        }
        public void ShowStudents()
        {
            foreach (var item in List)
            {
                Console.WriteLine($"Student's Name: {item.FullName} Student's Type: {item.Type}");
            }
        }
        public void ShowGroupStudents(string no)
        {
            foreach (var item in List)
            {
                if (item.GroupNo == no)
                {
                    var result = item.Type ? "zemanetli" : "zemanetsiz";
                    Console.WriteLine($"Student's Name: {item.FullName} Student's Type: {result}");
                }
            }
        }
        public void ShowAllGroups()
        {
            foreach (var item in Groups)
            {
                Console.WriteLine($"\n Group: {item.No} \nIsOnline: {IsOnline} \nStudent's Count: {List.Count}\n");
            }
        }
        public void CreateStudent(Student student)
        {
            foreach (var item in Groups)
            {
                if (student.GroupNo == item.No)
                {
                    foreach (var itemm in List)
                    {
                        Console.WriteLine($"Student's Name: {itemm.FullName} Student's Type: {itemm.Type}");
                    }
                }
            }
        }
        public void EditGroup(string no, int newNo)
        {
            foreach (var item in Groups)
            {
                if (item.No == no)
                {
                    switch (item.Category)
                    {
                        case Categories.Programming:
                            item.No = $"Bp{newNo}";
                            break;
                        case Categories.Design:
                            item.No = $"Dp{newNo}";
                            break;
                        case Categories.SystemAdministration:
                            item.No = $"Sl{newNo}";
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }

        }
    }
}
