using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace TilePanelTest
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private MainWindow _mainWindow;
		private MainViewModel _mainWindowViewModel;

		private void ApplicationStartup(object sender, StartupEventArgs e)
		{
			// Set it as the DataContext for Binding and Commanding
			_mainWindowViewModel = new MainViewModel();
			_mainWindow = new MainWindow(_mainWindowViewModel);
			_mainWindow.Show();
		}
	}
}
