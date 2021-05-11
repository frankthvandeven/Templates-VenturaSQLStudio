using System.Windows;
using System.Windows.Input;
using ProgrammingPattern.EditOrder;
using ProgrammingPattern.VenturaRecordsets;

namespace ProgrammingPattern
{
    public partial class ListOrderWindow : Window
    {
        public ListOrderViewModel ViewModel { get; }

        public ListOrderWindow(ListOrderViewModel view_model)
        {
            ViewModel = view_model;

            InitializeComponent();

            Loaded += ListOrderWindow_Loaded;
        }

        private async void ListOrderWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.OrdersRS.ExecSqlAsync();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            EditOrder();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            EditOrder();
        }

        private void EditOrder()
        {
            MostRecentOrdersRecord record = dataGrid.SelectedItem as MostRecentOrdersRecord;

            if (record == null)
                return;

            EditOrderViewModel edit_model = new EditOrderViewModel
            {
                Mode = EditOrderViewModel.ModelMode.Edit,
                OrderID = record.OrderID
            };

            EditOrderWindow window = new EditOrderWindow(edit_model);
            window.Owner = this;
            window.ShowDialog();

            if (window.DialogResult == false)
                return;
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            EditOrderViewModel edit_model = new EditOrderViewModel
            {
                Mode = EditOrderViewModel.ModelMode.New
            };

            EditOrderWindow window = new EditOrderWindow(edit_model);
            window.Owner = this;
            window.ShowDialog();

            if (window.DialogResult == false)
                return;

        }

    }
}
