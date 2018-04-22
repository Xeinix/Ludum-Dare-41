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
        // Don't forget about msgBox
        private Room[] rooms = new Room[]{

            new Room( // Room 0
            new Coordinate[] { new Coordinate(1, 3), new Coordinate(3, 1), new Coordinate(7, 3), new Coordinate(4, 4) },
            new int[] {1, 8, 2, 4},
            new Coordinate[] {new Coordinate(1,1), new Coordinate(1,2), new Coordinate(1,3), new Coordinate(1,4), new Coordinate(1,5), new Coordinate(1,6), new Coordinate(1,7), new Coordinate(1,8),
                              new Coordinate(2,1), new Coordinate(2,2), new Coordinate(2,3), new Coordinate(2,4), new Coordinate(2,5), new Coordinate(2,6), new Coordinate(2,7), new Coordinate(2,8),
                              new Coordinate(3,1), new Coordinate(3,2), new Coordinate(3,3), new Coordinate(3,4), new Coordinate(3,5), new Coordinate(3,6), new Coordinate(3,7), new Coordinate(3,8),
                              new Coordinate(4,1), new Coordinate(4,2), new Coordinate(4,3), new Coordinate(4,4), new Coordinate(4,5), new Coordinate(4,6), new Coordinate(4,7), new Coordinate(4,8),
                              new Coordinate(5,1), new Coordinate(5,2), new Coordinate(5,3), new Coordinate(5,4), new Coordinate(5,5), new Coordinate(5,6), new Coordinate(5,7), new Coordinate(5,8)},
            Properties.Resources.rm1
            )

        };
        private Room currRoom;

        private Player playerObj = new Player(new Coordinate(4,3));

        public LD41()
        {
            InitializeComponent();
            currRoom = rooms[0];
        }

        private void LD41_KeyPress(object sender, KeyPressEventArgs e)
        {
            msgBox.Text = playerObj.location.x.ToString() + playerObj.location.y.ToString();

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
                cmdInput.Text = cmdInput.Text + e.KeyChar.ToString().ToUpper();
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
                player.Location = new Point(player.Location.X + 84, player.Location.Y);
                playerObj.location = new Coordinate(playerObj.location.x + 1, playerObj.location.y);
            }
            else
            {
                player.Location = new Point(player.Location.X - 84, player.Location.Y);
                playerObj.location = new Coordinate(playerObj.location.x - 1, playerObj.location.y);
            }
            wasMessage = true;
        }

        public void MoveY(bool isPositive)
        {
            if (isPositive)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 55);
                playerObj.location = new Coordinate(playerObj.location.x, playerObj.location.y + 1);

            }
            else
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 55);
                playerObj.location = new Coordinate(playerObj.location.x, playerObj.location.y - 1);
            }
            wasMessage = true;
        }







        #region crap.

        private void LD41_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
