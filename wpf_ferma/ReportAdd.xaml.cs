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
    /// Interaction logic for ReportAdd.xaml
    /// </summary>
    public partial class ReportAdd : Page
    {
        public static ObservableCollection<Sorting_Center_report_> sortings { get; set; }
        public ReportAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var r = new Sorting_Center_report_();
            r.Data = Convert.ToDateTime(txt_name.Text);
            r.Number_of_cans_delivered = Convert.ToInt32(txt_addres.Text);
            r.Average_product_temperature = Convert.ToInt32(txt_nae.Text);
            r.ID_Sorting_Center = Convert.ToInt32(txt_adres.Text);
            DataBaseConnect.connection.Sorting_Center_report_.Add(r);
            DataBaseConnect.connection.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
