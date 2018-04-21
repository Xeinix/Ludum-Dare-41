using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ludum_Dare_41
{
    public partial class LD41 : Form
    {
        public LD41()
        {
            InitializeComponent();
        }

        private void LD41_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Add any code for typing into the text box.
            
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
                if (cmdInput.Text == "TYPE HELP FOR HELP" || cmdInput.Text == "INVALID COMMAND!")
                {
                    cmdInput.Text = "";
                }
                cmdInput.Text = cmdInput.Text + e.KeyChar.ToString();
            }

        }

        private void chkCMD()
        {
            string cmd = cmdInput.Text.ToLower();

            if (cmd == "help")
            {
                cmdInput.Text = "Not Implemented";
            }
            else if (cmd == "exit")
            {
                Application.Exit();
            }
            else
            {
                cmdInput.Text = "INVALID COMMAND!"; 
            }
        }

    }
}
