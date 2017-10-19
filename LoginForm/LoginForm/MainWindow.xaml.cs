using LoginForm.DbContext;

using PagedList;
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


namespace LoginForm
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		myConnectionString dbContext = new myConnectionString();
		public MainWindow()
		{
			InitializeComponent();
			//this.DataContext = new dbContext.MyDbContext();
			this.DataContext = new DbContext.myConnectionString();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			txtUsername.Clear();
			txtPassword.Clear();
		}

		

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{

		

			Carer query = (from c in dbContext.Carers
						   where c.CarerID.Equals(txtUsername.Text) && c.Password.Equals(txtPassword.Password)
						   select c).FirstOrDefault();
						   

			if (query == null)
				MessageBox.Show("COn di sep!!");
			else
			MessageBox.Show("Con di "+query.CarerName);
			
						
		}

		
	}
}
