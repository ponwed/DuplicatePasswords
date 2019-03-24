using System.Collections.Generic;
using System.Linq;

namespace DuplicatePasswords
{
    public class PasswordParser
    {
        private List<string> content;
        private List<PasswordEntry> parsedContent;


        public PasswordParser(List<string> _content)
        {
            content = _content;
        }

        private void ParseFile()
        {
            string[] splitString;
            parsedContent = new List<PasswordEntry>();

            foreach (string line in content)
            {
                splitString = line.Split(',');
                PasswordEntry passwordEntry = new PasswordEntry(splitString[0], splitString[1], splitString[2], splitString[3]);
                parsedContent.Add(passwordEntry);
            }
        }

        public List<IGrouping<string, PasswordEntry>> FindDuplicates()
        {
            ParseFile();
            var query = parsedContent.GroupBy(x => x.password).Where(g => g.Count() > 1).ToList();
            return query;
        }
    }
}