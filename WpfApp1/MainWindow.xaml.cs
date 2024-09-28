using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void ChangeBackgroundColor(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var color = (string)menuItem.Tag;
            menu.Background = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFromString(color);
            row.Background = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFromString(color);
        }

        private void ShowDeveloperInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Ульяна Ковалёва");
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowStatusInfo(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var statusInfo = (string)menuItem.ToolTip;
            statusTextBlock.Text = statusInfo;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}