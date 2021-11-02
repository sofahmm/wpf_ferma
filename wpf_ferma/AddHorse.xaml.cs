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
    /// Interaction logic for AddHorse.xaml
    /// </summary>
    public partial class AddHorse : Page
    {
        public AddHorse()
        {
            InitializeComponent();
        }

        private void btn_click_save(object sender, RoutedEventArgs e)
        {
            var h = new Horse();
            h.Name = txt_name.Text;
            h.Age = Convert.ToInt32(txt_age.Text);
            h.Age_of_the_foal = Convert.ToInt32(txt_agefoal.Text);
            DataBaseConnect.connection.Horse.Add(h);
            DataBaseConnect.connection.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
