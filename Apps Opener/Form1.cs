using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;

namespace Apps_Opener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Social_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\jmasu\AppData\Local\Discord\Update.exe",
                    Arguments = "--processStart Discord.exe"
                };
                Process.Start(startInfo);
                Process.Start("C:\\Users\\jmasu\\AppData\\Local\\Programs\\Opera GX\\launcher.exe");
                Process.Start(@"C:\Users\jmasu\AppData\Roaming\Spotify\Spotify.exe");
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine(ex.ToString());
            }
        }

        private void Peripherals_Click(object sender, EventArgs e)
        {
            /*Process.Start("C:\\Program Files (x86)\\FANTECH X9 Gaming Mouse\\Gaming Mouse 2.0.exe");*/
            Process.Start("C:\\Program Files (x86)\\KG916 Gaming Keyboard\\OemDrv.exe");
            Process.Start("C:\\Program Files (x86)\\Razer\\Synapse\\RzSynapse.exe");
            Process.Start("C:\\Program Files\\EqualizerAPO\\config\\Peace.exe");
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Users\\Riot Games\\Riot Client\\UX\\RiotClientUx.exe");
            Process.Start("C:\\Users\\jmasu\\AppData\\Local\\Programs\\U.GG\\U.GG.exe");
        }

        private void cleanmgr_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\cleanmgr.exe.");
        }

        private void appdata_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\jmasu\AppData");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msteams_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\jmasu\AppData\Local\Microsoft\Teams\Update.exe",
                    Arguments = "--processStart Teams.exe"
                };
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine(ex.ToString());
            }
        }

        /*private void showCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/
    }
}