using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PetCare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }     

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            if (DAO.CarerDAO.checkLogin(txtUsername.Text, txtPassword.Password))
            {
                this.Hide();
                CRUD crud = new CRUD();
                crud.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password!!");
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
