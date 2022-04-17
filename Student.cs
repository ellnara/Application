using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Student
    {
        public static List<Student> AllStudents = new List<Student>();
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public bool Type = false;
        public Student()
        {

        }
        public Student(string fullname, string groupno, bool type)
        {
            GroupNo = groupno;
            Type = type;
            FullName = fullname;
        }
        public override string ToString()
        {
            var result = Type ? "zemanetli" : "zemanetsiz";
            return $"\nFull Name: {FullName} Group No: {GroupNo} Type: {result}";
        }
        public void AddAllStudents(Student student)
        {
            AllStudents.Add(student);
        }
        public void ShowAllStudents()
        {
            foreach (var item in AllStudents)
            {
                var result = Type ? "zemanetli" : "zemanetsiz";
                Console.WriteLine($"\nFull Name: {item.FullName} \nGroup No: {item.GroupNo} \nType: {result}");
            }
        }
    }
}
