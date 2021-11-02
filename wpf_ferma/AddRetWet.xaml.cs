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
    /// Interaction logic for AddRetWet.xaml
    /// </summary>
    public partial class AddRetWet : Page
    {
        public AddRetWet()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var r = new Retail_Network();
            r.Name = txt_name.Text;
            r.Address = txt_addres.Text;
            DataBaseConnect.connection.Retail_Network.Add(r);
            DataBaseConnect.connection.Retail_Network.ToList();
            NavigationService.GoBack();
        }
    }
}
