using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using aplicacionPostres.Model;

namespace aplicacionPostres.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
            this.listarPostres();
            this.btnEliminar.Clicked += OnBtnEliminar; //Botón eliminar
            this.btnActualizar.Clicked += OnBtnActualizar; //Botón actualizar
            this.btnAct.Clicked += OnBtnAct; 

        }
        public async void listarPostres() //Método para mostrar lista
        {
            collectionView.ItemsSource = await App.Database.GetPostresAsync();
        }
        Postres lastSelection;
        public void collectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e) //Selección del postre
        {
            lastSelection = e.CurrentSelection[0] as Postres;

            entryNombre.Text = lastSelection.Nombre;
            entryPrecio.Text = lastSelection.Precio;
            entryCategoria.Text = lastSelection.Categoria;
            entryDescrip.Text = lastSelection.Descripcion;
        }

        public async void OnBtnEliminar(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("hola ando en eliminar");
            if (lastSelection != null)
            {
                Console.WriteLine("hola ando en last");
                if (await DisplayAlert("Eliminar", "¿Seguro de eliminar?", "Si", "No")) {
                    await App.Database.DeletePostreAsync(lastSelection);
                    collectionView.ItemsSource = await App.Database.GetPostresAsync();
                }
            }
        }

        public async void OnBtnActualizar(System.Object sender, System.EventArgs e)
        {
           
            if (lastSelection != null)
            {
                
                lastSelection.Nombre = entryNombre.Text;
                lastSelection.Precio = entryPrecio.Text;
                lastSelection.Categoria = entryCategoria.Text;
                lastSelection.Descripcion = entryDescrip.Text;

                await App.Database.UpdatePostreAsync(lastSelection);

                collectionView.ItemsSource = await App.Database.GetPostresAsync();
                popupLayout.IsVisible = false;
                popupLayout.ForceLayout();
            }
        }

        public async void OnBtnAct(System.Object sender, System.EventArgs e)
        {
            popupLayout.IsVisible = true;
            popupLayout.ForceLayout();
       
        }

    }
}
