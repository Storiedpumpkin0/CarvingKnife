using System;
using System.Collections.Generic;


namespace Gradebook
{

  
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter a name for the gradebook: ");
            string bookName = Console.ReadLine();
            System.Console.WriteLine($"Great, this is {bookName}'s book");

            var book = new Book($"{bookName}'s grade book");

            bool cont = true;
            while(cont)
            {             
                Console.WriteLine("\n(999 to quit)\n Enter a grade: ");
                double newGrade = Convert.ToDouble(Console.ReadLine());
                if(newGrade == 999)
                {
                    break;
                }
                book.AddGrade(newGrade);

            }
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);
            System.Console.WriteLine("Alright, here are the stats: \n");                

            book.ShowStatistics();
           
    
        }
    }
}
