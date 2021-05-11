namespace ProgrammingPattern
{

    public class EditCountryViewModel : ViewModelBase
    {
        private ModelMode _mode = ModelMode.New;
        private string _country_code_id = "";
        private string _name = "";

        public enum ModelMode
        {
            New,
            Edit
        }

        public ModelMode Mode
        {
            get { return _mode; }
            set
            {
                if (_mode == value) return;

                _mode = value;

                NotifyPropertyChanged("Mode");
            }
        }

        public string CountryCodeID
        {
            get { return _country_code_id; }
            set
            {
                if (_country_code_id == value) return;

                _country_code_id = value;

                NotifyPropertyChanged("CountryCodeID");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;

                _name = value;

                NotifyPropertyChanged("Name");
            }
        }

    } // end of viewmodel
}