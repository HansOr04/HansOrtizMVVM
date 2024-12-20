namespace HansOrtizApuntes.Views;

public partial class HOAllNotesPage : ContentPage
{
    public HOAllNotesPage()
    {
        InitializeComponent();
        BindingContext = new Models.HOAllNotes();
    }

    protected override void OnAppearing()
    {
        ((Models.HOAllNotes)BindingContext).LoadNotes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HONotePage));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var note = (Models.HONote)e.CurrentSelection[0];
            await Shell.Current.GoToAsync($"{nameof(HONotePage)}?{nameof(HONotePage.ItemId)}={note.Filename}");
            notesCollection.SelectedItem = null;
        }
    }
}