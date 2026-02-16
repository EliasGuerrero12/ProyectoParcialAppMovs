using AppMovilesParcial1.Models;

namespace AppMovilesParcial1.Pages;

public partial class Discografia: ContentPage
{
    private List<Album> _albums =
    [
        new Album {
            Name="AM",
            Year="2013",
            Image="am.jpg",
            Description="ishduiwuid"
        },

        new Album {
            Name="Favourite Worst Nightmare",
            Year="2007",
            Image="fwn.jpg",
            Description="uedhwueo"
        }
    ];

    public Discografia()
    {
        InitializeComponent();
        albumsListView.ItemsSource = _albums;
    }

    private async void OnAlbumSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Album selectedAlbum)
        {
            await Navigation.PushAsync(new AlbumDetail(selectedAlbum));
        }
    }
}
