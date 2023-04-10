using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlapyBirds
{
    public partial class Form1 : Form
    {
        int pipiSpeed = 4;
        int gravity = 15;
        int score =0;   
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer(object sender, EventArgs e)
        {

            pictureBox_bird.Top += gravity;
            pictureBox_down.Left -= pipiSpeed;
            pictureBox_top.Left -= pipiSpeed;
            label1.Text = "SCORE:" + score;

            if (pictureBox_down.Left < -150)
            {
                pictureBox_down.Left = 800;
                score++;
            }
            if (pictureBox_top.Left < -180)
            {
                pictureBox_top.Left = 950;
                score++;
            }
            if (pictureBox_bird.Bounds.IntersectsWith(pictureBox_down.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_top.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_bot.Bounds) || pictureBox_bird.Top < -25)
            {
                EndGame();
            }
    
        }
        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "GAME OVER!";
        }

        private void pictureBox_down_Click(object sender, EventArgs e)
        {

        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }
    }
}
