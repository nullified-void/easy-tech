using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace problemHelper
{
    public partial class Form1 : Form
    {
        public class ReqInfo
        {
            public string CPU = "";
            public string OS = "";
            public string DateofReq = "";
            public string Header = "";
            public string probleminfo = "";
            public string currentuser = "";
            public string pcname = "";

        }
        public Form1()
        {
            InitializeComponent();
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

        }

       
        private bool closing = true;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closing;
            this.Hide();
        }

        private void сообщитьОПроблемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void закрытьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closing = false;
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            ReqInfo package = new ReqInfo();
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);
            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    package.CPU = Convert.ToString((processor_name.GetValue("ProcessorNameString"))); 
                }
            }
            package.DateofReq = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            package.Header = ProblemHeader.Text;
            package.probleminfo = ProblemText.Text;
            package.OS = getOSInfo() + '/' + Environment.OSVersion;
            package.currentuser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            package.pcname = Environment.MachineName;
            string json = JsonConvert.SerializeObject(package);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:59735/api/values/add"); // сюда нужно будет вставить адрес апи сервера, принимающего запрос
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse(); // с этим нужно будет работать если нужно принимать ответ с веб-сервера.
            MessageBox.Show("Ваш запрос принят в обработку. Диалоговое окно закроется автоматически.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
        string getOSInfo()
        {
            OperatingSystem os = Environment.OSVersion;
            Version vs = os.Version;
            string operatingSystem = "";
            if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                            operatingSystem = "2000";
                        else
                            operatingSystem = "XP";
                        break;
                    case 6:
                        if (vs.Minor == 0)
                            operatingSystem = "Vista";
                        else if (vs.Minor == 1)
                            operatingSystem = "7";
                        else if (vs.Minor == 2)
                            operatingSystem = "8";
                        else
                            operatingSystem = "8.1";
                        break;
                    case 10:
                        operatingSystem = "10";
                        break;
                    default:
                        break;
                }
            }
            if (operatingSystem != "")
            {
                operatingSystem = "Windows " + operatingSystem;
                if (os.ServicePack != "")
                {
                    operatingSystem += " " + os.ServicePack;
                }
            }
            return operatingSystem;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
