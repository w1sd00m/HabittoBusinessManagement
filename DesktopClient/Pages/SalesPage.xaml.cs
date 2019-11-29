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
using WisdomSoftware.HabittoBusinessManagement.DesktopClient.Dialogs;

namespace WisdomSoftware.HabittoBusinessManagement.DesktopClient.Pages
{
    /// <summary>
    /// Interação lógica para SalesPage.xam
    /// </summary>
    public partial class SalesPage : UserControl
    {
        public SalesPage()
        {
            InitializeComponent();
        }

        private void RegisterNewSale(object sender, RoutedEventArgs e)
        {
            var dialog = new EditSaleDialog();

            if (dialog.ShowDialog() == true)
            {

            }
        }
    }
}
