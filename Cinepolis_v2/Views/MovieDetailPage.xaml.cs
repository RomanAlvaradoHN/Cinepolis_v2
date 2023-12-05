using Cinepolis_v2.Controllers;
using Cinepolis_v2.Models;

namespace Cinepolis_v2.Views;
public partial class MovieDetailPage : ContentPage
{
	public MovieDetailPage(Pelicula p){
		InitializeComponent();

		BindingContext = p;
    }
}