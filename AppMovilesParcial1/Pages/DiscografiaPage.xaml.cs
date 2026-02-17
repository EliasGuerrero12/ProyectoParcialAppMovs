namespace AppMovilesParcial1.Pages;

public partial class DiscografiaPage : ContentPage
{
    public DiscografiaPage()
    {
        InitializeComponent();

        List<string> albumes = new List<string>
        {
            "La vida era mas corta (2025)",
            "166 (2024)",
            "111 (2023)",
            "En dormir sin Madrid (2023)",
            "511 (2023)"
        };

        ListaAlbumes.ItemsSource = albumes;
    }
}


