using CmlLib.Core.Auth;
using CmlLib.Core.Version;
using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ArgeLauncher
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static string version;
         
        private void path()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            //launcher.FileChanged += (e) =>
            //{
            //    listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            //};
            launcher.ProgressChanged += (s, e) =>
            {
                //bar2.Value = e.ProgressPercentage;
            };

            foreach (var item in launcher.GetAllVersions())
            {
                gunaComboBox1.Items.Add(item.Name);
            }

        }

        private void Launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            //launcher.FileChanged += (e) =>
            //{
            //    listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            //};
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 2048,
                Session = MSession.GetOfflineSession(label1.Text),


            };
            version = gunaComboBox1.SelectedItem.ToString();
            var process = launcher.CreateProcess(version, launchOption);

            process.Start();
            Hide();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            path();
            label1.Text = Global.username;
            var request = WebRequest.Create("https://minotar.net/helm/" + Global.username + "/60.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                gunaCirclePictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
