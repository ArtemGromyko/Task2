using System;
using System.Data.SqlTypes;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Artem", 20, 3);
            s1.SetMarks();
            int sum;
            Console.WriteLine("average mark = " + s1.GetAvgMark(out sum));
            Console.WriteLine("sum = " + sum);

            string name;
            int age;
            s1.GetNameAge(out name, out age);
            Console.WriteLine("name: " + name + " age: " + age);

            Student s2 = new Student();
            s1.CopyRef(ref s2);
            s2.ShowInfo();
            s2.SetNameAge(age: 21);
            s2.SetMarkSubject("z", "z");
            s2.SetMarkValue(0, 0, 0, 0, 0);
            s2.SetNameAge(age: 25);

            Student s3;
            s2.CopyObj(out s3);
            s3.ShowInfo();
        }
    }
}