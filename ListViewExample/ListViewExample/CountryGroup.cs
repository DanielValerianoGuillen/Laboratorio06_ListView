using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class CountryGroup :ObservableCollection<Countries>
    {
        public string Paises { get; set; }

        public CountryGroup(string paises, IEnumerable<Countries> source)
            : base(source)
        {
            Paises = paises;
        }
    }
}
