using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HansOrtizApuntes.Models;

internal class HOAllNotes
{
    public ObservableCollection<HONote> Notes { get; set; } = new ObservableCollection<HONote>();

    public HOAllNotes() =>
        LoadNotes();

    public void LoadNotes()
    {
        Notes.Clear();
        string appDataPath = FileSystem.AppDataDirectory;

        IEnumerable<HONote> notes = Directory
            .EnumerateFiles(appDataPath, "*.notes.txt")
            .Select(filename => new HONote()
            {
                Filename = filename,
                Text = File.ReadAllText(filename),
                Date = File.GetLastWriteTime(filename)
            })
            .OrderBy(note => note.Date);

        foreach (HONote note in notes)
            Notes.Add(note);
    }
}
