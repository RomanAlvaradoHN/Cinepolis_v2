namespace Cinepolis_v2.Views;

public partial class SignUpPage : ContentPage
{
    
    public SignUpPage()	{  
		InitializeComponent();
	}





    private void SignUpButton_Clicked(object sender, EventArgs e){

    }




    private async void OnSignInLinkClicked(object sender, EventArgs e) {
        await Navigation.PushAsync(new LoginPage(), true);
    }
}