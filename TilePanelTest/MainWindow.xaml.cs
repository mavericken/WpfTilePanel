using System.ComponentModel;
using System.Windows;

namespace TilePanelTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow(MainViewModel viewModel)
		{
			InitializeComponent();

			if (DesignerProperties.GetIsInDesignMode(this))
			{
				return;
			}
			DataContext = viewModel;
		}
	}
}
