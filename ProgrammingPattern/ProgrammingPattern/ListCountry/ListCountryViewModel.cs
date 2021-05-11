using System.Windows;
using ProgrammingPattern.VenturaAutoCreate;

namespace ProgrammingPattern.ListCountry
{

    public class ListCountryViewModel : ViewModelBase
    {
        public enum ModelMode
        {
            ListDialog,
            LookupDialog
        }

        private ModelMode _mode = ModelMode.ListDialog;

        public ModelMode Mode
        {
            get { return _mode; }
            set
            {
                if (_mode == value)
                    return;

                _mode = value;

                NotifyPropertyChanged("Mode");
                NotifyPropertyChanged("SelectButtonVisibility");
            }
        }

        public Visibility SelectButtonVisibility
        {
            get
            {
                if (Mode == ModelMode.LookupDialog)
                    return Visibility.Visible;

                return Visibility.Collapsed;
            }
        }

        public string Input_CountryCodeID { get; set; } = null;

        public string Output_CountryCodeID { get; set; } = null;

        public GetAll_CountryCodes_Recordset CountriesRS { get; } = new GetAll_CountryCodes_Recordset();

    } // end of viewmodel
}
