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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : System.Windows.Controls.UserControl
    {
        public ObservableCollection<BestProduct> BestProducts { get; set; }

        public Dashboard()
        {

            InitializeComponent();

            BestProducts = new ObservableCollection<BestProduct>
            {
                new BestProduct { Position = 1, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 2, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 3, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 4, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 5, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 6, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 7, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 8, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 9, Name = "Product 1", Sales = 100000, Amount = 100 },
                new BestProduct { Position = 10, Name = "Product 1", Sales = 100000, Amount = 100 },
            };

            DataContext = this;
        }
    }
}
