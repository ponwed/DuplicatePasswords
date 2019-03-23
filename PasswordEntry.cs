using System.Collections.Generic;

namespace DuplicatePasswords
{
    public class PasswordEntry
    {
        public string password;
        public string username;
        public string site;
        public string name;

        public PasswordEntry(string _name, string _site, string _username, string _password)
        {
                name = _name;
                site = _site;
            username = _username;
            password = _password;
        }
    }
}