﻿namespace Ludum_Dare_41
{
    partial class LD41
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inac1 = new System.Windows.Forms.TextBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.cmdInput = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inac1
            // 
            this.inac1.BackColor = System.Drawing.Color.Black;
            this.inac1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inac1.Enabled = false;
            this.inac1.Font = new System.Drawing.Font("Monotxt_IV25", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inac1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.inac1.Location = new System.Drawing.Point(12, 329);
            this.inac1.Name = "inac1";
            this.inac1.ReadOnly = true;
            this.inac1.ShortcutsEnabled = false;
            this.inac1.Size = new System.Drawing.Size(24, 46);
            this.inac1.TabIndex = 2;
            this.inac1.Text = ">";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(284, 135);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(45, 45);
            this.player.TabIndex = 40;
            this.player.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Gray;
            this.background.Image = global::Ludum_Dare_41.Properties.Resources.rm1;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(705, 314);
            this.background.TabIndex = 41;
            this.background.TabStop = false;
            // 
            // cmdInput
            // 
            this.cmdInput.BackColor = System.Drawing.Color.Black;
            this.cmdInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdInput.Enabled = false;
            this.cmdInput.Font = new System.Drawing.Font("Monotxt_IV25", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInput.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmdInput.Location = new System.Drawing.Point(42, 329);
            this.cmdInput.Name = "cmdInput";
            this.cmdInput.ReadOnly = true;
            this.cmdInput.ShortcutsEnabled = false;
            this.cmdInput.Size = new System.Drawing.Size(651, 46);
            this.cmdInput.TabIndex = 1;
            this.cmdInput.WordWrap = false;
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.BackColor = System.Drawing.Color.Transparent;
            this.msgBox.Font = new System.Drawing.Font("Monotxt_IV25", 27.75F, System.Drawing.FontStyle.Bold);
            this.msgBox.Location = new System.Drawing.Point(57, 195);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(0, 46);
            this.msgBox.TabIndex = 42;
            // 
            // LD41
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(705, 375);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.player);
            this.Controls.Add(this.background);
            this.Controls.Add(this.cmdInput);
            this.Controls.Add(this.inac1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(721, 414);
            this.MinimumSize = new System.Drawing.Size(721, 414);
            this.Name = "LD41";
            this.Text = "Ludum Dare 41. Theme: Combine Two Incompatable Genres.";
            this.Load += new System.EventHandler(this.LD41_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LD41_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inac1;
        public System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TextBox cmdInput;
        private System.Windows.Forms.Label msgBox;
    }
}

