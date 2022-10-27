using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KevinGuaman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string user = "KevinGuaman2022";
            string password = "uisrael2022";
            string userEquals = txtUser.Text;
            string passEquals = txtPassword.Text;
            if (user == userEquals & password == passEquals)
            { 

                await Navigation.PushAsync(new Registro(txtUser.Text));
               



            }
            else
            {
                await DisplayAlert("Confirmacion", "Usuario incorrecto o no existe", "Cerrar");
            }
        }
    }
}