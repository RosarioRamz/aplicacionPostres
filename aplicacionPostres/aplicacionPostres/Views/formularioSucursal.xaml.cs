using aplicacionPostres.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/**
 * 
 * 
 * 
 */

namespace aplicacionPostres.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formularioSucursal : ContentPage
    {
        public formularioSucursal()
        {
            InitializeComponent();
            this.btnSucursal.Clicked += OnbtnSucursal;
        }
        private async void OnbtnSucursal(object sender, EventArgs e)
        {
            //Guardar datos del sucursal
            await App.Database.SaveSucursalAsync(new Sucursal
            {
                Nombre = entryNombreSucursal.Text,
                Direccion = entryDireccion.Text,
                Telefono = entryTelefono.Text

            });
            entryNombreSucursal.Text = string.Empty;
            await Navigation.PushAsync(new ListaSucursal
                ());
        }
    }
}