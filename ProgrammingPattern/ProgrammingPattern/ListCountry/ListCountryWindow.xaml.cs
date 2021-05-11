using System.Windows;
using System.Windows.Input;
using ProgrammingPattern.ListCountry;
using ProgrammingPattern.VenturaAutoCreate;

namespace ProgrammingPattern
{
    /// <summary>
    /// Interaction logic for Countries.xaml
    /// </summary>
    public partial class ListCountryWindow : Window
    {
        public ListCountryViewModel ViewModel { get; }

        public ListCountryWindow(ListCountryViewModel view_model)
        {
            ViewModel = view_model;

            InitializeComponent();

            //ViewModel.Mode 
            ViewModel.CountriesRS.ExecSql();

            GetAll_CountryCodes_Record record = ViewModel.CountriesRS.Find(a => a.CountryCodeID == ViewModel.Input_CountryCodeID);

            if (record != null)
                dataGrid.SelectedItem = record; // werkt nog niet

            Loaded += CountriesWindow_Loaded;
        }

        private void CountriesWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // This is a trick to get the DataGrid's selected row highlight to show.
            int index = dataGrid.SelectedIndex;
            dataGrid.SelectedIndex = -1;
            dataGrid.SelectedIndex = index;

            if (dataGrid.SelectedItem != null)
                dataGrid.ScrollIntoView(dataGrid.SelectedItem);
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ViewModel.Mode == ListCountryViewModel.ModelMode.LookupDialog)
                DoLookupShippingCountryCode();
        }

        private void ButtonSelect_Click(object sender, RoutedEventArgs e)
        {
            DoLookupShippingCountryCode();
        }

        private void DoLookupShippingCountryCode()
        {
            GetAll_CountryCodes_Record record = dataGrid.SelectedItem as GetAll_CountryCodes_Record;

            if (record == null)
                return;

            ViewModel.Output_CountryCodeID = record.CountryCodeID;

            DialogResult = true;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            GetAll_CountryCodes_Record selected_record = dataGrid.SelectedItem as GetAll_CountryCodes_Record;

            if (selected_record == null)
                return;

            EditCountryViewModel edit_model = new EditCountryViewModel
            {
                Mode = EditCountryViewModel.ModelMode.Edit,
                CountryCodeID = selected_record.CountryCodeID
            };

            EditCountryWindow window = new EditCountryWindow(edit_model);
            window.Owner = this;
            window.ShowDialog();

            if (window.DialogResult == false)
                return;

            // Refresh the country name is the DataGrid.
            selected_record.Name = edit_model.Name;
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            EditCountryViewModel edit_model = new EditCountryViewModel
            {
                Mode = EditCountryViewModel.ModelMode.New
            };

            EditCountryWindow window = new EditCountryWindow(edit_model);
            window.Owner = this;
            window.ShowDialog();

            if (window.DialogResult == false)
                return;

            // Add the new country code to the DataGrid. This is just to give visual feedback to
            // the user. The changes to the recordset will not be send to the database by calling SaveChanges()
            var grid_record = ViewModel.CountriesRS.NewRecord();

            grid_record.CountryCodeID = edit_model.CountryCodeID;
            grid_record.Name = edit_model.Name;

            ViewModel.CountriesRS.Append(grid_record);

            dataGrid.SelectedItem = grid_record;
            dataGrid.ScrollIntoView(grid_record);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            // The delete code is not complete, as you would have to forbid deleting a country code when
            // that code is referenced in another table.

            var selected_record = dataGrid.SelectedItem as GetAll_CountryCodes_Record;

            if (selected_record == null)
                return;

            var rs = ViewModel.CountriesRS;

            rs.Delete(selected_record);

            // Make sure all appends (INSERT) and column edits (UPDATE) are forgotten.
            rs.ResetAllToUnmodifiedExistingExcept(VenturaSQL.DataRecordStatus.ExistingDelete);

            rs.SaveChanges();



        }
    }
}
