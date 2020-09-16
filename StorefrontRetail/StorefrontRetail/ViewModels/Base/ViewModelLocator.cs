using System;
using System.Collections.Generic;
using StorefrontRetail.Services.Cart;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.Services.Product;
using StorefrontRetail.Services.ProductMenu;
using StorefrontRetail.Services.RequestProvider;
using StorefrontRetail.ViewModels.Account;
using StorefrontRetail.ViewModels.Checkout;
using StorefrontRetail.ViewModels.Payment;
using StorefrontRetail.Views;
using StorefrontRetail.Views.Account;
using StorefrontRetail.Views.Authentication;
using StorefrontRetail.Views.Cart;
using StorefrontRetail.Views.Home;
using TinyIoC;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels.Base
{
    public class ViewModelLocator
    {
        private static readonly TinyIoCContainer Container;
        private static readonly Dictionary<Type, Type> LookupTable;

        static ViewModelLocator()
        {
            Container = new TinyIoCContainer();
            LookupTable = new Dictionary<Type, Type>();

            // Register Page and Page Models
            Register<AccountPageViewModel, AccountPage>();
            Register<CartPageViewModel, CartPage>();
            Register<CheckoutPageViewModel, CheckoutPage>();
            Register<ForgotPasswordViewModel, ForgotPasswordPage>();
            Register<HomePageViewModel, HomePage>();
            Register<LoginPageViewModel, LoginPage>();
            Register<MainTabPageViewModel, MainTabPage>();
            Register<ProductListPageViewModel, ProductListPage>();
            Register<PaymentPageViewModel, PaymentPage>();
            Register<RegisterPageViewModel, RegisterPage>();
            Register<TestPageViewModel, TestPage>();

            // Register Services (registered as Singletons by default)
            Container.Register<INavigationService, NavigationService>();
            Container.Register<IProductMenuService, ProductMenuService>();
            Container.Register<IProductService, ProductService>();
            Container.Register<ICartService, CartService>();
            Container.Register<IRequestProvider, RequestProvider>();
        }

        /// <summary>
        /// Private utility method to Register page and page model for page retrieval by it's
        /// specified page model type.
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <typeparam name="TPage"></typeparam>
        static void Register<TViewModel, TPage>() where TViewModel : BaseViewModel where TPage : Page
        {
            LookupTable.Add(typeof(TViewModel), typeof(TPage));
            Container.Register<TViewModel>();
        }

        public static T Resolve<T>() where T : class
        {
            try
            
            {
                return Container.Resolve<T>();
            }
            catch (TinyIoCResolutionException e)
            {
                string message = e.Message;
                System.Diagnostics.Debug.WriteLine(e.Message);

                while (e.InnerException is TinyIoCResolutionException ex)
                {
                    message = ex.Message;
                    System.Diagnostics.Debug.WriteLine("\t" + ex.Message);
                    e = ex;
                }
#if DEBUG
                App.Current.MainPage.DisplayAlert("Resolution Error", message, "Ok");
#endif
            }
            return default(T);
        }


        public static Page CreatePageFor<TPageModelType>() where TPageModelType : BaseViewModel
        {
            Type pageModelType = typeof(TPageModelType);
            Type pageType = LookupTable[pageModelType];
            Page page = (Page)Activator.CreateInstance(pageType);
            TPageModelType pageModel = Resolve<TPageModelType>();
            page.BindingContext = pageModel;
            return page;
        }
    }
}