using System.Windows;

namespace OneClickApp.ViewModel
{
    public class MainViewModel : ObservarObject
    {
        public RelayCommand CloseButtonCommand { get; private set; }
        public RelayCommand MinimizeButtonCommand { get; private set; }
        public RelayCommand QuickNotesCommand { get { return new RelayCommand(o => { CurrentView = quickNotesVM; }); } }
        public RelayCommand ToolsViewCommand { get { return new RelayCommand(o => { CurrentView = toolsVM; }); } }
        public RelayCommand WebPageViewCommand { get { return new RelayCommand(o => { CurrentView = webPageVM; }); } }
        public RelayCommand HomeViewCommand { get { return new RelayCommand(o => { CurrentView = homeVM; }); } }
        public RelayCommand SMViewCommand { get { return new RelayCommand(o => { CurrentView = socialMediaVM; }); } }

        //Document that is saved, loaded and hold editor text

        
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        HomeViewModel homeVM;
        SocialMediaViewModel socialMediaVM;
        WebPageViewModel webPageVM;
        ToolsViewModel toolsVM;
        QuickNotesViewModel quickNotesVM;

        public MainViewModel()
        {
            homeVM = new HomeViewModel();
            socialMediaVM = new SocialMediaViewModel();
            webPageVM = new WebPageViewModel();
            toolsVM = new ToolsViewModel();
            quickNotesVM = new QuickNotesViewModel();
            CurrentView = homeVM;
            CloseButtonCommand = new RelayCommand(CloseButton);
            MinimizeButtonCommand = new RelayCommand(MinimizeButton);
        }

        public  void CloseButton( object obj)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }
        }

        public void MinimizeButton(object obj)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    item.WindowState = WindowState.Minimized;
                }
            }
        }
    }
}
