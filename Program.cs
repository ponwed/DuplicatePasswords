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

            List<PasswordEntry> parsedFile = parser.ParseFile();

            foreach (var entry in parsedFile)
            {
                Console.WriteLine(entry.username + "\t" + entry.password);
            }
        }
    }
}
