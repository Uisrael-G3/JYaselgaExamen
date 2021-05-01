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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string mensual, string user)
        {
            InitializeComponent();

            lblNombre.Text = nombre;
            lblMensual.Text = mensual;
            lblUser.Text = user;
        }
    }
}