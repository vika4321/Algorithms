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

namespace WpfHello
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Algorithms obj = new Algorithms();
			List<List<int>> SetArray = new List<List<int>>{
				new List<int> { 5, 7, 6},
				new List<int> { 1, 5, 6}
			};
			List<int> r = obj.spiralOrder(SetArray);
		}

		private void ok_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello " + userName.Text);
		}
	}
}
