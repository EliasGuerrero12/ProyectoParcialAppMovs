namespace AppMovilesParcial1;

public partial class DiscografiaPage : ContentPage
{
    public DiscografiaPage()
    {
        InitializeComponent();

        AlbumList.ItemsSource = new List<string>
        {
            "La vida era mas corta (2025)",
            "Bajo de la piel (2025)",
            "166 (2024)",
            "111 (2023)",
            "En Dormir Sin Madrid (2023)",
            "511 (2023)"
        };
    }
}