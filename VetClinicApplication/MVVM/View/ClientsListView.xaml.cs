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
    /// Logika interakcji dla klasy ClientsListView.xaml
    /// </summary>
    public partial class ClientsListView : UserControl
    {
        public ClientsListView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// here we just adding posibility to add new person to database by button
        /// </summary>
        /// <param name="sender">sender is source of the the button</param>
        /// <param name="e"></param>
        private void Button_Click_Add_Client(object sender, RoutedEventArgs e)
        {
            using (var db= new AppDBContext())
            {
                var client = new Client();
                client.Name = ClientName.Text;
                client.Surname = ClientSurname.Text;
                client.Pesel = ClientPesel.Text;
                client.PhoneNr = ClientPhone.Text;

                db.Clients.Add(client);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// this method allows us to read rows from db table clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadDBClients(object sender, RoutedEventArgs e)
        {
            using (var db= new AppDBContext())
            {
                var client =from c in db.Clients select c;
                ClientDataGrid.ItemsSource = client.ToList();
            }
        }
    }
}
