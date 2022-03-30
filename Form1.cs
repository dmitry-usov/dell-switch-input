using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace dell_switch_input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_setDP_Click(object sender, EventArgs e)
        {
            setInput("DP");
        }

        private void setInput(string sInName)
        {
            Process p = new Process();
            p.StartInfo.FileName = @"C:\\Program Files (x86)\\Dell\\Dell Display Manager\\ddm.exe";
            p.StartInfo.Arguments = "/SetActiveInput " + sInName;
            p.Start();
        }

        private void bt_setmDP_Click(object sender, EventArgs e)
        {
            setInput("mDP");
        }

        private void bt_setHDMI1_Click(object sender, EventArgs e)
        {
            setInput("HDMI1");
        }

        private void bt_setHDMI2_Click(object sender, EventArgs e)
        {
            setInput("HDMI2");
        }
    }
}
