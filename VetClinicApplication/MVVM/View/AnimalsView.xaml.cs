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
    /// Logika interakcji dla klasy AnimalsView.xaml
    /// </summary>
    public partial class AnimalsView : UserControl
    {
        public AnimalsView()
        {
            InitializeComponent();
        }

        private async void Button_Click_Add_Animal(object sender, RoutedEventArgs e)
        {

            using (var db = new AppDBContext())
            {
                var animal = new Animal();
                animal.Name = AnimalName.Text;
                animal.Species = AnimalSpecies.Text;
                animal.ClientID = Convert.ToInt32(AnimalClientID.Text);


                await db.Animals.AddAsync(animal);
                await db.SaveChangesAsync();
            }
        }


        private void ReadDBAnimals(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDBContext())
            {
                var animal = from a in db.Animals select a;
                AnimalDataGrid.ItemsSource = animal.ToList();
            }
        }
    }
}
