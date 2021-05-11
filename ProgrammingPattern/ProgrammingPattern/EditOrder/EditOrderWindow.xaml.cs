using System;
using System.Windows;
using ProgrammingPattern.EditOrder;
using ProgrammingPattern.ListCountry;
using ProgrammingPattern.VenturaAutoCreate;

namespace ProgrammingPattern
{
    public partial class EditOrderWindow : Window
    {
        public EditOrderViewModel ViewModel { get; }

        public EditOrderWindow(EditOrderViewModel view_model)
        {
            ViewModel = view_model;

            InitializeComponent();

            if (ViewModel.Mode == EditOrderViewModel.ModelMode.Edit)
            {
                PriKey_Orders_Recordset prikey = new PriKey_Orders_Recordset();

                prikey.ExecSql(ViewModel.OrderID);

                if (prikey.RecordCount != 1)
                    throw new Exception($"Order {ViewModel.OrderID} not found.");

                ViewModel.CustomerID = prikey.CustomerID;
                ViewModel.OrderDate = prikey.OrderDate.Substring(0, 10); // cut off the time part
                ViewModel.ShipAddress = prikey.ShipAddress;
                ViewModel.ShipCity = prikey.ShipCity;
                ViewModel.ShipPostalCode = prikey.ShipPostalCode;
                ViewModel.ShipCountryCode = prikey.ShipCountryCode;

                textblockTitle.Text = $"Edit order {prikey.OrderID}";

            }
            else // new
            {
                ViewModel.OrderID = 0;
                ViewModel.CustomerID = 117501458387;
                ViewModel.OrderDate = DateTime.Now.ToString("yyyyMMdd");
                ViewModel.ShipAddress = "";
                ViewModel.ShipCity = "";
                ViewModel.ShipPostalCode = "";
                ViewModel.ShipCountryCode = "US";

                textblockTitle.Text = "New order";
            }

            UpdateShipCountryInfo();

            Loaded += EditOrderWindow_Loaded;
        }

        private void EditOrderWindow_Loaded(object sender, RoutedEventArgs e)
        {
            textboxOrderNumber.Focus();
        }

        private void TextBoxShipCountryCode_LostFocus(object sender, RoutedEventArgs e)
        {
            ViewModel.ShipCountryCode = ViewModel.ShipCountryCode.Trim().ToUpper();

            UpdateShipCountryInfo();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Saving an order is not implemented.\n\nThe template explains the programming pattern with the 'CountyCodes' table.");
        }

        private void UpdateShipCountryInfo()
        {
            string country_code = ViewModel.ShipCountryCode;

            if (country_code == "")
            {
                textblockShipCountryInfo.Text = "";
                return;
            }

            PriKey_CountryCodes_Recordset country = new PriKey_CountryCodes_Recordset();

            country.ExecSql(country_code);

            if (country.RecordCount == 0)
                textblockShipCountryInfo.Text = "Unknown country code";
            else
                textblockShipCountryInfo.Text = country.Name;

        }

        private void ButtonLookupCountryCode_Click(object sender, RoutedEventArgs e)
        {
            // Initialize the viewmodel for the country list window.
            ListCountryViewModel list_model = new ListCountryViewModel
            {
                Mode = ListCountryViewModel.ModelMode.LookupDialog, // "LookupDialog" means that the [Select] button will be displayed.
                Input_CountryCodeID = ViewModel.ShipCountryCode
            };

            ListCountryWindow window = new ListCountryWindow(list_model);
            window.Owner = this;
            window.ShowDialog();

            if (window.DialogResult == false)
                return;

            ViewModel.ShipCountryCode = list_model.Output_CountryCodeID;
            UpdateShipCountryInfo();
        }
       

    }
}
