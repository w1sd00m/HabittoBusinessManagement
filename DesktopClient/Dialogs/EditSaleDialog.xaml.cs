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
using System.Windows.Shapes;

namespace WisdomSoftware.HabittoBusinessManagement.DesktopClient.Dialogs
{
    /// <summary>
    /// Lógica interna para EditSaleDialog.xaml
    /// </summary>
    public partial class EditSaleDialog : Window
    {
        public EditSaleDialog()
        {
            InitializeComponent();
        }

        private void OnCbxPaymentMethodSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cbx_PaymentMethod.SelectedIndex >= 3)
            {
                Wpl_Discount.Visibility = Visibility.Collapsed;
                Wpl_Installments.Visibility = Visibility.Visible;
            }
            else
            {
                Wpl_Discount.Visibility = Visibility.Visible;
                Wpl_Installments.Visibility = Visibility.Collapsed;
            }
        }
    }
}
