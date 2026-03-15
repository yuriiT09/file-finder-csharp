using System;
using System.IO;

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
                SearchFilesByName();
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

    static void SearchFilesByName()
    {
        Console.Write("Enter folder path: ");
        string folderPath = Console.ReadLine();

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder does not exist.\n");
            return;
        }

        Console.Write("Enter file name or part of file name: ");
        string searchText = Console.ReadLine();

        try
        {
            string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
            int count = 0;

            foreach (string file in files)
            {
                if (Path.GetFileName(file).Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(file);
                    count++;
                }
            }

            Console.WriteLine($"\nFound files: {count}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message + "\n");
        }
    }
}