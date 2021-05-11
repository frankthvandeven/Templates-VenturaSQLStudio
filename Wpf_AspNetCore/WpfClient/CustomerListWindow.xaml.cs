using System.Windows;
using System.Windows.Input;
using WpfClient.VenturaRecordsets;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for CustomerListWindow.xaml
    /// </summary>
    public partial class CustomerListWindow : Window
    {
        private CustomersListRecordset _rs;

        public CustomerListWindow()
        {
            InitializeComponent();

            this.Loaded += CustomerListWindow_Loaded;

            _rs = new CustomersListRecordset();

            dataGrid.ItemsSource = _rs;
        }

        private void CustomerListWindow_Loaded(object sender, RoutedEventArgs e)
        {

            //Action action = () =>
            //{
            //};
            //Application.Current.Dispatcher.Invoke(action);

        }

        private async void buttonLoad_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                mainPanel.IsEnabled = false;
                Cursor = Cursors.Wait;
                

                await _rs.ExecSqlAsync();
            }
            finally
            {
                Cursor = null;
                mainPanel.IsEnabled = true;
            }

        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
