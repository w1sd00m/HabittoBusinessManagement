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
using WisdomSoftware.HabittoBusinessManagement.DesktopClient.Dialogs;

namespace WisdomSoftware.HabittoBusinessManagement.DesktopClient.Pages
{
    public partial class ProductsPage : UserControl
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void RegisterNewProduct(object sender, RoutedEventArgs e)
        {
            var dialog = new EditProductDialog { Title = "Cadastrar Novo Produto" };
            dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                Console.WriteLine("Cadastrando novo produto...");
            }
        }
    }
}
