using System;
using System.Collections.Generic;
using System.IO;

namespace DuplicatePasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileContent = new List<string>(File.ReadAllLines(args[0]));
            PasswordParser parser = new PasswordParser(fileContent);

            var duplicates = parser.FindDuplicates();
            
            foreach (var key in duplicates)
            {
                foreach (var item in key)
                {
                    Console.WriteLine(item.name + "," + item.password);
                }
            }
        }
    }
}
