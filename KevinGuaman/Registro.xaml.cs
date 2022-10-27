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
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            lblUser.Text = "El usuario conectado es : " + user;
        }

        private void btnCalMensual_Clicked(object sender, EventArgs e)
        {
            string nombre = txtEstudiante.Text;
            double valorsemestre = 3000;
            double interes = valorsemestre * 0.05;
            double monto = Convert.ToDouble(txtMonto.Text);
            if (monto>=0&&monto<3000)
            {
                
                double valPar = valorsemestre - monto + interes;
                string result = Convert.ToString(valPar / 5);
                txtPago.Text = result;
                DisplayAlert("Confirmación", "Cuota mensual es : \n " + "Para el estudiante: "
                + nombre + result.ToString(), "cerrar");
            }
            else
            {
                DisplayAlert("Error", "No se puede ingresar valores mayores de 3000$ y menores a 0", "cerrar");
            }

 

            
        }
        private async void btnResumen_Clicked(object sender, EventArgs e)
        {
            string user = "KevinGuaman2022";
            string nombreEst = txtEstudiante.Text;
            
            await Navigation.PushAsync(new Resumen(txtEstudiante.Text,user));
            await DisplayAlert("Confirmacion", "Estimado estudiante su pago es: " + nombreEst + " registrado con exito", "Cerrar");
        }
    }
}