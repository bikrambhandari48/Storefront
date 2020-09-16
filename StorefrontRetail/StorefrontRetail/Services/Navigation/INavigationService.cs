using System.Threading.Tasks;
using StorefrontRetail.ViewModels.Base;

namespace StorefrontRetail.Services.Navigation
{
    public interface INavigationService
    {
        /// <summary>
        /// Navigation method to asynchronously navigate between Page Models,
        /// and optionally pass navigation Data.
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="navigationData"></param>
        /// <param name="setRoot"></param>
        /// <returns></returns>
        Task NavigateToAsync<TViewModel>(object navigationData = null, bool setRoot = false)
            where TViewModel
            : BaseViewModel;

        /// <summary>
        /// Pop navigation backstack
        /// </summary>
        /// <returns></returns>
        Task GoBackAsync();

        Task PushModalAsync<TViewModel>(object navigationData = null, bool pushAsNavigation = false, bool animate = true)
            where TViewModel : BaseViewModel;

        Task PopModalAsync(bool animate = true);

        Task PushDetailPageAsync<TViewModel>(object navigationData = null, bool hideMaster = false)
            where TViewModel: BaseViewModel;

        Task ShowAlertAsync(string title, string message, string buttonText);
    }
}