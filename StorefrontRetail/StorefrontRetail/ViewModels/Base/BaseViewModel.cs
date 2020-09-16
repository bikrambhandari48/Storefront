using System.Threading.Tasks;


namespace StorefrontRetail.ViewModels.Base
{
    public class BaseViewModel : ExtendedBindableObject
    {
        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        private string title = string.Empty;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public virtual Task InitialiseDataAsync(object navigationData)
        {
            return Task.CompletedTask;
        }
    }
}
