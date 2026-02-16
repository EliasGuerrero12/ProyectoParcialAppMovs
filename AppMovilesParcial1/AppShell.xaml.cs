namespace AppMovilesParcial1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("biografia", typeof(BiografiaPage));
            Routing.RegisterRoute("discografia", typeof(DiscografiaPage));
        }
    }
}
