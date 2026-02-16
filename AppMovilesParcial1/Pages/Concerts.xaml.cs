using AppMovilesParcial1.Models;
namespace AppMovilesParcial1.Pages;

public partial class Concerts : ContentPage
{
    private List<Concert> _concerts =
    [
        new Concert{
            NameConcert="AM saj",
            Date="12 Marz",
            Place="Ciudad de México",
            Description="Tour mundial presentación del álbum AM",
            Image="sdcs.jpg"
        },

        new Concert{
            NameConcert="Vive Latino",
            Date="18 Marzo",
            Place="Foro Sol",
            Description="Presentación especiadc",
            Image="sdcds.jpg"
        }
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
