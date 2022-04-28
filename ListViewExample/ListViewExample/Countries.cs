using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class Countries
    {
        public string Region { get; set; }
        public string Capital { get; set; }
        public string DisplayName
        {
            get
            {
                return $" region:{Region}, \n capital :{Capital}";
            }
        }


    }

    
}
