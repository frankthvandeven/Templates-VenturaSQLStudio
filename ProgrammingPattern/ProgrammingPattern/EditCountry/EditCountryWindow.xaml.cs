using System;
using System.Windows;
using ProgrammingPattern.VenturaAutoCreate;

namespace ProgrammingPattern
{
    public partial class EditCountryWindow : Window
    {
        public EditCountryViewModel ViewModel { get; }

        public EditCountryWindow(EditCountryViewModel view_model)
        {
            ViewModel = view_model;

            InitializeComponent();

            if (ViewModel.Mode == EditCountryViewModel.ModelMode.Edit)
            {

                PriKey_CountryCodes_Recordset prikey = new PriKey_CountryCodes_Recordset();

                prikey.ExecSql(ViewModel.CountryCodeID);

                if (prikey.RecordCount != 1)
                    throw new Exception($"Country {ViewModel.CountryCodeID} not found.");

                ViewModel.CountryCodeID = prikey.CountryCodeID;
                ViewModel.Name = prikey.Name;

                textblockTitle.Text = $"Edit country {prikey.CountryCodeID}";
                textboxID.IsReadOnly = true; // you cannot edit a primary key code
            }
            else // new
            {
                ViewModel.CountryCodeID = "";
                ViewModel.Name = "";

                textblockTitle.Text = "New country";
            }

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            PriKey_CountryCodes_Recordset prikey = new PriKey_CountryCodes_Recordset();
            prikey.ExecSql(ViewModel.CountryCodeID);

            if (ViewModel.Mode == EditCountryViewModel.ModelMode.New)
            {
                ViewModel.CountryCodeID = ViewModel.CountryCodeID.ToUpper().Trim();

                if( ViewModel.CountryCodeID.Length != 2)
                {
                    MessageBox.Show($"County code ID must be 2 upper-case characters.");
                    return;
                }

                if (prikey.RecordCount != 0)
                {
                    MessageBox.Show($"County code {ViewModel.CountryCodeID} already exists.");
                    return;
                }

                prikey.Append();
                prikey.CountryCodeID = ViewModel.CountryCodeID;
                prikey.Name = ViewModel.Name;
            }
            else // existing
            {
                if (prikey.RecordCount == 0)
                    throw new Exception($"Country code {ViewModel.CountryCodeID} doesn't exist.");

                prikey.Name = ViewModel.Name;
            }

            prikey.SaveChanges();
            DialogResult = true;
        }

    }
}
