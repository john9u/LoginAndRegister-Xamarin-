using LoginAndRegister_Xamarin_.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginAndRegister_Xamarin_.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}