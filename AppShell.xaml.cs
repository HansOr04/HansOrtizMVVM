namespace HansOrtizApuntes;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registra la ruta de navegación para la página de notas
        Routing.RegisterRoute(nameof(Views.HONotePage), typeof(Views.HONotePage));
    }
}