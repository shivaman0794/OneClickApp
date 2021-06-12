using OneClickApp.ViewModel;
using OneClickApp.Model;

namespace OneClickApp.ViewModel
{
    public class QuickNotesViewModel : ObservarObject
    {
        private DocumentModel _document;
        //Manages user input for document and format styles
        public EditorViewModel Editor { get; set; }
        //Manages saving and loading text files
        public FileViewModel File { get; set; }
        //Manage help dialog
        public QuickNotesViewModel()
        {
            _document = new DocumentModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }
    }
}
