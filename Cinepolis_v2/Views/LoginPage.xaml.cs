using System.Diagnostics;
using Cinepolis_v2.Controllers;
using Cinepolis_v2.Models;
namespace Cinepolis_v2.Views;

public partial class LoginPage : ContentPage
{
    
	public LoginPage(){
		InitializeComponent();
    }

    






    private async void LoginButton_Clicked(object sender, EventArgs e){
        Usuario u = new Usuario(EmailEntry.Text, PasswordEntry.Text);

        if (!u.GetDatosInvalidos().Any()) {
            List<Usuario> usuarios = await App.api.ValidarUsuario(u);
            if(usuarios.Count() > 0) {
                if (!usuarios[0].GetDatosInvalidos().Any()) {


                }else{
                    await DisplayAlert("Login Error", usuarios[0].GetDatosInvalidos().ToString(), "Aceptar");
                }
            } else{
                await DisplayAlert("Login", "Usuario o contraseña incorrecto", "Aceptar");
            }


        } else {
            string msj = string.Join("\n", u.GetDatosInvalidos());
            await DisplayAlert("Atencion:", msj, "Aceptar");
        }        
    }








    private void ForgotPasswordLinkClicked(object sender, EventArgs e)
    {
        
    }

    private void OnSignUpLinkClicked(object sender, EventArgs e)
    {
        
    }
}