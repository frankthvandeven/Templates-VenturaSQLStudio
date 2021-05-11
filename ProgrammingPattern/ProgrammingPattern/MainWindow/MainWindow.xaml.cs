using System;
using System.Data.SQLite;
using System.IO;
using System.Windows;
using ProgrammingPattern.ListCountry;
using VenturaSQL;

namespace ProgrammingPattern
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel { get; } = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();

            string db_folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");

            string connection_string = $@"Data Source={db_folder}\VanArsdel.db;FailIfMissing=True;";

            VenturaSqlConfig.DefaultConnector = new AdoConnector(SQLiteFactory.Instance, connection_string);
        }

        private void ButtonOrders_Click(object sender, RoutedEventArgs e)
        {
            ListOrderViewModel order_viewmodel = new ListOrderViewModel();

            ListOrderWindow window = new ListOrderWindow(order_viewmodel);
            window.Owner = this;
            window.ShowDialog();
        }

        private void ButtonCountryCodes_Click(object sender, RoutedEventArgs e)
        {
            ListCountryViewModel country_viewmodel = new ListCountryViewModel();
            country_viewmodel.Mode = ListCountryViewModel.ModelMode.ListDialog;

            ListCountryWindow window = new ListCountryWindow(country_viewmodel);
            window.Owner = this;
            window.ShowDialog();
        }
    }
}
