using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
}
