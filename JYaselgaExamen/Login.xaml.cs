using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JYaselgaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await DisplayAlert("Inicio", "Bienvenido", "OK");
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario o Clave Incorrectos", "OK");
            }

        }
    }
}
