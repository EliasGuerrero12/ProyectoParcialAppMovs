namespace AppMovilesParcial1;

public partial class DiscografiaPage : ContentPage
{
    public DiscografiaPage()
    {
        InitializeComponent();
    }

    private void OnAlbumLaVidaClicked(object sender, EventArgs e)
    {
        CancionesLaVida.IsVisible = !CancionesLaVida.IsVisible;
    }
}