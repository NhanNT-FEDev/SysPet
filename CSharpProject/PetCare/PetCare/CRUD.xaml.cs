using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PetCare
{
    /// <summary>
    /// Interaction logic for CRUD.xaml
    /// </summary>
    public partial class CRUD : Window
    {
        DBEntities context = new DBEntities();
        public CRUD()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
                from p in context.PetDetails
                join s in context.Species on p.Species equals s.SpeciesID
                join o in context.Owners on p.OwnerID equals o.OwnerID
                join b in context.Breeds on p.Breed equals b.BreedID
                where p.Status == true
                select new
                {
                    p.PetID, p.PetName, o.OwnerName, s.SpeciesName, b.BreedName, p.Gender, p.DayOfBirth, p.InDate, p.MedicalRecord
                };
            dataGrid.ItemsSource = query.ToList();
        }
    }
}
