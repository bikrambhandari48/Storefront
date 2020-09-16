using System;
using System.Windows.Input;
using StorefrontRetail.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}