using AppMovilesParcial1.Models;

namespace AppMovilesParcial1.Pages;

public partial class AlbumDetail : ContentPage
{
    public AlbumDetail(Album album)
    {
        InitializeComponent();

        // Llenar controles con el modelo
        AlbumImage.Source = album.Image;
        AlbumTitle.Text = album.Name;
        AlbumArtist.Text = "Álbum";
        AlbumReleaseDate.Text = "Año: " + album.Year;
        AlbumDescription.Text = album.Description;
    }
}
