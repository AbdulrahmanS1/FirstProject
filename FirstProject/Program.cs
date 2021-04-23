using System;
using System.Collections.Generic;

namespace FirstProject
{
    class Program
    {
        static void gradeSearcher(List<int> studentGrade, int searchable) 
        {
            int counter = 0;
            for (int i = 0; i < studentGrade.Count; i++)
            {
                if (searchable == studentGrade[i])
                {
                    counter++;
                }
            }
            Console.WriteLine("Number of student with the grade {0} is : {1}",searchable,counter);

        }
        static void Main(string[] args)
        {

            string name = "";
            int grade = 0;
            List<string> names = new List<string>();
            List<int> drajah = new List<int>();
            string choice = "";
            while (true)
            {
                    Console.WriteLine("Student Name :");
                    name = Console.ReadLine();
                     names.Add(name);
                    Console.WriteLine("Student grade: ", names);
                    grade= Convert.ToInt32(Console.ReadLine());
                     drajah.Add(grade);
                    Console.WriteLine("**********************");
                Console.WriteLine("Add another student (Yes/No) :");
                choice =Console.ReadLine();
                if (choice == "No")
                    break; 
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("Student name : {0}, Student Grade: {1}",names[i],drajah[i]);
            }
            Console.WriteLine("Enter the grade to search:");
            int searcher = Convert.ToInt32(Console.ReadLine());
            gradeSearcher(drajah, searcher);

            
        }
    }
}
