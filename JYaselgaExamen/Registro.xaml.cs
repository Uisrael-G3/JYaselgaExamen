using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JYaselgaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();

            lblUsuario.Text = usuario;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            

            double pago = Convert.ToDouble(txtPagoinicial.Text);
            double rest = (1800 - pago) / 3;
            double total = (rest + (1800 * 0.05)) * 3;
            txtTotal.Text = total.ToString();

            await DisplayAlert("Cálculo", "Cálculo Realizado", "OK");

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Guardar", "Elemento guardado con exito", "OK");

            string nombre = txtNombre.Text;
            string mensual = txtTotal.Text;
            string user = lblUsuario.Text;

            await Navigation.PushAsync(new Resumen(nombre, mensual, user));
        }
    }
}