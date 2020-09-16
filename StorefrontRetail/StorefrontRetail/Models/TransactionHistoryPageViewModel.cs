using System.Collections.ObjectModel;
using StorefrontRetail.ViewModels.Base;

namespace StorefrontRetail.Models
{
    public class TransactionHistoryPageViewModel: BaseViewModel
    {
        private bool showTransactionNumberColumn;
        public bool ShowTransactionNumberColumn
        {
            get => showTransactionNumberColumn;
            set => SetProperty(ref showTransactionNumberColumn, value);
        }
        
        private bool showDescriptionColumn;
        public bool ShowDescriptionColumn
        {
            get => showDescriptionColumn;
            set => SetProperty(ref showDescriptionColumn, value);
        }
        
        private bool showQuantityColumn;
        public bool ShowQuantityColumn
        {
            get => showQuantityColumn;
            set => SetProperty(ref showQuantityColumn, value);
        }
        
        
        private bool showDateRaisedColumn;
        public bool ShowDateRaisedColumn
        {
            get => showDateRaisedColumn;
            set => SetProperty(ref showDateRaisedColumn, value);
        }
        
        private bool showExtensionColumn;
        public bool ShowExtensionColumn
        {
            get => showExtensionColumn;
            set => SetProperty(ref showExtensionColumn, value);
        }
        
        private ObservableCollection<History> histories;
        public ObservableCollection<History> Histories
        {
            get => histories;
            set => SetProperty(ref histories, value);
        }
    }
}