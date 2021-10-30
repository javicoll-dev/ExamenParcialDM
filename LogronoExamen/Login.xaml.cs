using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogronoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btLogin_Clicked(object sender, EventArgs e)
        {
            //almacenar datos de usuario
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario == "estudiante2021" && password == "uisrael2021")
            {
                //pasar de Login a sistema de calificaciones    
                await Navigation.PushAsync(new MainPage(usuario));
            }
            else
            {
                await DisplayAlert("Mensaje de error", "Usuario y/o password erroneos, ingrese nuevamente las credenciales", "OK");
            }

        }
    }
}