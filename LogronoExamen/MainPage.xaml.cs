using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogronoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }
        double montoParcial;
        double totalPagar;
        double montoInicial;


        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                montoInicial = Convert.ToDouble(txtMonto.Text);

                if (montoInicial > 1 && montoInicial < 1799)
                {
                    montoParcial = 1800 - montoInicial;
                }
                else
                {
                    DisplayAlert("Mensaje de error", "Ingre un monto que sea mayor a 0 y menor a 1800", "OK");
                }
            }
            catch (Exception ex) {
                
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try {
                double interes = (1800 * 5) / 100;
                double pagoMensual = (montoParcial/3) + interes;
                totalPagar = pagoMensual * 3 + montoInicial;
                txtMensualidades.Text = Convert.ToString(pagoMensual);

            }
            catch (Exception ex) { }


        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            string nombre = txtNombre.Text;
            
            await Navigation.PushAsync(new Resum(usuario, nombre, totalPagar));

        }
    }
}
