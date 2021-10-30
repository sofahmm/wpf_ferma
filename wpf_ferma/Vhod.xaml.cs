using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace wpf_ferma
{
    /// <summary>
    /// Interaction logic for Vhod.xaml
    /// </summary>
    public partial class Vhod : Page
    {
        public static ObservableCollection<Users> users { get; set; }
        public Vhod()
        {

            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registr());

            //users = new ObservableCollection<Users>(DataBaseConnect.connection.Users.ToList());
            //var a = users.Where(s => s.Login == txt_login.Text && s.Password == txt_password.Password).FirstOrDefault();
            //if(a != null)
            //{
            //    MessageBox.Show("Sucsesfull");
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {  
            users = new ObservableCollection<Users>(DataBaseConnect.connection.Users.ToList());
            var a = users.Where(s => s.Login == txt_login.Text && s.Password == txt_password.Password).FirstOrDefault();
            if (a != null)
            {
                //MessageBox.Show("Sucsesfull");
                UserWin us = new UserWin();
                NavigationService.Navigate( us );
            }

        }
    }
}
