using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace game
{
    public partial class Form1 : Form
    {
        public const int speed = 10;
        public bool left = false;
        public bool right = false;
        public bool up = false;
        public bool down = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
        }

        private void PlayerMove()
        {
            if (left | right | up | down)
            {
                SoundPlayer sound = new SoundPlayer(@"C:\Users\Rupert\Documents\College\Computer Science\game\Resources\haha.wav");
                sound.Play();
            }

            if (left)
            {
                int x = characterPb.Location.X;
                int y = characterPb.Location.Y;
                int moveSpeed = speed;
                characterPb.Location = new Point(x - moveSpeed, y);
            }
            if (right)
            {
                int x = characterPb.Location.X;
                int y = characterPb.Location.Y;
                int moveSpeed = speed;
                characterPb.Location = new Point(x + moveSpeed, y);
            }
            if (up)
            {
                int x = characterPb.Location.X;
                int y = characterPb.Location.Y;
                int moveSpeed = speed;
                characterPb.Location = new Point(x, y - moveSpeed);
            }
            if (down)
            {
                int x = characterPb.Location.X;
                int y = characterPb.Location.Y;
                int moveSpeed = speed;
                characterPb.Location = new Point(x, y + moveSpeed);
            }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            PlayerMove();
        }
    }
}
