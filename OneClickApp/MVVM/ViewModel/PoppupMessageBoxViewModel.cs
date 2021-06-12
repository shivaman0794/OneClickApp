using Microsoft.Win32;
using OneClickApp.ViewModel;
using System.Windows;

namespace OneClickApp.ViewModel
{
    public class PoppupMessageBoxViewModel
    {
        public RelayCommand CancelClickCommand { get { return new RelayCommand(CancelButtonClick); } }
        public RelayCommand OkClickCommand { get { return new RelayCommand(OkButtonCLick); } }

        private  void CancelButtonClick(object sender)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }
        }

        private void OkButtonCLick(object sender)
        {
            string version = (sender as string).ToString();
            string keyValue = version + ".00.00.00";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Intergraph\Applications\SmartPlantPID.Application\Version", true);
            key.SetValue("SPPIDDDTVersion", keyValue, RegistryValueKind.String);

            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }
        }
    }
}
