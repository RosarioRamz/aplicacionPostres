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
    public partial class principal : TabbedPage
    {
        //Mostrar detalles de los productos
        public principal()
        {
            InitializeComponent();
            this.btnCambiar.Clicked += OnPage;
            this.btnCambiarDos.Clicked += OnPageDos;
            this.btnCambiarTres.Clicked += OnPageTres;
            this.btnCambiarCuatro.Clicked += OnPageCuatro;
            this.btnCambiarPan.Clicked += OnPageCinco;
            this.btnCambiarPanDos.Clicked += OnPageSeis;
            this.btnCambiarPanTres.Clicked += OnPageSiete;
            this.btnCambiarPanCuatro.Clicked += OnPageOcho;
            this.btnCambiarBebida.Clicked += OnPageNueve;
            this.btnCambiarBebidaDos.Clicked += OnPageDiez;
            this.btnCambiarBebidaTres.Clicked += OnPageOnce;
            this.btnCambiarBebidaCuatro.Clicked += OnPageDoce;

        }
        public async void OnPage(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Pastel de chocolate\nPrecio: $35.00 por rebanada\nDescripción: Relleno de crema de avellanas, cobertura de jarabe de chocolate y crema batida ", "Cerrar");
        }
        public async void OnPageDos(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Moffin con trozos de cereal y bombones\nPrecio: $20.00 cada uno\nDescripción: Panque de chocolate con cobertura de chocolate con bombones sabor vainilla y trozos de cereal", "Cerrar");
        }
        public async void OnPageTres(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Cupcake de RedVelvet\nPrecio: $15.00 cada uno\nDescripción: Panque RedVelvet con ganash de vainilla y frambuesas en dulce", "Cerrar");
        }
        public async void OnPageCuatro(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Brownie de chocolate\nPrecio: $35.00 cada uno\nDescripción: Panque de chocolate con cobertura de queso crema y trozos de chocolate Milkyway y Snickers", "Cerrar");
        }
        public async void OnPageCinco(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Croissant de chocolate\nPrecio: $15.00 cada uno\nDescripción: Pan de azucar relleno de chocolate", "Cerrar");
        }
        public async void OnPageSeis(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Batard de Nuez \nPrecio: $30.00 cada uno\nDescripción: Pan de nuez", "Cerrar");
        }
        public async void OnPageSiete(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Batard de ajonjolí \nPrecio: $30.00 cada uno\nDescripción: Pan de ajonjolí", "Cerrar");
        }
        public async void OnPageOcho(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Garlic Bread\nPrecio: $15.00 cada uno\nDescripción: Pan de azucar", "Cerrar");
        }
        public async void OnPageNueve(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto:Frappé de fresas y ore\nPrecio: $45.00 cada uno\nDescripción: Bebida fría con chispas de chocolate", "Cerrar");
        }
        public async void OnPageDiez(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Yogurt de pera y cereza\nPrecio: $45.00 cada uno\nDescripción: Bebida con crema y cereza", "Cerrar");
        }
        public async void OnPageOnce(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Capuchino\nPrecio: $65.00 cada uno\nDescripción: Capuchino", "Cerrar");
        }
        public async void OnPageDoce(object sender, EventArgs args)
        {
            await DisplayAlert("Detalles del producto", "Nombre del producto: Arroz con leche y almendras\nPrecio: $35.00 cada uno\nDescripción: Bebida frí, con trozos de hierba buena y almendra", "Cerrar");
        }

    }
}