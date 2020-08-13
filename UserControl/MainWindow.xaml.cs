using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UserControla
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Osoba> osobe = new ObservableCollection<Osoba>();
		public MainWindow()
		{
			InitializeComponent();
			uc.DataContext = new Osoba();
			List<string> test = new List<string>();
			test.Add("Jen");
			test.Add("Dva");
			test.Add("Tri");

			ls.ItemsSource = test;

			Osoba o = new Osoba();
			o.Ime = "Pera";
			o.Prezime = "Peric";
			o.Nesto.Add("Jen");
			o.Nesto.Add("Dva");
			o.Nesto.Add("Tri");
			osobe.Add(o);
			dg.ItemsSource = osobe;

		}
	}

	public class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public List<string> Nesto { get; set; } = new List<string>();
	}
}
