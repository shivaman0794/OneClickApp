using System;
using System.Diagnostics;
using System.Windows;
using Microsoft.Win32;
using OneClickApp.ViewModel;

namespace OneClickApp.ViewModel
{
    public class ToolsViewModel
    {
        public RelayCommand RegNewDllCommand { get { return new RelayCommand(RegNewDllButton); } }
        public RelayCommand HexConnectCommand { get { return new RelayCommand(HexConnectButton); } }
        

        public RelayCommand FixRADRegCommand { get { return new RelayCommand(FixRADRegButton); } }

        public RelayCommand CoinDCXCommand { get { return new RelayCommand(CoinDCXButton); } }

        public RelayCommand SpeedtestCommand { get { return new RelayCommand(SpeedTestButton); } }

        public RelayCommand SPIDAutomationCommand { get { return new RelayCommand(SPIDAutomationButton); } }

        public RelayCommand DMCommand { get { return new RelayCommand(DMExeButton); } }

        private void RegNewDllButton(object sender)
        {
           try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"R:\rad2d\bin";
                openFileDialog.ShowDialog();

                var processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "regsvr32";
                processStartInfo.Arguments = openFileDialog.FileName;
                processStartInfo.Verb = "runas";
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + @" (i.e. R:\rad2d\bin)");
            }
        }

        private void FixRADRegButton(object sender)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\agupta3\Desktop\RegistryFixes.reg";
            psi.Verb = "runas";
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CoinDCXButton(object sender)
        {
            Process.Start("https://coindcx.com/portfolio");
        }

        private void SpeedTestButton(object sender)
        {
            Process.Start("https://www.speedtest.net/");
        }

        private void SPIDAutomationButton(object sender)
        {
            try
            {
                Process.Start(@"R:\rad2d\bin\SPPIDAutomation.exe");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DMExeButton(object sender)
        {
            try
            {
                Process.Start(@"R:\rad2d\bin\DrawingManagerEXE.exe");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void HexConnectButton(object sender)
        {
            Process.Start("https://eur02.safelinks.protection.outlook.com/?url=https%3A%2F%2Fperformancemanager5.successfactors.eu%2Fsf%2Flogin%3Fcompany%3DintergraphP2%26loginMethod%3DSSO%23Shell-home&data=02%7C01%7C%7C3418579d74db4b15464808d834b5c9f5%7C1b16ab3eb8f64fe39f3e2db7fe549f6a%7C0%7C0%7C637317302887065802&sdata=XjPjI32paer31q6%2BnhoCj4BnduoxG9kBX%2FmUurqNok0%3D&reserved=0");
        }

    }
}
