using aplicacionPostres.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace aplicacionPostres.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formulario : ContentPage
    {
        public formulario()
        {
            InitializeComponent();
            this.btnRegistrar.Clicked += OnbtnRegistrar;
        }

        private async void OnbtnRegistrar(object sender, EventArgs e)
        {
            await App.Database.SavePostreAsync(new Postres
            {
                Nombre = entryNombre.Text,
                Precio = entryPrecio.Text,
                Categoria = entryCategoria.Text,
                Descripcion = entryDescrip.Text,
                Ruta = entryRuta.Text
            });
            entryNombre.Text = string.Empty;
            await Navigation.PushAsync(new Lista());
        }


    }
}