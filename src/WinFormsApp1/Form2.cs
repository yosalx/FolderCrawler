using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingSlamet
{
    public partial class Form2 : Form
    {
        WMPLib.WindowsMediaPlayer klik = new WMPLib.WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Click_OnMouseDown(object sender, MouseEventArgs e)
        {
            klik.URL = @"./Resources/click.wav";
        }
    }
}
