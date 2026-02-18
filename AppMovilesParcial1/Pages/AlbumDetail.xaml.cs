using AppMovilesParcial1.Models;

namespace AppMovilesParcial1.Pages;

public partial class AlbumDetail : ContentPage
{
    private Album _album;

    //Detalle del album , muestra la información del álbum seleccionado en la página anterior.
    public AlbumDetail(Album album)
    {
        InitializeComponent();

        _album = album;

        AlbumImage.Source = _album.Image;
        AlbumTitle.Text = _album.Name;
        AlbumArtist.Text = "Artista: Milo J";
        AlbumReleaseDate.Text = "Año: " + _album.Year;
        AlbumDescription.Text = _album.Description;
    }
}
