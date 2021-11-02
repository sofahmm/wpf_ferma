using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace wpf_ferma
{
    /// <summary>
    /// Interaction logic for AdmHorses.xaml
    /// </summary>
    public partial class AdmHorses : Page
    {
        public static ObservableCollection<Horse> Horse { get; set; }
        public AdmHorses()
        {
            InitializeComponent();
            Horse = new ObservableCollection<Horse>(DataBaseConnect.connection.Horse.ToList());
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddHorse ah = new AddHorse();
            NavigationService.Navigate(ah);
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            //listUser.ItemsSource = DataBaseConnect.connection.Horse.Where(x => x.Name.Contains(search.Text)).ToList();
            listUser.ItemsSource = DataBaseConnect.connection.Horse.Where(x => x.Age_of_the_foal.ToString().Contains(search.Text)).ToList();
        }

        private void listUser_Loaded(object sender, RoutedEventArgs e)
        {
            listUser.ItemsSource = DataBaseConnect.connection.Horse.ToList();
        }
    }
}
