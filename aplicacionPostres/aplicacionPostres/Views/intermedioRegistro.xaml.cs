using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacionPostres.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class intermedioRegistro : ContentPage
    {
        public intermedioRegistro()
        {
            InitializeComponent();
            this.btnRegistrarProducto.Clicked += OnbtnRegistrarProducto;
            this.btnRegistrarSucursal.Clicked += OnbtnRegistrarSucursal;
        }
       public async void OnbtnRegistrarProducto(object sender, EventArgs args)
        {
            //Navegación hacia el formulario
            await Navigation.PushAsync(new formulario());
        }
        public async void OnbtnRegistrarSucursal(object sender, EventArgs args)
        {
            //Navegación hacia el formulario para registrar sucursal
            await Navigation.PushAsync(new formularioSucursal());
        }
    }
    
}