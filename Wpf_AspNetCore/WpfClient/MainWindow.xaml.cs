using System.Windows;
using VenturaSQL;
using System.Data.SqlClient;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            radioAspNetCore.IsChecked = true;
            radioCustomerList.IsChecked = true;
        }

        private void radioAspNetCore_Checked(object sender, RoutedEventArgs e)
        {
            string url = "http://localhost:64548/api/venturasql"; // ASPNETCORE
            VenturaSqlConfig.DefaultConnector = new HttpConnector("DefaultConnector", url);
            tbInfo.Text = url;
        }

        private void radioAdoDirect_Checked(object sender, RoutedEventArgs e)
        {
            string connection_string = "Server=tcp:sysdev-sqlserver-public.database.windows.net,1433;Initial Catalog=AdventureWorks2017;Persist Security Info=False;User ID=reader;Password=easypassword9!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            VenturaSqlConfig.DefaultConnector = new AdoConnector(SqlClientFactory.Instance, connection_string);
            tbInfo.Text = connection_string;
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonRun_Click(object sender, RoutedEventArgs e)
        {
            if (radioCustomerList.IsChecked == true)
            {
                CustomerListWindow window = new CustomerListWindow();
                window.ShowDialog();
            }

        }
    }
}
