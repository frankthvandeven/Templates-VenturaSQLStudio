using ProgrammingPattern.VenturaRecordsets;

namespace ProgrammingPattern
{
    public class ListOrderViewModel : ViewModelBase
    {
        public MostRecentOrdersRecordset OrdersRS { get; } = new MostRecentOrdersRecordset();

    } // end of viewmodel
}
