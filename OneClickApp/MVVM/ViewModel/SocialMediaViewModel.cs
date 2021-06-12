using OneClickApp.ViewModel;
using System.Diagnostics;

namespace OneClickApp.ViewModel
{
    public class SocialMediaViewModel
    {
        public RelayCommand GmailCommand { get { return new RelayCommand(GmailClick); } }
        public RelayCommand LinkedInCommand { get { return new RelayCommand(LinkedInCLick); } }
        public RelayCommand UdemyCommand { get { return new RelayCommand(UdemyCLick); } }
        public RelayCommand Covid19Command { get { return new RelayCommand(CovidCLick); } }
        public RelayCommand FBCommand { get { return new RelayCommand(FBCLick); } }
        public RelayCommand InstaCommand { get { return new RelayCommand(InstaCLick); } }
        public RelayCommand YouTubeCommand { get { return new RelayCommand(YouTubeCLick); } }
        public RelayCommand TwitterCommand { get { return new RelayCommand(TwitterCLick); } }

        private void GmailClick(object sender)
        {
            Process.Start("https://mail.google.com/mail/u/0/");
        }

        private void LinkedInCLick(object sender)
        {
            Process.Start("https://www.linkedin.com/feed/");
        }

        private void UdemyCLick(object sender)
        {
            Process.Start("https://hexagoncci.udemy.com/organization/home/");
        }

        private void CovidCLick(object sender)
        {
            Process.Start("https://www.covid19india.org/");
        }

        private void FBCLick(object sender)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void InstaCLick(object sender)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void YouTubeCLick(object sender)
        {
            Process.Start("https://www.youtube.com/");
        }

        private void TwitterCLick(object sender)
        {
            Process.Start("https://twitter.com/");
        }
    }
}
