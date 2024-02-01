﻿using Inventory_System.Pages;
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
        public ObservableCollection<Product> BestProducts { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            mainContentControl.Content = new Dashboard();

            pageDefaultBTN.Focus();

            BestProducts = new ObservableCollection<Product>
            {
                new Product { Position = 1, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 2, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 3, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 4, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 5, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 6, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 7, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 8, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 9, Name = "Product 1", Sales = 100000, Amount = 100 },
                new Product { Position = 10, Name = "Product 1", Sales = 100000, Amount = 100 },
            };

            DataContext = this;
        }

        private void ChangePage( ContentControl newPage)
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
    }
}