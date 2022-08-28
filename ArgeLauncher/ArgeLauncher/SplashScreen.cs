using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgeLauncher
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            panel2.Width += 4;

            if (panel2.Width >= 189)
            {
                loadingInfo.Text = "MINOTAR API YÜKLENİYOR...";
            }

            if (panel2.Width >= 310)
            {
                loading.Stop();
                Hide();
                new LoginScreen().Show();
            }
        }
    }
}
