using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public static ObservableCollection<Users> use { get; set; }
        public AdminPage(/*Users a*/)
        {
            InitializeComponent();
            //use = new ObservableCollection<Users>(DataBaseConnect.connection.Users.ToList());
        }

        private void LVChanged(object sender, SelectionChangedEventArgs e)
        {/*
            var a = (sender as ListView).SelectedItem as Users;
            MessageBox.Show(a.Name);

            AdminPage win = new AdminPage(a);
            NavigationService.GetNavigationService(win);*/
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            AdminReg r = new AdminReg();
            NavigationService.Navigate(r);
        }

        private void btn_click1(object sender, RoutedEventArgs e)
        {
            AdmHorses h = new AdmHorses();
            NavigationService.Navigate(h);
        }

        private void btn_click2(object sender, RoutedEventArgs e)
        {
            HorseHealth hel = new HorseHealth();
            NavigationService.Navigate(hel);
        }

        private void btn_click3(object sender, RoutedEventArgs e)
        {

        }

        private void btn_click4(object sender, RoutedEventArgs e)
        {

        }

        private void btn_click5(object sender, RoutedEventArgs e)
        {

        }
    }
}
