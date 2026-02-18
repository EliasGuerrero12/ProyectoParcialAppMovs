using AppMovilesParcial1.Models;

namespace AppMovilesParcial1.Pages;

public partial class DiscografiaPage : ContentPage
{
    private List<Album> _albums =
    [
        
        //lista predefinida de álbumes de Milo J, cada álbum tiene un nombre, año de lanzamiento, imagen y descripción asociada.
        new Album {
            Name="La Vida Era Más Corta",
            Year="2025",
            Image="lavida.png",
            Description="Su tercer álbum de estudio, donde realiza un giro hacia el folklore y las raíces argentinas, fusionándolo con el trap. Incluye colaboraciones con leyendas como Mercedes Sosa (de manera póstuma), Silvio Rodríguez, Soledad y Trueno"
        },

        new Album {
            Name="166",
            Year="2024",
            Image="cien.png",
            Description="Su segundo álbum de estudio, enfocado principalmente en el trap. El nombre es un homenaje a la línea de colectivo que usaba para moverse por su barrio."
        },

        new Album {
            Name="111",
            Year="2023",
            Image="cienonce.png",
            Description="Su álbum de estudio debut. Incluye colaboraciones con artistas como Peso Pluma, Nicki Nicole, Yami Safdie y Yahritza y Su Esencia. El álbum explora una variedad de sonidos urbanos y mostró su versatilidad al mundo."
        },

        new Album {
            Name="En dormir sin Madrid",
            Year="2023",
            Image="madrid.png",
            Description="Un EP colaborativo con el reconocido productor Bizarrap. Incluye la exitosa \"Milo J: BZRP Music Sessions, Vol. 57\" y otras cuatro canciones que consolidaron su salto a la fama internacional"
        }
    ];

    public DiscografiaPage()
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