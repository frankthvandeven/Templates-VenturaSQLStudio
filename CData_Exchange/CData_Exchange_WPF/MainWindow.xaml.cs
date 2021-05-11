using System.Windows;
using Ventura;
using System.Data.CData.Exchange;
using System.IO;
using WpfApp1.VenturaRecordsets;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ContactsRecordset _rs = new ContactsRecordset();

        public MainWindow()
        {
            InitializeComponent();

            string user = "xxxxxxx@venturatools.com";
            string password = File.ReadAllText(@"C:\Active\e_password.txt");
            string connection_string = $"auth scheme=BASIC;password={password};platform=Exchange_Online;server=https://outlook.office365.com/EWS/Exchange.asmx;user={user}";

            VenturaConfig.DefaultConnector = new AdoConnector(ExchangeProviderFactory.Instance, connection_string);

            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _rs.ExecSqlAsync();

            dataGrid.ItemsSource = _rs;

        }
    }
}
