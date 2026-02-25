namespace AppMovilesParcial1.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnBiografiaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BiografiaPage());
    }

    private async void OnDiscografiaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DiscografiaPage());
    }



    private void OnThemeChanged(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            
            Application.Current.Resources["PrimaryColor"] = Colors.DodgerBlue;
            Application.Current.Resources["TitleLarge"] = 60d;
            Application.Current.Resources["BackgroundImage"] = "miloconce.jpg";
        }
        else
        {
           
            Application.Current.Resources["PrimaryColor"] = Colors.White;
            Application.Current.Resources["TitleLarge"] = 40d;
            Application.Current.Resources["BackgroundImage"] = "miloj3.jpg";
        }
    }
}
