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
    /// Interaction logic for AddSortCent.xaml
    /// </summary>
    public partial class AddSortCent : Page
    {
        public AddSortCent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var r = new Sorting_Center();
            r.Address = txt_addres.Text;
            DataBaseConnect.connection.Sorting_Center.Add(r);
            DataBaseConnect.connection.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
