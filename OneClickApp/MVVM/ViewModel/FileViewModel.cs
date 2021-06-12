using Microsoft.Win32;
using System.IO;
using System.Windows.Input;
using OneClickApp.Model;
using OneClickApp.ViewModel;

namespace OneClickApp.ViewModel
{
    /// <summary>
    /// View model for the file toolbar.
    /// </summary>
    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }

        //Toolbar commands
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);
        }

        public void NewFile(object sender)
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            Document.Text = string.Empty;
        }

        private void SaveFile(object sender)
        {
            File.WriteAllText(Document.FilePath, Document.Text);
        }

        private void SaveFileAs(object sender)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
            }
        }

        private void OpenFile(object sender)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }
    }
}
