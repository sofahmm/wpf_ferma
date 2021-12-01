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
    /// Interaction logic for SortingCenter.xaml
    /// </summary>
    public partial class SortingCenter : Page
    {
        public static ObservableCollection<Sorting_Center> sorting_s { get; set; }
        public SortingCenter()
        {
            InitializeComponent();
            sorting_s = new ObservableCollection<Sorting_Center>(DataBaseConnect.connection.Sorting_Center.ToList());
            this.DataContext = this;
        }

        private void listUser_Loaded(object sender, RoutedEventArgs e)
        {
            listUser.ItemsSource = DataBaseConnect.connection.Sorting_Center.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddSortCent ads = new AddSortCent();
            NavigationService.Navigate(ads);
            this.DataContext = this;
        }
    }
}
