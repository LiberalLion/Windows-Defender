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

// you could make this source much cleaner but im lazy af. Do it by yourself
// flyshx#0468
namespace WindowsDefenderControl
{
    public partial class flyshx : Form
    {
        public flyshx()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public static void refresh()
        {
            
        }
        private void flyshx_Load(object sender, EventArgs e)
        {
            RegistryKey keyA = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            if (keyA.GetValue("DisableAntiSpyware").ToString() == "0")
            {
                label1.Text = "Windows Defender is enabled (0)";
            }
            else if (keyA.GetValue("DisableAntiSpyware").ToString() == "1")
            {
                label1.Text = "Windows Defender is disabled (1)";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey keyA = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            if (keyA.GetValue("DisableAntiSpyware").ToString() == "0")
            {
                label1.Text = "Windows Defender is enabled (0)";
            }
            else if (keyA.GetValue("DisableAntiSpyware").ToString() == "1")
            {
                label1.Text = "Windows Defender is disabled (1)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey keyA = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            keyA.SetValue("DisableAntiSpyware", 1);
            if (keyA.GetValue("DisableAntiSpyware").ToString() == "0")
            {
                label1.Text = "Failed to enable Windows Defender (0)";
            }
            else if (keyA.GetValue("DisableAntiSpyware").ToString() == "1")
            {
                label1.Text = "Disabled Windows Defender (1)";
            }
            keyA.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey keyA = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            keyA.SetValue("DisableAntiSpyware", 0);
            if (keyA.GetValue("DisableAntiSpyware").ToString() == "0")
            {
                label1.Text = "Enabled Windows Defender (0)";
            }
            else if (keyA.GetValue("DisableAntiSpyware").ToString() == "1")
            {
                label1.Text = "Failed to enable Windows Defender (1)";
            }
            keyA.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact me on Discord: moodless#0001");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The number displays the registery value","Flyshx");
        }
    }
}
