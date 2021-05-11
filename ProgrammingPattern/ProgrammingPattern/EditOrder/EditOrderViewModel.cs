namespace ProgrammingPattern.EditOrder
{
    public class EditOrderViewModel : ViewModelBase
    {
        public enum ModelMode
        {
            New,
            Edit
        }

        private ModelMode _mode = ModelMode.New;
        private long _order_id = 0;
        private long _customer_id = 0;
        private string _order_date = "";
        private string _ship_address = "";
        private string _ship_city = "";
        private string _ship_postalcode = "";
        private string _ship_countrycode = "";

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

        public long OrderID
        {
            get { return _order_id; }
            set
            {
                if (_order_id == value) return;

                _order_id = value;

                NotifyPropertyChanged("OrderID");
            }
        }

        public long CustomerID
        {
            get { return _customer_id; }
            set
            {
                if (_customer_id == value) return;

                _customer_id = value;

                NotifyPropertyChanged("CustomerID");
            }
        }

        public string OrderDate
        {
            get { return _order_date; }
            set
            {
                if (_order_date == value) return;

                _order_date = value;

                NotifyPropertyChanged("OrderDate");
            }
        }


        public string ShipAddress
        {
            get { return _ship_address; }
            set
            {
                if (_ship_address == value) return;

                _ship_address = value;

                NotifyPropertyChanged("ShipAddress");
            }
        }

        public string ShipCity
        {
            get { return _ship_city; }
            set
            {
                if (_ship_city == value) return;

                _ship_city = value;

                NotifyPropertyChanged("ShipCity");
            }
        }

        public string ShipPostalCode
        {
            get { return _ship_postalcode; }
            set
            {
                if (_ship_postalcode == value) return;

                _ship_postalcode = value;

                NotifyPropertyChanged("ShipPostalCode");
            }
        }

        public string ShipCountryCode
        {
            get { return _ship_countrycode; }
            set
            {
                if (_ship_countrycode == value) return;

                _ship_countrycode = value;

                NotifyPropertyChanged("ShipCountryCode");
            }
        }

    } // end of viewmodel
}
