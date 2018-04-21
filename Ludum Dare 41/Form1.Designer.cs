namespace Ludum_Dare_41
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
            this.cmdInput = new System.Windows.Forms.TextBox();
            this.inac1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdInput
            // 
            this.cmdInput.BackColor = System.Drawing.Color.Black;
            this.cmdInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdInput.Enabled = false;
            this.cmdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInput.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmdInput.Location = new System.Drawing.Point(78, 369);
            this.cmdInput.Name = "cmdInput";
            this.cmdInput.ReadOnly = true;
            this.cmdInput.ShortcutsEnabled = false;
            this.cmdInput.Size = new System.Drawing.Size(654, 55);
            this.cmdInput.TabIndex = 1;
            this.cmdInput.Text = "TYPE HELP FOR HELP";
            this.cmdInput.WordWrap = false;
            // 
            // inac1
            // 
            this.inac1.BackColor = System.Drawing.Color.Black;
            this.inac1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inac1.Enabled = false;
            this.inac1.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inac1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.inac1.Location = new System.Drawing.Point(30, 365);
            this.inac1.Name = "inac1";
            this.inac1.ReadOnly = true;
            this.inac1.ShortcutsEnabled = false;
            this.inac1.Size = new System.Drawing.Size(42, 59);
            this.inac1.TabIndex = 2;
            this.inac1.Text = ">";
            // 
            // LD41
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(744, 436);
            this.Controls.Add(this.inac1);
            this.Controls.Add(this.cmdInput);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 475);
            this.MinimumSize = new System.Drawing.Size(760, 475);
            this.Name = "LD41";
            this.Text = "Ludum Dare 41. Theme: Combine Two Incompatable Genres.";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LD41_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cmdInput;
        private System.Windows.Forms.TextBox inac1;
    }
}

