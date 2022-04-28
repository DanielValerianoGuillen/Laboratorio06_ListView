using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<CountryGroup> listCountries = new ObservableCollection<CountryGroup>();
        public ObservableCollection<CountryGroup> ListCountry { get { return listCountries; } }
        public ListViewGroup()
        {
            InitializeComponent();
            ViewCountry.ItemsSource = listCountries;
            listCountries.Add(new CountryGroup("Peru", new[] {
            new Countries
            {
                Region = "Costa",
                Capital = "Lima"
            },
            new Countries {
                Region ="Sierra",
                Capital ="Cuzco"
            }
            }));

            listCountries.Add(new CountryGroup("Colombia", new[] {
            new Countries
            {
                Region = "Selva",
                Capital = "Bogota"
            }
            }));
            listCountries.Add(new CountryGroup("Argentina", new[] {
            new Countries
            {
                Region = "Costa",
                Capital = "Buenos Aires"
            }
            }));
        }
    }
}