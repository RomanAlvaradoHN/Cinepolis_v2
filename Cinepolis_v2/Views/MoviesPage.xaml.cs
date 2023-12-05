namespace Cinepolis_v2.Views;

public partial class MoviesPage : ContentPage
{



    public MoviesPage(){
		InitializeComponent();
    }



    private void filtroEntry_TextChanged(object sender, TextChangedEventArgs e)
    {/*
        string filtro = filtroEntry.Text.ToLower();
        if (filtro.Length > 0)
        {
            listaPeliculas.ItemsSource = Lista.Where(X => X.Titulo.ToLower().Contains(filtro)).ToList();
        }
        else
        {

            listaPeliculas.ItemsSource = Lista.ToList();
        }*/
    }
}