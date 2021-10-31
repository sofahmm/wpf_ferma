using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_ferma
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        public static ObservableCollection<Users> us { get; set; }
        public Welcome()
        {
            InitializeComponent();
        }

        private void admin_click(object sender, RoutedEventArgs e)
        {
            AdmAuth adm = new AdmAuth();

            NavigationService.Navigate(adm);

        }

        private void vet_click(object sender, RoutedEventArgs e)
        {
            VetAuth vet = new VetAuth();
            NavigationService.Navigate(vet);
        }

        private void Cour_click(object sender, RoutedEventArgs e)
        {
            Courier cou = new Courier();
            NavigationService.Navigate(cou);
        }
    }
}
