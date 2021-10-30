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
    public partial class Resum : ContentPage
    {
        public Resum(string usuario, string nombre, double pagar)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lblTotal.Text = Convert.ToString(pagar);
        }
    }
}