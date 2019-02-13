using System;
using System.Windows.Media;

namespace TilePanelTest
{
	public class TestClass : ObservableObject
	{
		private int _number;
		private Brush _displayBrush;
		private int _displayWidth;
		private int _displayHeight;

		private static readonly Random _random = new Random(DateTime.Now.Millisecond);

		public TestClass(int number, Brush brush)
		{
			Number = number;
			_displayBrush = brush;
			_displayWidth = 50 + _random.Next(200);
			_displayHeight = 50 + _random.Next(200);
		}

		public int Number
		{
			get { return _number; }
			set
			{
				_number = value;
				RaisePropertyChanged(() => Number);
			}
		}

		public Brush DisplayBrush
		{
			get { return _displayBrush; }
			set
			{
				_displayBrush = value;
				RaisePropertyChanged(() => DisplayBrush);
			}
		}

		public int DisplayWidth
		{
			get { return _displayWidth; }
			set
			{
				_displayWidth = value;
				RaisePropertyChanged(() => DisplayWidth);
			}
		}

		public int DisplayHeight
		{
			get { return _displayHeight; }
			set
			{
				_displayHeight = value;
				RaisePropertyChanged(() => DisplayHeight);
			}
		}
	}
}
