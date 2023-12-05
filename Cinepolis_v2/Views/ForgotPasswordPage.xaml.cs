using Cinepolis_v2.Models;
namespace Cinepolis_v2.Views;

public partial class ForgotPasswordPage : ContentPage
{
    
    public ForgotPasswordPage()	{
		InitializeComponent();
	}







	private async void ResetPasswordButton_Clicked(object sender, EventArgs e){
		try{
			Usuario usuario = new Usuario() { 
                Correo = EmailEntry.Text
            };
            

        }catch (Exception ex){
            await DisplayAlert("Password Change", ex.Message, "Aceptar");
        }
    }
}