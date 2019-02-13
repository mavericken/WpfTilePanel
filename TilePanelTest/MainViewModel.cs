using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace TilePanelTest
{
	public class MainViewModel : ObservableObject
	{
		private ObservableCollection<TestClass> _testCollection;

		public MainViewModel()
		{
			List<TestClass> list = new List<TestClass>();
			list.Add(new TestClass(1000, new SolidColorBrush(Colors.Aqua)));
			list.Add(new TestClass(1001, new SolidColorBrush(Colors.BlueViolet)));
			list.Add(new TestClass(1002, new SolidColorBrush(Colors.CadetBlue)));
			list.Add(new TestClass(1003, new SolidColorBrush(Colors.DarkBlue)));
			list.Add(new TestClass(1004, new SolidColorBrush(Colors.DarkGoldenrod)));
			list.Add(new TestClass(1005, new SolidColorBrush(Colors.Firebrick)));
			list.Add(new TestClass(1006, new SolidColorBrush(Colors.Gainsboro)));
			list.Add(new TestClass(1007, new SolidColorBrush(Colors.HotPink)));
			list.Add(new TestClass(1008, new SolidColorBrush(Colors.IndianRed)));
			list.Add(new TestClass(1009, new SolidColorBrush(Colors.Indigo)));
			list.Add(new TestClass(1010, new SolidColorBrush(Colors.Khaki)));
			list.Add(new TestClass(1011, new SolidColorBrush(Colors.LawnGreen)));
			list.Add(new TestClass(1012, new SolidColorBrush(Colors.Magenta)));
			list.Add(new TestClass(1013, new SolidColorBrush(Colors.Navy)));
			list.Add(new TestClass(1014, new SolidColorBrush(Colors.Olive)));
			list.Add(new TestClass(1015, new SolidColorBrush(Colors.PaleGoldenrod)));
			list.Add(new TestClass(1016, new SolidColorBrush(Colors.PaleGreen)));
			list.Add(new TestClass(1017, new SolidColorBrush(Colors.Red)));
			list.Add(new TestClass(1018, new SolidColorBrush(Colors.SaddleBrown)));
			list.Add(new TestClass(1019, new SolidColorBrush(Colors.Tan)));
			TestCollection = new ObservableCollection<TestClass>(list);
		}

		public ObservableCollection<TestClass> TestCollection
		{
			get { return _testCollection; }
			set
			{
				_testCollection = value;
				RaisePropertyChanged(() => TestCollection);
			}
		}
	}
}
