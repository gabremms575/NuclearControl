using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace NuclearControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            label2.Text = "LAUNCHING";

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            Nuke1.BackColor = Color.Red;
            Nuke2.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            Nuke1.BackColor = Color.Black;
            Nuke2.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(500); 

            Nuke1.BackColor = Color.Red;

            Nuke2.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            Nuke1.BackColor = Color.Black;
            Nuke2.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(500);

            Nuke1.BackColor = Color.Red;
            Nuke2.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            Nuke1.BackColor = Color.Black;
            Nuke2.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(500);

            Nuke1.BackColor = Color.Red;
            Nuke2.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            Nuke1.BackColor = Color.Black;
            Nuke2.BackColor = Color.Black;

            Nuke1.BackColor = Color.Red;
            Nuke2.BackColor = Color.Red;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
