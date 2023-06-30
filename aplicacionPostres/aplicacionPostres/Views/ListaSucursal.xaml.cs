using aplicacionPostres.Model;
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
    public partial class ListaSucursal : ContentPage
    {
        public ListaSucursal()
        {
            InitializeComponent();
            this.listarSucursal();
            this.btnEliminarS.Clicked += OnBtnEliminarS; //Eliminar registro
            this.btnActualizarS.Clicked += OnBtnActualizarS; //Actualizar registro
            this.btnActS.Clicked += OnBtnActS;
        }
        public async void listarSucursal() //Mostrar lista de la sucursal
        {
            collectionView.ItemsSource = await App.Database.GetSucursalAsync();
        }
        Sucursal lastSelection;
        public void collectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            lastSelection = e.CurrentSelection[0] as Sucursal;

            entryNombreSucursal.Text = lastSelection.Nombre;
            entryDireccion.Text = lastSelection.Direccion;
            entryTelefono.Text = lastSelection.Telefono;
        }
        public async void OnBtnEliminarS(System.Object sender, System.EventArgs e) //Método de eliminar sucursal
        {
            Console.WriteLine("hola ando en eliminar sucu");
            if (lastSelection != null)
            {
                Console.WriteLine("hola ando en last de sucur");
                if (await DisplayAlert("Eliminar sucursal", "¿Seguro de eliminar la surcursal?", "Si", "No"))
                {
                    await App.Database.DeleteSucursalAsync(lastSelection);
                    collectionView.ItemsSource = await App.Database.GetSucursalAsync();
                }

            }
        }
        public async void OnBtnActualizarS(System.Object sender, System.EventArgs e) //Método actualizar sucursal
        {
            if (lastSelection != null)
            {
                lastSelection.Nombre = entryNombreSucursal.Text;
                lastSelection.Direccion = entryDireccion.Text;
                lastSelection.Telefono = entryTelefono.Text;

                await App.Database.UpdateSucursalAsync(lastSelection);

                collectionView.ItemsSource = await App.Database.GetSucursalAsync();
                popupSLayout.IsVisible = false;
                popupSLayout.ForceLayout();
            }
        }
        public async void OnBtnActS(System.Object sender, System.EventArgs e)
        {
            popupSLayout.IsVisible = true;
            popupSLayout.ForceLayout();

        }
    }
}