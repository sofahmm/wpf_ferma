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

namespace wpf_ferma
{
    /// <summary>
    /// Interaction logic for AdminReg.xaml
    /// </summary>
    public partial class AdminReg : Page
    {
        public AdminReg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = new Users();
            a.Name = txt_name.Text;
            a.Login = txt_login.Text;
            a.Password = txt_password.Password;
            a.Specialization = Special.Text;
            DataBaseConnect.connection.Users.Add(a);
            DataBaseConnect.connection.SaveChanges();
            NavigationService.GoBack();

        }
    }
}
