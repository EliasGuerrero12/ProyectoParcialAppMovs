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



    

    private void OnToggledChanged(object sender, ToggledEventArgs e)
    {
       
        if (e.Value)
        {
            Application.Current.Resources["PrimaryColor"] = Colors.Red;
        }
        else
        {
            Application.Current.Resources["PrimaryColor"] = Color.FromHex("#00d2ff");
        }
    }
}
