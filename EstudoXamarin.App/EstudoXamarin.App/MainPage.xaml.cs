using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EstudoXamarin.App
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.UserViewModel();

            this.ListaUsuario.ItemTapped += async(sender, e) => {
                var user = e.Item as Models.User;

                await App.Current.MainPage.Navigation.PushAsync(new Views.Detail(user));
            };
        }
    }
}
