using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace Vape_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Loading()
        {
            // starting server
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(@"cd bin && fix");
            cmd.Close();
            // start vape v4
            if (vapeV4box.Checked)
            {
                var vapev4 = Process.Start($"bin\\v4\\Kangaroo Patcher.exe", "bin\\v4\\Vape_V4.exe");
                while (string.IsNullOrEmpty(vapev4.MainWindowTitle))
                {
                    Thread.Sleep(100);
                    vapev4.Refresh();
                }
                Invoke(new Action(() =>
                {
                    vapeV4.Visible = false;
                    loadingGif.Visible = false;
                    vapeLite.Visible = false;
                    log.Text = "Vape V4 started";
                }));
            }
            // start vape lite
            if (vapeLiteBox.Checked)
            {
                var VapeLite = Process.Start($"bin\\lite\\Kangaroo Patcher.exe", "bin\\lite\\Vape_Lite.exe");
                while (string.IsNullOrEmpty(VapeLite.MainWindowTitle))
                {
                    Thread.Sleep(100);
                    VapeLite.Refresh();
                }
                Invoke(new Action(() =>
                {
                    vapeV4.Visible = false;
                    vapeLite.Visible = false;
                    loadingGif.Visible = false;
                    log.Text = "Vape Lite started";
                }));
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (vapeV4box.Checked == false && vapeLiteBox.Checked == false)
            {
                log.Text = "Please, select vape version";
                return;
            }
            log.Text = null;
            buttonAnimation.Start();
        }

        private void buttonAnimation_Tick(object sender, EventArgs e)
        {
            int i;
            // selected logo animation
            // vape v4 logo
            if (vapeV4box.Checked)
            {
                // turn off all elements
                vapeLiteBox.Visible = false;
                vapeLite.Visible = false;
                vapeV4box.Visible = false;
                // logo animation
                for (i = 80; i <= 152; i++)
                {
                    if (i != 152)
                    {
                        vapeV4.Location = new Point(i, 30);
                    }
                    else { break; }
                }
            }
            // vape lite logo
            if (vapeLiteBox.Checked)
            {
                // turn off all elements
                vapeLiteBox.Visible = false;
                vapeV4.Visible = false;
                vapeV4box.Visible = false;
                // logo animation
                for (i = 223; i >= 163; i--)
                {
                    if (i != 163)
                    {
                        vapeLite.Location = new Point(i, 20);
                    }
                    else { break; }
                }
            }
            // button animation
            for (i=151; i <= 300; i++)
            {
                if (i != 300)
                {
                    gunaGradientButton1.Location = new Point(134, i);
                }
                else { break; }
            }
            // loading animation
            loadingGif.Visible = true;
            for (i = 210; i >= 110; i--)
            {
                if (i != 110)
                {
                    loadingGif.Location = new Point(153, i);
                }
                else { break; }
            }
            buttonAnimation.Stop();
            new Thread(() => Loading()).Start();
        }

    }
}
