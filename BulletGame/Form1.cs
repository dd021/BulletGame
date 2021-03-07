using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletGame
{
    public partial class Form1 : Form
    {
        private GameLogic logic;
        private int bullet;
        private SoundPlayer player;
        private int win, lose;

        public Form1()
        {
            InitializeComponent();
            
            DisableGameButtons();
        }

        /// <summary>
        /// Method for disable button which are used in to play games
        /// and update the Result Score...
        /// </summary>
        public void DisableGameButtons()
        {
            buttonLoad.Enabled = false;
            buttonFire.Enabled = false;
            buttonSkipFire.Enabled = false;
            buttonSpin.Enabled = false;
            lblResult.Text = "WIN: " + win + " LOSE: " + lose;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Process the Load Bullet Process
            logic.LoadBullet();
            
            buttonLoad.Enabled = false;
            buttonSpin.Enabled = true;
            pictureGame.Image = Properties.Resources.loaded;
            MessageBox.Show("Bullet is Loaded");
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
            // Spin the Chamber for update the position of bullet in random order
            logic.SpinChambers();
            pictureGame.Image = Properties.Resources.spins;
            buttonSpin.Enabled = false;
            buttonFire.Enabled = true;
            buttonSkipFire.Enabled = true;
            player = new SoundPlayer(Properties.Resources.spin);
            player.Play();
            MessageBox.Show("Now Bullet is Shuffled by spinning");
            pictureGame.Image = Properties.Resources.point_to_head;
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (logic.FireTheBullet(bullet))
            {
                // Display Dead Image
                pictureGame.Image = Properties.Resources.dead;
                // Code For Playing the Sound
                player = new SoundPlayer(Properties.Resources.Revolver);
                player.Play();
                lose++;
                MessageBox.Show("You Lose this Game...");
                DisableGameButtons();
                buttonPlayGame.Enabled = true;
                pictureGame.Image = Properties.Resources.empty;

            }
            else
            {
                // Code For Playing the Sound
                player = new SoundPlayer(Properties.Resources.Chamber);
                player.Play();
                bullet++;
                MessageBox.Show("You are Lucky!!!");
            }
            if (bullet == 4)
            {
                // Change the Win Picture
                pictureGame.Image = Properties.Resources.win;
                win++;
                MessageBox.Show("You Win this Game...");
                DisableGameButtons();
                buttonPlayGame.Enabled = true;
                pictureGame.Image = Properties.Resources.empty;
            }

        }

        private void buttonSkipFire_Click(object sender, EventArgs e)
        {
            // Skip the current fire if person has hinch 
            bullet++;
            MessageBox.Show("You Skip This Fire...");
            // Disable Skip Fire Button the game
            buttonSkipFire.Enabled = false;
            // If Player check its luck four times
            if (bullet == 4)
            {
                // Change the Current Win picture
                pictureGame.Image = Properties.Resources.win;
                win++;
                MessageBox.Show("You Win this Game...");
                DisableGameButtons();
                buttonPlayGame.Enabled = true;
                // Change the empty picture
                pictureGame.Image = Properties.Resources.empty;
            }
        }

        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            // Code For reset the Game and play again
            logic = new GameLogic();
            bullet = 1;
            // Change the Current situation picture
            pictureGame.Image = Properties.Resources.empty;
            buttonPlayGame.Enabled = false;
            DisableGameButtons();
            buttonLoad.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
