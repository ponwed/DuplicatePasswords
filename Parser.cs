using System.Collections.Generic;

namespace DuplicatePasswords
{
    public class PasswordParser
    {
        private List<string> content;


        public PasswordParser(List<string> _content)
        {
            content = _content;
        }

        public List<PasswordEntry> ParseFile()
        {
            string[] splitString;
            List<PasswordEntry> parsedContent = new List<PasswordEntry>();

            foreach (string line in content)
            {
                splitString = line.Split(',');
                PasswordEntry passwordEntry = new PasswordEntry(splitString[0], splitString[1], splitString[2], splitString[3]);
                parsedContent.Add(passwordEntry);
            }

            return parsedContent;
        }
    }
}