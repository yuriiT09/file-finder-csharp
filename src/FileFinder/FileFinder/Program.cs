using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("File Finder");
            Console.WriteLine("1. Search files by name");
            Console.WriteLine("2. Search text inside files");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.WriteLine("File search will be added here.\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Text search will be added here.\n");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Program finished.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}