using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StandartSounds;

namespace vsrpp_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PlaySound.PlayAsterisk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaySound.PlayBeep();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlaySound.PlayExclamation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlaySound.PlayHand();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlaySound.PlayQuestion();
        }
    }
}
