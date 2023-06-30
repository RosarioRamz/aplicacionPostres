using aplicacionPostres.Model;
using aplicacionPostres.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aplicacionPostres
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            this.btnMenu.Clicked += onMenu;
            this.btnRegistro.Clicked += onRegistro;

        }
        public async void onMenu(object sender, EventArgs args)
        {
            Console.WriteLine("Holaaaaa saludos desde xamarin");
            await Navigation.PushAsync(new principal());
        }
        public async void onRegistro(object sender, EventArgs args)
        {
            Console.WriteLine("Holaaaaa saludos desde xamarin");
            await Navigation.PushAsync(new intermedioRegistro()); //Enviar a pagina de postres
        }
    }
}
