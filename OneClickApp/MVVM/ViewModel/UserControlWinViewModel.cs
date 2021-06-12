using System.Windows.Controls;
using OneClickApp.ViewModel;

namespace OneClickApp.ViewModel
{
    public class UserControlWinViewModel : ObservarObject
    {
        private UserControl _content;

        public UserControlWinViewModel(UserControl content)
        {
            _content = content;
        }
        public UserControl Content
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged("contentWindow");
            }
        }
    }
}
