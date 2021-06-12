using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using OneClickApp.ViewModel;
using System.Windows.Controls;
using System.Threading;
using OneClickApp.UserControls;

namespace OneClickApp.ViewModel
{
    public class HomeViewModel : ObservarObject
    {
        public PoppupMessageBoxViewModel popVM { get; set; }
        public HomeViewModel()
        {
            popVM = new PoppupMessageBoxViewModel();
        }

        private ComboBoxItem _comBoBoxItem;

        public ComboBoxItem ComBoBoxItem
        {
            get { return _comBoBoxItem; }
            set
            {
                _comBoBoxItem = value;
                OnPropertyChanged();
                CheckActiveUser(_comBoBoxItem.Content.ToString());
            }
        }
        public RelayCommand ClearTempCommand { get { return new RelayCommand(ClearTempButton); } }
        public RelayCommand ChandeDBVersionCommand { get { return new RelayCommand(ChandeDBVersionButton); } }
        public RelayCommand SetVDCommand { get { return new RelayCommand(SetVDButton); } }
        public RelayCommand RegAllCommand { get { return new RelayCommand(RegAllButton); } }
        public RelayCommand SPIDSetupCommand { get { return new RelayCommand(SPIDSetupButton); } }
        public RelayCommand SPID10SetupCommand { get { return new RelayCommand(SPID10SetupButton); } }
        public RelayCommand RemoteDeskCommand { get { return new RelayCommand(RemoteDeskButton); } }

        private void ClearTempButton(object sender)
        {
            DirectoryInfo di = new DirectoryInfo(Path.GetTempPath());
            foreach (var file in di.EnumerateFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception) { }
            }
            foreach (var dir in di.EnumerateDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch (Exception) { }
            }

            MessageBox.Show("Temp Cleared");
        }

        private void RegAllButton(object sender)
        {
            Thread th = new Thread(RegAllButtonClick);
            th.Start();
        }

        private void RegAllButtonClick()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"D:\SmartPlantDev\2019\RegAll.bat";
            psi.Verb = "runas";
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                //If you are here the user clicked decline to grant admin privileges (or he's not administrator)
            }
        }
        private void CheckActiveUser(string machineName)
        {
            try
            {
                string appPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string activeUserCmdFile = appPath + "\\" + "ActiveUser.cmd";

                StreamWriter sw = new StreamWriter(activeUserCmdFile);
                sw.WriteLine("query user /server:" + machineName);
                sw.WriteLine("pause");
                sw.Flush();
                sw.Close();
                Process.Start(activeUserCmdFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChandeDBVersionButton(object sender)
        {
            var popUpUC = new PopupMessageBox();
            popUpUC.DataContext = popVM;
            var userControlWindow = new UserControlWindow();
            userControlWindow.DataContext = popVM;
            userControlWindow.Content = popUpUC;
            userControlWindow.Title = "SPID Database Version";
            userControlWindow.ShowDialog();
        }

        private void SPIDSetupButton(object sender)
        {
            string spidSetupPath = @"\\ingrnet.com\in\PPM\Schematics\Builds\SPPID\11\Current";

            if (Directory.Exists(spidSetupPath))
            {
                Process.Start("explorer.exe", spidSetupPath);
            }
        }

        private void SPID10SetupButton(object sender)
        {
            string spidSetupPath = @"\\ingrnet.com\in\PPM\Schematics\Builds\SPPID\2021\Current";

            if (Directory.Exists(spidSetupPath))
            {
                Process.Start("explorer.exe", spidSetupPath);
            }
        }

        private void RemoteDeskButton(object sender)
        {
            Process process = new Process { StartInfo = { FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe") } };
            process.Start();

            //Process process = new Process
            //{
            //    StartInfo ={
            //    FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe"),
            //    Arguments = String.Format(@"/ generic:TERMSRV {0} / user:{1} / pass:{2}", IP, userName, password),
            //    WindowStyle = ProcessWindowStyle.Normal}
            //};
            //process.Start();
        }

        private void SetVDButton(object sender)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"D:\SmartPlantDev\2019\SetVirtualPath.bat";
            //psi.Verb = "runas";
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                //If you are here the user clicked decline to grant admin privileges (or he's not administrator)
            }
        }
    }
}
