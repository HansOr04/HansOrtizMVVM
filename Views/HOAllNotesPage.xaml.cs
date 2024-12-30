namespace HansOrtizApuntes.Views;

public partial class HOAllNotesPage : ContentPage
{
    public HOAllNotesPage()
    {
        InitializeComponent();
    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}