using System;
using System.Windows.Input;
using OneClickApp.ViewModel;
using OneClickApp.Model;
using OneClickApp.UserControls;

namespace OneClickApp.ViewModel
{
    /// <summary>
    /// View model for the text editor.
    /// </summary>
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; set; }
        public DocumentModel  Document { get; set; }

        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel{Size = 20};
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
        }

        private void OpenStyleDialog(Object sender)
        {
            var fontDialog = new FontDialog();
            fontDialog.DataContext = Format;
            var userControlWindow = new UserControlWindow();
            userControlWindow.Content = fontDialog;
            userControlWindow.Title = "Format Window";
            userControlWindow.ShowDialog();
        }

        private void ToggleWrap(object sender)
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            else
                Format.Wrap = System.Windows.TextWrapping.Wrap;
        }
    }
}
