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
    /// Interaction logic for healthAdd.xaml
    /// </summary>
    public partial class healthAdd : Page
    {
        public static ObservableCollection<Horse> horses { get; set; }
        public healthAdd()
        {
            InitializeComponent();
            horses = new ObservableCollection<Horse>(DataBaseConnect.connection.Horse.ToList());
            this.DataContext = this;
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            var h = new Horse_health();
            //h.ID_Horse = Convert.ToInt32( cb_name);
            h.Weight = Convert.ToInt32(txt_weight);
            h.Body_mass_index = Convert.ToInt32(txt_mass_index);
            h.Body_temperature = Convert.ToInt32(txt_bodytemp);
            h.Dental_condition = txt_dentalCondit.ToString();
            h.DataReport = Convert.ToDateTime(txt_data);
            DataBaseConnect.connection.Horse_health.Add(h);
            DataBaseConnect.connection.SaveChanges();
            NavigationService.GoBack();
        }
    }

}
