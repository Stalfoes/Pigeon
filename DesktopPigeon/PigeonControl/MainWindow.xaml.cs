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

namespace PigeonControl {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		/**
		 * <summary>
		 * Handles the event for when the window is no longer on top.
		 * </summary>
		 * <param name="sender">The sender of the event.</param>
		 * <param name="e">The event arguments.</param>
		 */
		private void Window_Deactivated(object sender, EventArgs e) {
			Window window = (Window) sender;
			window.Topmost = true;
		}
	}
}
