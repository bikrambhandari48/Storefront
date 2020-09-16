using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StorefrontRetail.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StorefrontRetail.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartItemTemplate : ContentView
    {
        public static readonly BindableProperty RemoveItemCommandProperty =
            BindableProperty.Create(nameof(RemoveItemCommand), typeof(ICommand), typeof(CartItemTemplate));

        public ICommand RemoveItemCommand
        {
            get => (ICommand) GetValue(RemoveItemCommandProperty);
            set => SetValue(RemoveItemCommandProperty, value);
        }

        public static readonly BindableProperty AddCommentCommandProperty =
            BindableProperty.Create(nameof(AddCommentCommand), typeof(ICommand), typeof(CartItemTemplate));

        public ICommand AddCommentCommand
        {
            get => (ICommand) GetValue(AddCommentCommandProperty);
            set => SetValue(AddCommentCommandProperty, value);
        }


        public static readonly BindableProperty UpdateCartCommandProperty =
            BindableProperty.Create(nameof(UpdateCartCommand), typeof(ICommand), typeof(CartItemTemplate));

        public ICommand UpdateCartCommand
        {
            get => (ICommand) GetValue(UpdateCartCommandProperty);
            set => SetValue(UpdateCartCommandProperty, value);
        }

        public static BindableProperty UpdateCartCommandParameterProperty =
            BindableProperty.Create(nameof(UpdateCartCommandParameter), typeof(Product), typeof(CartItemTemplate));

        public Product UpdateCartCommandParameter
        {
            get => (Product) GetValue(UpdateCartCommandParameterProperty);
            set => SetValue(UpdateCartCommandParameterProperty, value);
        }


        public CartItemTemplate()
        {
            InitializeComponent();
        }
    }
}