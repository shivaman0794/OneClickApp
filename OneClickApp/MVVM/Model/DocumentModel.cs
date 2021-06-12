using OneClickApp.ViewModel;

namespace OneClickApp.Model
{
    /// <summary>
    /// Model for the text editor document.
    /// </summary>
    public class DocumentModel : ObservarObject
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                OnPropertyChanged();
            }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnPropertyChanged();
            }
        }

        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) ||
                    string.IsNullOrEmpty(FilePath))
                    return true;

                return false;
            }
        }
    }
}
