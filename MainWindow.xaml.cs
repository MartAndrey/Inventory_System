using Inventory_System.Pages;
using System.Collections.ObjectModel;
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

namespace Inventory_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mainContentControl.Content = new Dashboard();

            pageDefaultBTN.Focus();
        }

        private void ChangePage(ContentControl newPage)
        {
            mainContentControl.Content = newPage;
        }

        private void ButtonDashboard(object sender, RoutedEventArgs e)
        {
            ChangePage(new Dashboard());
        }

        private void ButtonInventory(object sender, RoutedEventArgs e)
        {
            ChangePage(new Inventory());
        }

        private void ButtonSales(object sender, RoutedEventArgs e)
        {
            ChangePage(new Sales());
        }
    }
}