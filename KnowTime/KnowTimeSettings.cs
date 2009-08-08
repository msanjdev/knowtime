using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KnowTimeApp
{
    public partial class KnowTimeSettings : Form
    {
        public KnowTimeSettings()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            RegistryKey hklm = Registry.LocalMachine;

            if (chkWinStartup.Checked) 
            {
                hklm = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                hklm.SetValue(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                hklm = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (hklm.GetValue(Application.ProductName) != null)
                    hklm.DeleteValue(Application.ProductName, false);
            }
        }
    }
}
