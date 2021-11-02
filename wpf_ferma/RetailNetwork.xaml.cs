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
    /// Interaction logic for RetailNetwork.xaml
    /// </summary>
    public partial class RetailNetwork : Page
    {
        public static ObservableCollection<Retail_Network> retail_Networks { get; set; }
        public RetailNetwork()
        {
            InitializeComponent();
            retail_Networks = new ObservableCollection<Retail_Network>(DataBaseConnect.connection.Retail_Network.ToList());
            this.DataContext = this;
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUser.ItemsSource = DataBaseConnect.connection.Retail_Network.Where(x => x.Name.ToString().Contains(search.Text)).ToList();
        }

        private void listUser_Loaded(object sender, RoutedEventArgs e)
        {
            listUser.ItemsSource = DataBaseConnect.connection.Sorting_Center_report_.ToList();
        }
    }
}
