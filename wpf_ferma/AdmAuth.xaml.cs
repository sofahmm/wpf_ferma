using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AdmAuth.xaml
    /// </summary>
    public partial class AdmAuth : Page
    {
        public static ObservableCollection<Users> users { get; set; }
        public AdmAuth()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<Users>(DataBaseConnect.connection.Users.ToList());
            var a = users.Where(s => s.Login == txt_login.Text && s.Password == txt_password.Password).FirstOrDefault();
            if (a != null)
            {
                if(a.Specialization == "Администратор")
                {
                    AdminPage us = new AdminPage();
                    NavigationService.Navigate(us);
                    MessageBox.Show("Пошли пить Кумыс, " + a.Name);
                }
                else
                {
                    MessageBox.Show("Попробуй ввести заново!");
                }
                //MessageBox.Show("Sucsesfull");

            }
        }
    }
}
