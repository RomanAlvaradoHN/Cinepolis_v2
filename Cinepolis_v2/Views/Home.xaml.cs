using Cinepolis_v2.Controllers;
using Cinepolis_v2.Models;

namespace Cinepolis_v2.Views;

public partial class Home : ContentPage{

    HomeController controller = new HomeController();

    public Home(){
        InitializeComponent();
        CargarDatos();
    }



    private async void CargarDatos() {
        pickerCine.ItemsSource = await controller.ListaDeCines();
        carouselPeliculas.ItemsSource = await controller.ListaDePeliculas();
    }
    


    public async void OnCarouselItemTapped(object sender, EventArgs e){
        Pelicula p = carouselPeliculas.CurrentItem as Pelicula;
        await Navigation.PushAsync(new MovieDetailPage(p));
    }
}