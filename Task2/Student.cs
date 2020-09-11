using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfSubjects { get; set; }
        private Mark[] marks;

        public Student()
        {
            Name = "";
            Age = 0;
            NumberOfSubjects = 0;
            marks = null;
        }
        public Student(string n, int a, int N)
        {
            Name = n;
            Age = a;
            NumberOfSubjects = N;
            marks = new Mark[NumberOfSubjects];
            for (int i = 0; i < marks.Length; i++)
                marks[i] = new Mark();
        }
        public void SetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("enter subject: ");
                marks[i].Subject = Console.ReadLine();
                Console.Write("enter value: ");
                marks[i].Value = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("name: " + Name + " age: " + Age + " NumberOfMarks: " + NumberOfSubjects);
            if (marks != null)
                for (int i = 0; i < marks.Length; i++)
                    marks[i].ShowInfo();
        }
        public int GetAvgMark(out int sum)
        {
            sum = 0;
            if (marks.Length != 0)
            {
                for (int i = 0; i < marks.Length; i++)
                    sum += marks[i].Value;
                return (int)Math.Round((double)(sum / marks.Length));
            }
            else
            {
                return 0;
            }
        }
        public void ResetAllMarks()
        {
            for (int i = 0; i < marks.Length; i++)
                marks[i].Value = 0;
        }
        public void GetNameAge(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
        public void SetNameAge(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }
        public void CopyRef(ref Student s)
        {
            s = this;
        }
        public void CopyObj(out Student s)
        {
            s = new Student();
            s.Name = Name;
            s.Age = Age;
            s.NumberOfSubjects = NumberOfSubjects;
            s.marks = new Mark[NumberOfSubjects];
            for (int i = 0; i < NumberOfSubjects; i++)
            {
                s.marks[i] = new Mark();
                s.marks[i].Subject = marks[i].Subject;
                s.marks[i].Value = marks[i].Value;
            }
        }
        public void SetMarkValue(params int[] v)
        {

            if (NumberOfSubjects != 0)
            {
                int length = v.Length <= NumberOfSubjects ? v.Length : NumberOfSubjects;
                for (int i = 0; i < length; i++)
                    marks[i].Value = v[i];
            }
            else
                Console.WriteLine("NumberOfSubjects = 0");

        }
        public void SetMarkSubject(params string[] s)
        {
            if (NumberOfSubjects != 0)
            {
                int length = s.Length <= NumberOfSubjects ? s.Length : NumberOfSubjects;
                for (int i = 0; i < length; i++)
                    marks[i].Subject = s[i];
            }
            else
                Console.WriteLine("NumberOfSubjects = 0");
        }
        public void ShowField(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.WriteLine("name: "+Name);
                    break;
                case 1:
                    Console.WriteLine("age: "+Age);
                    break;
                case 2:
                    Console.WriteLine("NumberOfSubject: "+NumberOfSubjects);
                    break;
                case 3:
                    for(int i=0; i < NumberOfSubjects; i++)
                    {
                        Console.WriteLine("marks[{0}].Value = {1}", i, marks[i].Value);
                        Console.WriteLine("marks[{0}].Subject = {1}", i, marks[i].Subject);
                    }
                    break;
                default:
                    Console.WriteLine("parameter \"choice\" is incorrect");
                    break;
            }
        }
    }
}