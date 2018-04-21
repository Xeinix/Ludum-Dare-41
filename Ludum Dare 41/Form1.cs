using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Ludum_Dare_41
{
    public partial class LD41 : Form
    {

        public bool wasMessage = true;

        public LD41()
        {
            InitializeComponent();
        }

        private void LD41_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Text Box Code
            if (e.KeyChar == (char)13)
            {
                chkCMD();
            }
            else if (e.KeyChar == (char)8)
            {
                if (String.IsNullOrEmpty(cmdInput.Text)) return;
                else cmdInput.Text = cmdInput.Text.Remove(cmdInput.Text.Length - 1, 1);
            }
            else if (cmdInput.Text.Length < 23)
            {
                if (wasMessage)
                {
                    cmdInput.Text = "";
                    wasMessage = false;
                }
                cmdInput.Text = cmdInput.Text + e.KeyChar.ToString();
            }
            #endregion
        }

        private void chkCMD()
        {
            string cmd = cmdInput.Text.ToLower();

            if (cmd == "help")
            {
                cmdInput.Text = "Not Implemented";
                wasMessage = true;
            }
            else if (cmd == "exit")
            {
                Application.Exit();
            }
            else if (cmd == "move up")
            {
                MoveY(false);
            }
            else if (cmd == "move down")
            {
                MoveY(true);
            }
            else if (cmd == "move left")
            {
                MoveX(false);
            }
            else if (cmd == "move right")
            {
                MoveX(true);
            }
            else
            {
                cmdInput.Text = "INVALID COMMAND!";
                wasMessage = true;
            }
        }

        public void MoveX(bool isPositive)
        {
            if (isPositive)
            {
                player.Location = new Point(player.Location.X + 108, player.Location.Y);
            }
            else
            {
                player.Location = new Point(player.Location.X - 52, player.Location.Y);
                player.Location = new Point(player.Location.X - 51, player.Location.Y);
            }
            cmdInput.Text = "TYPE \"HELP\" FOR HELP";
        }

        public void MoveY(bool isPositive)
        {
            if (isPositive)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 64);
                player.Location = new Point(player.Location.X, player.Location.Y + 32);

            }
            else
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 32);
                player.Location = new Point(player.Location.X, player.Location.Y - 32);
            }
            cmdInput.Text = "TYPE \"HELP\" FOR HELP";
        }









        private void LD41_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
