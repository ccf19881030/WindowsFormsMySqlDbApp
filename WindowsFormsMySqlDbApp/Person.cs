using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMySqlDbApp
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullInfo
        {
            get
            {
                // "Tim Corey (test@test.com)"
                return $" {FirstName} {LastName} ({EmailAddress})";
            }
        }

    }
}
