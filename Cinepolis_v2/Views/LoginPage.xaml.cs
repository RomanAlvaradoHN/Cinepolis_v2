using Cinepolis_v2.Models;
using Cinepolis_v2.Controllers;
namespace Cinepolis_v2.Views;

public partial class LoginPage : ContentPage
{
    LoginController controller;
    
	public LoginPage(){
		InitializeComponent();
        controller = new LoginController();
    }

    






    private async void LoginButton_Clicked(object sender, EventArgs e){
        Usuario u = new Usuario(EmailEntry.Text, PasswordEntry.Text);

        if (!u.GetDatosInvalidos().Any()) {
            string resp = await controller.ValidarUsuario(u);
            switch (resp) {
                case "verificado":
                    //await Navigation.PushAsync(new NavigationPage(new AppShell()));
                    App.Current.MainPage = new AppShell();
                    await Navigation.PopToRootAsync();
                    break;

                case "denegado":
                    await DisplayAlert("Login", "Acceso denegado, valide las credenciales", "Aceptar");
                    break;

                default:
                    await DisplayAlert("Error", resp, "Aceptar");
                    break;
            }

        } else {
            throw new Exception(string.Join("\n", u.GetDatosInvalidos()));
        }
    }








    private async void ForgotPasswordLinkClicked(object sender, EventArgs e){
        await Navigation.PushAsync(new ForgotPasswordPage(), true);
    }




    private async void OnSignUpLinkClicked(object sender, EventArgs e){
        await Navigation.PushAsync(new SignUpPage(), true);
    }
}