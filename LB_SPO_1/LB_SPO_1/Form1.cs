using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LB_SPO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                textBox1.Text = d.Name;
                textBox2.Text = d.DriveType.ToString();
                if (d.IsReady == true)
                {
                    textBox3.Text = d.VolumeLabel.ToString();
                    textBox4.Text = d.DriveFormat;
                    textBox5.Text = d.AvailableFreeSpace.ToString();
                    textBox6.Text = d.TotalFreeSpace.ToString();
                    textBox7.Text = d.TotalSize.ToString();
                }
            }
        }

    }
}