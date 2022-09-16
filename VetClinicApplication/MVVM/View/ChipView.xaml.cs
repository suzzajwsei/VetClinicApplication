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
using VetClinicApplication.MVVM.Model;

namespace VetClinicApplication.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy ChipView.xaml
    /// </summary>
    public partial class ChipView : UserControl
    {
        public ChipView()
        {
            InitializeComponent();
        }

        private void DataGChips(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDBContext())
            {
                var chip = from ch in db.Chips select ch;
                DataGridChips.ItemsSource = chip.ToList();
            }
        }

    }
}
