using AppMovilesParcial1.Models;
namespace AppMovilesParcial1.Pages;

public partial class ConcertDetail : ContentPage
{
    private Concert _concert;

    //clase para mostrar el detalle del concierto seleccionado en la página anterior, muestra la información del concierto seleccionado en la página anterior.
    public ConcertDetail(Concert concert)
    {
        InitializeComponent();

        _concert = concert;

        ConcertImage.Source = _concert.Image;
        ConcertTitle.Text = _concert.NameConcert;
        ConcertDate.Text = "Fecha: " + _concert.Date;
        ConcertPlace.Text = "Lugar: " + _concert.Place;
        ConcertDescription.Text = _concert.Description;
    }
}
