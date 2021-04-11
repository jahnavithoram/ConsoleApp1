using System;
using System.IO;

class Program
{
    static void lineChanger(string newText, string fileName, int line_to_edit)
    {
        string[] arrLine = File.ReadAllLines(fileName);
        arrLine[line_to_edit - 1] = newText;
        File.WriteAllLines(fileName, arrLine);
    }
    static void showdata(string fileName)
    {
        string[] arrLine = File.ReadAllLines(fileName);
        foreach (var item in arrLine)
        {
            Console.WriteLine(item.ToString());
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your File Name:\n");
        string sourceFile = Console.ReadLine();
       
        if (!(File.Exists(sourceFile)))
        {
            Console.WriteLine("CREATING YOUR FILE...\n");
            var myfile = File.Create(sourceFile);
            Console.WriteLine("CREATED...\n");
            myfile.Close();
            string [] lines = new string[4];
            int i;
            Console.WriteLine("\n\nENTER fields...\n 1.ID 2.NAME 3.CLASS 4.SECTION\n");
            for ( i = 0; i < 4; i++)
                lines[i] = Console.ReadLine();
            File.WriteAllLines(sourceFile, lines);
            //  myfile.Close();
            Console.WriteLine("\nINSERTED...\n");
            showdata(sourceFile);
        }
        else
        {
            Console.WriteLine("\nBEFORE...\n");
            showdata(sourceFile);
            Console.WriteLine("\n\nENTER field to be UPDATED...\n 1.ID 2.NAME 3.CLASS 4.SECTION\n");
            int ln= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NEW FILED DATA...\n");
            string newl = Console.ReadLine();
            lineChanger(newl, sourceFile, ln);
            Console.WriteLine("\nAFTER...\n");
            showdata(sourceFile);
        }
       
       
     //   string[] arrLine = File.ReadAllLines(sourceFile);
      //  arrLine[res - 1] = line;
      //  File.WriteAllLines(sourceFile, line);

    }
}