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
    /// Logika interakcji dla klasy ProceduresView.xaml
    /// </summary>
    public partial class ProceduresView : UserControl
    {
        public ProceduresView()
        {
            InitializeComponent();
        }

        private async void Button_Click_Add_Procedure(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDBContext())
            {
                var procedure = new MedProcedureList();
                procedure.MedProcName = ProcedureName.Text;
                procedure.Price = Convert.ToDecimal(ProcedurePrice.Text);
                

                await db.MedProceduresList.AddAsync(procedure);
                await db.SaveChangesAsync();
            }
        }

        private void ReadDBMedProcedures(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDBContext())
            {
                var medprocedure = from a in db.MedProceduresList select a;
                DataGridProcedures.ItemsSource = medprocedure.ToList();
            }
        }
    }
}
