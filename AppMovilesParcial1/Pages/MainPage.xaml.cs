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
    }

