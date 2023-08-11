using System;
using System.Collections.Generic;

namespace HierarchicalInheritanceExample
{
    public record Langknown(List<string> Strings)
    {
        public void DisplayFullName()
        {
            Console.WriteLine("<---------------------->");
            Console.WriteLine("Languages Known");
            Console.WriteLine("<---------------------->");

            for (int i = 0; i < Strings.Count;i++)
            {
                Console.WriteLine(Strings[i]);
            }

        }
    }

    public record LangNot(List<string> Strings, List<string> Not) :Langknown( Strings)
    {
        public void DisplayStudentInfo()
        {
            DisplayFullName();
            Console.WriteLine("<---------------------->");
            Console.WriteLine("Languages Not Known");
            Console.WriteLine("<---------------------->");
            for (int i = 0; i < Not.Count;i++)
            {
                Console.WriteLine(Strings[i]);
            }
        }
    }

    public record TechHalf(List<string> Strings, List<string> Half) : Langknown(Strings)
    {
        public void DisplayTeacherInfo()
        {
            DisplayFullName();
            Console.WriteLine("<---------------------->");
            Console.WriteLine("Languages Slightly Known");
            Console.WriteLine("<---------------------->");
            for (int i=0;i<Half.Count;i++)
            {
                Console.WriteLine(Half[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> Strings = new List<string>();
            Langknown known = new Langknown(Strings);
            Strings.Add("HTML");
            Strings.Add("CSS");
            Strings.Add("JavaSript");
            Strings.Add("TypeScript");
            Strings.Add("React");
            Strings.Add("SQL Server");
            Strings.Add("C#");
          

            List<string> Not = new List<string>();
            LangNot notknown = new LangNot(Strings, Not);
            Not.Add("Django");
            Not.Add("Node ");
            Not.Add("Ruby");
            Not.Add("Angular");
            Not.Add("Vue JS");
            Not.Add("PHP");
           

            notknown.DisplayStudentInfo();
           
            List<string> Half = new List<string>();
            TechHalf tech = new TechHalf(Strings ,Half);
            Half.Add("C");
            Half.Add("C++");
            Half.Add("JAVA");
            Half.Add("Jquery");
            tech.DisplayTeacherInfo();

            Console.ReadLine();
        }
    }
}
