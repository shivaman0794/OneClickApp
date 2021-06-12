using System.Diagnostics;
using OneClickApp.ViewModel;

namespace OneClickApp.ViewModel
{
    public class WebPageViewModel : ObservarObject
    {
        private string _jtsNumber;

        public string JTSNumber
        {
            get { return _jtsNumber; }
            set
            {
                _jtsNumber = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand BacklogPageCommand { get { return new RelayCommand(BackLogClick); } }
        public RelayCommand CiphersHomePageCommand { get { return new RelayCommand(CipherHomeCLick); } }
        public RelayCommand ChangesetPageCommand { get { return new RelayCommand(ChangesetCLick); } }
        public RelayCommand JTSPageCommand { get { return new RelayCommand(JTSCLick); } }
        public RelayCommand SPID11PipelinesCommand { get { return new RelayCommand(SPID11PLCLick); } }
        public RelayCommand SP2D11PipelinesCommand { get { return new RelayCommand(SP2D11PLCLick); } }
        public RelayCommand SPID10PipelinesCommand { get { return new RelayCommand(SPID10PLCLick); } }
        public RelayCommand SP2D10PipelinesCommand { get { return new RelayCommand(SP2D10PLCLick); } }

        private void BackLogClick(object sender)
        {
            Process.Start("https://dev.azure.com/hexagonPPMCOL/PPM/_sprints/directory");
        }

        private void CipherHomeCLick(object sender)
        {
            Process.Start("https://share.intergraph.com/ppm/spknowledge/tab2/scrum2/Ciphers/SitePages/Ciphers.aspx");
        }

        private void ChangesetCLick(object sender)
        {
            Process.Start("https://dev.azure.com/hexagonPPMCOL/PPM/_versionControl/changesets");
        }

        private void JTSCLick(object sender)
        {
            if (string.IsNullOrEmpty(JTSNumber))
                Process.Start("https://jts.ingrnet.com/");
            else
            Process.Start(string.Format($"https://jtscloud.azurewebsites.net/report.asp?ProductGroup=07&JTSNo=0,{JTSNumber}&view=executive&voEdit=ON&voChildren=ON&voFiles=ON&voHistory=ON&hl=Regression"));
            JTSNumber = string.Empty;
        }

        private void SPID11PLCLick(object sender)
        {
            Process.Start("https://dev.azure.com/hexagonPPMCOL/PPM/_build?definitionId=2044");
        }

        private void SP2D11PLCLick(object sender)
        {
            Process.Start("https://dev.azure.com/hexagonPPMCOL/PPM/_build?definitionId=2028");
        }

        private void SPID10PLCLick(object sender)
        {
            Process.Start("https://dev.azure.com/hexagonPPMCOL/PPM/_build?definitionId=991");
        }

        private void SP2D10PLCLick(object sender)
        {
            Process.Start("https://dev.azure.com/hexagonPPMCOL/PPM/_build?definitionId=1400");
        }
    }
}

