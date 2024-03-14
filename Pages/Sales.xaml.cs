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

namespace Inventory_System.Pages
{
    /// <summary>
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : System.Windows.Controls.UserControl
    {
        public ObservableCollection<Product> Products { get; set; }

        public Sales()
        {
            InitializeComponent();

            Products = new()
            {
                new() { Id = 1, Name = "Producto A", Amount = 15, Category = "Electrónicos", UnitPrice = 120.00f, PoundsPrice = 3.0f, ArrobasPrice = 1.5f, BulkPrice = 10.0f },
                new () { Id = 2, Name = "Producto B", Amount = 20, Category = "Ropa", UnitPrice = 50.00f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 8.0f },
                new () { Id = 3, Name = "Producto C", Amount = 25, Category = "Alimentos", UnitPrice = 8.00f, PoundsPrice = 1.5f, ArrobasPrice = 0.8f, BulkPrice = 12.0f },
                new () { Id = 4, Name = "Producto D", Amount = 18, Category = "Electrodomésticos", UnitPrice = 180.00f, PoundsPrice = 4.5f, ArrobasPrice = 2.0f, BulkPrice = 1 },
                new () { Id = 5, Name = "Producto E", Amount = 12, Category = "Juguetes", UnitPrice = 12.00f, PoundsPrice = 1.2f, ArrobasPrice = 0.5f, BulkPrice = 8.0f },
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
                new () { Id = 19, Name = "Producto S", Amount = 14, Category = "Electrodomésticos", UnitPrice = 160f, PoundsPrice = 4.0f, ArrobasPrice = 2.0f, BulkPrice = 18f },
                new () { Id = 20, Name = "Producto T", Amount = 30, Category = "Juguetes", UnitPrice = 20f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 10.0f },
                new () { Id = 21, Name = "Producto U", Amount = 17, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 22, Name = "Producto V", Amount = 20, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 23, Name = "Producto W", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 24, Name = "Producto X", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15.2f },
                new () { Id = 25, Name = "Producto Y", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
                new () { Id = 26, Name = "Producto Z", Amount = 20, Category = "Electrónicos", UnitPrice = 120f, PoundsPrice = 3.5f, ArrobasPrice = 1.8f, BulkPrice = 12.0f },
                new () { Id = 27, Name = "Producto AA", Amount = 24, Category = "Ropa", UnitPrice = 35f, PoundsPrice = 3.0f, ArrobasPrice = 1.5f, BulkPrice = 15.0f },
                new () { Id = 28, Name = "Producto BB", Amount = 16, Category = "Alimentos", UnitPrice = 6f, PoundsPrice = 1.2f, ArrobasPrice = 0.6f, BulkPrice = 8.0f },
                new () { Id = 29, Name = "Producto CC", Amount = 14, Category = "Electrodomésticos", UnitPrice = 160f, PoundsPrice = 4.0f, ArrobasPrice = 2.0f, BulkPrice = 18f },
                new () { Id = 30, Name = "Producto DD", Amount = 30, Category = "Juguetes", UnitPrice = 20f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 10.0f },
                new () { Id = 31, Name = "Producto EE", Amount = 17, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 32, Name = "Producto FF", Amount = 20, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 33, Name = "Producto GG", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 34, Name = "Producto HH", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 150 },
                new () { Id = 35, Name = "Producto II", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
                new () { Id = 36, Name = "Producto JJ", Amount = 19, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 37, Name = "Producto KK", Amount = 16, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 38, Name = "Producto LL", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 39, Name = "Producto MM", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15f },
                new () { Id = 40, Name = "Producto NN", Amount = 30, Category = "Juguetes", UnitPrice = 20f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 10.0f },
                new () { Id = 41, Name = "Producto OO", Amount = 17, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 42, Name = "Producto PP", Amount = 20, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 43, Name = "Producto QQ", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 44, Name = "Producto RR", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15 },
                new () { Id = 45, Name = "Producto SS", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
                new () { Id = 46, Name = "Producto TT", Amount = 19, Category = "Electrónicos", UnitPrice = 180f, PoundsPrice = 4.5f, ArrobasPrice = 2.5f, BulkPrice = 22.0f },
                new () { Id = 47, Name = "Producto UU", Amount = 16, Category = "Ropa", UnitPrice = 40f, PoundsPrice = 2.0f, ArrobasPrice = 1.0f, BulkPrice = 9.0f },
                new () { Id = 48, Name = "Producto VV", Amount = 23, Category = "Alimentos", UnitPrice = 7f, PoundsPrice = 1.5f, ArrobasPrice = 0.7f, BulkPrice = 8.0f },
                new () { Id = 49, Name = "Producto WW", Amount = 14, Category = "Electrodomésticos", UnitPrice = 150f, PoundsPrice = 3.0f, ArrobasPrice = 1.0f, BulkPrice = 15f },
                new () { Id = 50, Name = "Producto XX", Amount = 18, Category = "Juguetes", UnitPrice = 25f, PoundsPrice = 2.5f, ArrobasPrice = 1.2f, BulkPrice = 10.0f },
            };

            DataContext = this;
        }
    }
}
