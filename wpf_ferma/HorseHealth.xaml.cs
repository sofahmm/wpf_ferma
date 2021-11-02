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
    /// Interaction logic for HorseHealth.xaml
    /// </summary>
    public partial class HorseHealth : Page
    {
        public static ObservableCollection<Horse_health> Healths { get; set; }
        public static ObservableCollection<Horse> Hor { get; set; }
        public static IEnumerable<HorseHel> horses { get; set; }
        public HorseHealth()
        {
            InitializeComponent();
            Healths = new ObservableCollection<Horse_health>(DataBaseConnect.connection.Horse_health.ToList());
            Hor = new ObservableCollection<Horse>(DataBaseConnect.connection.Horse.ToList());
            horses = from hh in Healths
                     join h in Hor
                     on hh.ID_Horse equals h.ID
                     select new HorseHel
                     {
                         Name = h.Name,
                         Weight = Convert.ToInt32(hh.Weight),
                         BodyIndex = Convert.ToInt32(hh.Body_mass_index),
                         Body_temperature = Convert.ToInt32(hh.Body_temperature),
                         DentalCondition = hh.Dental_condition,
                         DataReport = hh.DataReport.ToString()
                         
                     };
            this.DataContext = this;
            
        }

        private void listUser_Loaded(object sender, RoutedEventArgs e)
        {
            listUser.ItemsSource = DataBaseConnect.connection.Horse_health.ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUser.ItemsSource = DataBaseConnect.connection.Horse_health.Where(x => x.Body_mass_index.ToString().Contains(search.Text)).ToList();
            listUser.ItemsSource = DataBaseConnect.connection.Horse_health.Where(x => x.Weight.ToString().Contains(search.Text)).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            healthAdd he = new healthAdd();
            NavigationService.Navigate(he);
        }
    }
    public class HorseHel
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int BodyIndex { get; set; }
        public int Body_temperature { get; set; }
        public string DentalCondition { get; set; }
        public string DataReport { get; set; }
    }
}
