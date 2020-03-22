using System;
using System.Collections.Generic;
using System.Text;

namespace UserDataCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResults();
        }
        
        static void PrintResults()
        {
            var data = CollectAnswers();
            
            var userInfo = new StringBuilder();
            userInfo.AppendLine("name\tage\theight\tsalary");

            foreach (var item in data)
            {
                userInfo.AppendLine(item);
            }
            Console.WriteLine(userInfo.ToString());
            
            Console.Write("\nPress any button to finish the program");
            Console.ReadKey();
        }
        
        static List<string> CollectAnswers()
        {
            var answers = new List<string> {};

            do
            {
                answers.Add(GetDataFromUser());
            } while (NeedMoreData());

            return answers;
        }
        
        static bool NeedMoreData()
        {
            Console.Write("Would you like to add more? (y/n)");
            var answer = Convert.ToString(Console.ReadLine());

            return answer.Length > 0 && answer[0] == 'y';
        }
        
        static string GetDataFromUser()
        {
            // make an object instead of list in the future
            var userData = new List<string> {};
            
            Console.Write("Enter your name: ");
            var name = Convert.ToString(Console.ReadLine());
            userData.Add(name);

            Console.Write("Enter your age: ");
            // convert to Int32
            var age = Convert.ToString(Console.ReadLine());
            userData.Add(age);

            Console.Write("Enter your height: ");
            // convert to double
            var height = Convert.ToString(Console.ReadLine());
            userData.Add(height);
            
            Console.Write("Enter your salary (in Euro): ");
            // convert to decimal
            var salary = Convert.ToString(Console.ReadLine());
            userData.Add(salary);
            
            return String.Join('\t', userData);
        }
    }
}
