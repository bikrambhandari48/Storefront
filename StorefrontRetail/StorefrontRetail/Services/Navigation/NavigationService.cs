using System;
using System.Threading.Tasks;
using StorefrontRetail.ViewModels.Base;
using StorefrontRetail.Views.Account;
using Xamarin.Forms;

namespace StorefrontRetail.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public Task GoBackAsync()
        {
            if (App.Current.MainPage is NavigationPage navPage)
            {
                return navPage.PopAsync();
            }

            return Task.CompletedTask;
        }

        public async Task PushModalAsync<TViewModal>(object navigationData = null, bool pushAsNavigation = false,
            bool animate = true) where TViewModal : BaseViewModel
        {
            try
            {
                Page page = ViewModelLocator.CreatePageFor<TViewModal>();

                if (pushAsNavigation)
                {
                    await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(page), animate);
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushModalAsync(page, animate);
                }

                if (page.BindingContext is BaseViewModel baseViewModel)
                {
                    await baseViewModel.InitialiseDataAsync(navigationData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot push modal async. Error message is+ "+ e.Message);
                throw;
            }
           
        }

        public Task PopModalAsync(bool animate = true)
        {
            App.Current.MainPage.Navigation.PopModalAsync(animate);
            return Task.CompletedTask;
        }

        public async Task PushDetailPageAsync<TViewModel>(object navigationData = null, bool hideMaster = false)
            where TViewModel : BaseViewModel
        {
            Page page = ViewModelLocator.CreatePageFor<TViewModel>();
            var currentMasterDetailPage = (App.Current.MainPage as TabbedPage).CurrentPage as MasterDetailPage;
            if (currentMasterDetailPage == null) return;
            currentMasterDetailPage.IsPresented = hideMaster;
            currentMasterDetailPage.Detail = new NavigationPage(page);
            if (page.BindingContext is BaseViewModel baseViewModel)
            {
                await baseViewModel.InitialiseDataAsync(navigationData);
            }
        }

        public async Task  ShowAlertAsync(string title, string message, string buttonText)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, buttonText);
        }

        public async Task NavigateToAsync<TViewModel>(object navigationData = null, bool setRoot = false)
            where TViewModel : BaseViewModel
        {
            try
            {
                Page page = ViewModelLocator.CreatePageFor<TViewModel>();

                if (setRoot)
                {
                    if (page is TabbedPage tabbedPage)
                    {
                        App.Current.MainPage = tabbedPage;
                    }
                    else
                    {
                        App.Current.MainPage = new NavigationPage(page);
                    }
                }
                else
                {
                    if (page is TabbedPage tabPage)
                    {
                        App.Current.MainPage = tabPage;
                    }
                    else if (App.Current.MainPage is NavigationPage navigationPage)
                    {
                        await navigationPage.PushAsync(page);
                    }
                    else if (App.Current.MainPage is TabbedPage tabbedPage)
                    {
                        //await tabbedPage.Navigation.PushAsync(page);
                        if (tabbedPage.CurrentPage is NavigationPage nPage)
                        {
                            await nPage.PushAsync(page);
                        }
                    }
                    else
                    {
                        App.Current.MainPage = new NavigationPage(page);
                    }
                }

                if (page.BindingContext is BaseViewModel baseViewModel)
                {
                    await baseViewModel.InitialiseDataAsync(navigationData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while trying to navigate. Error message is " + e.Message);
            }
        }
         
    }
}