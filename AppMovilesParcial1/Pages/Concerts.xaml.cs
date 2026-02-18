using AppMovilesParcial1.Models;
namespace AppMovilesParcial1.Pages;

public partial class Concerts : ContentPage
{
    private List<Concert> _concerts =
    [
        new Concert{
            NameConcert="Gira España 2023",
            Date="29 de junio de 2023",
            Place="Sala Apolo, Barcelona, España",
            Description="Concierto en el marco de su primera gira por España. ",
            Image="apolo.jpg"
        },

        new Concert{
            NameConcert="Show 18º Cumpleaños",
            Date="25 de octubre de 2024",
            Place="Estadio Nuevo Francisco Urbano, Morón, Argentina",
            Description="Concierto especial por su mayoría de edad en el estadio de su ciudad natal, con más de 30 mil asistentes. ",
            Image="diezz.jpg"
        },
        
         new Concert{
            NameConcert="Gira España 2025",
            Date="Enero de 2025",
            Place="\tPalau Sant Jordi (Barcelona) y Palacio de los Deportes (Madrid), España",
            Description="Gira por España presentando su álbum 166, con entradas agotadas en fechas emblemáticas.",
            Image="espa.jpg"
        },
         
    ];

    public Concerts()
    {
        InitializeComponent();
        concertsListView.ItemsSource = _concerts;
    }

    private async void OnConcertSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Concert selectedConcert)
        {
            await Navigation.PushAsync(new ConcertDetail(selectedConcert));
        }
    }
}
