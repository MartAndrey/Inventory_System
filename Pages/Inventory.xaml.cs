using Inventory_System.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Binding = System.Windows.Data.Binding;
using Brushes = System.Windows.Media.Brushes;
using ComboBox = System.Windows.Controls.ComboBox;

namespace Inventory_System.Pages
{
    /// <summary>
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : System.Windows.Controls.UserControl
    {
        public ObservableCollection<Product> Products { get; set; }

        public Inventory()
        {
            InitializeComponent();

            Products = new()
            {
                new () { Id = 1, Name = "Producto A", Amount = 15, Category = "Electrónicos", UnitPrice = 120.00f, PoundsPrice = 3.0f, KilosPrice = 1.4f,ArrobasPrice = 1.5f, BulkPrice = 10.0f },
                new () { Id = 2, Name = "Producto B", Amount = 20, Category = "Ropa", UnitPrice = 50.00f, PoundsPrice = 2.0f,KilosPrice =2.4f ,ArrobasPrice = 1.0f, BulkPrice = 8.0f },
                new () { Id = 3, Name = "Producto C", Amount = 25, Category = "Alimentos", UnitPrice = 8.00f, PoundsPrice = 1.5f,KilosPrice =2, ArrobasPrice = 0.8f, BulkPrice = 12.0f },
                new () { Id = 4, Name = "Producto D", Amount = 18, Category = "Electrodomésticos", UnitPrice = 180.00f, PoundsPrice = 4.5f, KilosPrice=23.4f, ArrobasPrice = 2.0f, BulkPrice = 15.0f },
                new () { Id = 5, Name = "Producto E", Amount = 12, Category = "Juguetes", UnitPrice = 12.00f, PoundsPrice = 1.2f,KilosPrice =23,  ArrobasPrice = 0.5f, BulkPrice = 8.0f },
                new () { Id = 6, Name = "Producto F", Amount = 30, Category = "Electrónicos", UnitPrice = 200, PoundsPrice = 6.0f, ArrobasPrice = 3.0f, BulkPrice = 25.0f },
                new () { Id = 7, Name = "Producto G", Amount = 22, Category = "Ropa", UnitPrice = 35f, PoundsPrice = 2.2f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
                new () { Id = 8, Name = "Producto H", Amount = 14, Category = "Alimentos", UnitPrice = 6f, PoundsPrice = 1.2f, ArrobasPrice = 0.6f, BulkPrice = 6.0f },
                new () { Id = 9, Name = "Producto I", Amount = 17, Category = "Electrodomésticos", UnitPrice = 160f, PoundsPrice = 3.8f, ArrobasPrice = 1.8f, BulkPrice = 18.0f },
                new () { Id = 10, Name = "Producto J", Amount = 28, Category = "Juguetes", UnitPrice = 18f, PoundsPrice = 1.8f, ArrobasPrice = 0.9f, BulkPrice = 12.0f },
                new () { Id = 11, Name = "Producto K", Amount = 19, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 12, Name = "Producto L", Amount = 16, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 13, Name = "Producto M", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8f },
                new () { Id = 14, Name = "Producto N", Amount = 13, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3f, ArrobasPrice = 1f, BulkPrice = 15f },
                new () { Id = 15, Name = "Producto O", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10f },
                new () { Id = 16, Name = "Producto P", Amount = 10, Category = "Electrónicos", UnitPrice = 120f, PoundsPrice = 2.5f, ArrobasPrice = 1f, BulkPrice = 12.0f },
                new () { Id = 17, Name = "Producto Q", Amount = 24, Category = "Ropa", UnitPrice = 35f, PoundsPrice = 3.0f, ArrobasPrice = 1.5f, BulkPrice = 15.0f },
                new () { Id = 18, Name = "Producto R", Amount = 16, Category = "Alimentos", UnitPrice = 6f, PoundsPrice = 1.2f, ArrobasPrice = 0.6f, BulkPrice = 8.0f },
                new () { Id = 19, Name = "Producto S", Amount = 14, Category = "Electrodomésticos", UnitPrice = 160f, PoundsPrice = 4.0f, ArrobasPrice = 2.0f, BulkPrice = 18.0f},
                new () { Id = 20, Name = "Producto T", Amount = 30, Category = "Juguetes", UnitPrice = 20f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 10.0f },
                new () { Id = 21, Name = "Producto U", Amount = 17, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 22, Name = "Producto V", Amount = 20, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 23, Name = "Producto W", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 24, Name = "Producto X", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15.0f },
                new () { Id = 25, Name = "Producto Y", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
                new () { Id = 26, Name = "Producto Z", Amount = 20, Category = "Electrónicos", UnitPrice = 120f, PoundsPrice = 3.5f, ArrobasPrice = 1.8f, BulkPrice = 12.0f },
                new () { Id = 27, Name = "Producto AA", Amount = 24, Category = "Ropa", UnitPrice = 35f, PoundsPrice = 3.0f, ArrobasPrice = 1.5f, BulkPrice = 15.0f },
                new () { Id = 28, Name = "Producto BB", Amount = 16, Category = "Alimentos", UnitPrice = 6f, PoundsPrice = 1.2f, ArrobasPrice = 0.6f, BulkPrice = 8.0f },
                new () { Id = 29, Name = "Producto CC", Amount = 14, Category = "Electrodomésticos", UnitPrice = 160f, PoundsPrice = 4.0f, ArrobasPrice = 2.0f, BulkPrice = 18.0f },
                new () { Id = 30, Name = "Producto DD", Amount = 30, Category = "Juguetes", UnitPrice = 20f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 10.0f },
                new () { Id = 31, Name = "Producto EE", Amount = 17, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 32, Name = "Producto FF", Amount = 20, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 33, Name = "Producto GG", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 34, Name = "Producto HH", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15.0f },
                new () { Id = 35, Name = "Producto II", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
                new () { Id = 36, Name = "Producto JJ", Amount = 19, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 37, Name = "Producto KK", Amount = 16, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 38, Name = "Producto LL", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 39, Name = "Producto MM", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15.0f }
            };

            DataContext = this;

            search.TextChanged += FilterData;
        }

        private void ShowAddProductWindow_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow window = new ProductWindow();
            window.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedItem != null && dataGrid != null)
            {
                string selectedValue = (comboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();

                DataGridTextColumn priceColumn = dataGrid.Columns.FirstOrDefault(c => c.Header.ToString() == "Precio") as DataGridTextColumn;

                if (priceColumn != null)
                {
                    switch (selectedValue)
                    {
                        case "Precio Libra":
                            priceColumn.Binding = new Binding("PoundsPrice");
                            break;
                        case "Precio Kilo":
                            priceColumn.Binding = new Binding("KilosPrice");
                            break;
                        case "Precio Arroba":
                            priceColumn.Binding = new Binding("ArrobasPrice");
                            break;
                        case "Precio Bulto":
                            priceColumn.Binding = new Binding("BulkPrice");
                            break;
                        default:
                            priceColumn.Binding = new Binding("UnitPrice");
                            break;
                    }
                }
            }
        }

        private void SearchGotFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == "Buscar Producto")
                search.Text = "";
        }

        private void SearchLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search.Text))
                search.Text = "Buscar Producto";
        }

        private void FilterData(object sender, RoutedEventArgs e)
        {

            if (search.Text == "Buscar Producto") return;

            ICollectionView view = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            view.Filter = item =>
            {
                if (string.IsNullOrEmpty(search.Text))
                    return true;

                foreach (var prop in typeof(Product).GetProperties())
                {
                    var value = prop.GetValue(item)?.ToString();
                    if (value != null && value.IndexOf(search.Text, StringComparison.OrdinalIgnoreCase) != -1)
                        return true;
                }
                return false;
            };
        }
    }
}
