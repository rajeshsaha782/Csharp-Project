namespace Bachelor_s_House
{
    partial class Change_Password
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
            if(disposing && (components != null))
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
            this.back = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.old_Pass = new System.Windows.Forms.Label();
            this.o_Pass = new System.Windows.Forms.TextBox();
            this.n_Pass = new System.Windows.Forms.TextBox();
            this.new_Pass = new System.Windows.Forms.Label();
            this.c_Pass = new System.Windows.Forms.TextBox();
            this.confirm_Pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.RoyalBlue;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(778, 549);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(144, 52);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(956, 549);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(144, 52);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // old_Pass
            // 
            this.old_Pass.AutoSize = true;
            this.old_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_Pass.Location = new System.Drawing.Point(772, 117);
            this.old_Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.old_Pass.Name = "old_Pass";
            this.old_Pass.Size = new System.Drawing.Size(155, 26);
            this.old_Pass.TabIndex = 2;
            this.old_Pass.Text = "Old Password";
            // 
            // o_Pass
            // 
            this.o_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_Pass.Location = new System.Drawing.Point(778, 169);
            this.o_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.o_Pass.Name = "o_Pass";
            this.o_Pass.PasswordChar = '*';
            this.o_Pass.Size = new System.Drawing.Size(319, 35);
            this.o_Pass.TabIndex = 3;
            // 
            // n_Pass
            // 
            this.n_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_Pass.Location = new System.Drawing.Point(778, 298);
            this.n_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n_Pass.Name = "n_Pass";
            this.n_Pass.PasswordChar = '*';
            this.n_Pass.Size = new System.Drawing.Size(319, 35);
            this.n_Pass.TabIndex = 5;
            // 
            // new_Pass
            // 
            this.new_Pass.AutoSize = true;
            this.new_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Pass.Location = new System.Drawing.Point(772, 246);
            this.new_Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_Pass.Name = "new_Pass";
            this.new_Pass.Size = new System.Drawing.Size(161, 26);
            this.new_Pass.TabIndex = 4;
            this.new_Pass.Text = "New Password";
            // 
            // c_Pass
            // 
            this.c_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Pass.Location = new System.Drawing.Point(782, 414);
            this.c_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_Pass.Name = "c_Pass";
            this.c_Pass.PasswordChar = '*';
            this.c_Pass.Size = new System.Drawing.Size(316, 35);
            this.c_Pass.TabIndex = 7;
            // 
            // confirm_Pass
            // 
            this.confirm_Pass.AutoSize = true;
            this.confirm_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_Pass.Location = new System.Drawing.Point(772, 366);
            this.confirm_Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirm_Pass.Name = "confirm_Pass";
            this.confirm_Pass.Size = new System.Drawing.Size(202, 26);
            this.confirm_Pass.TabIndex = 6;
            this.confirm_Pass.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 55);
            this.label3.TabIndex = 27;
            this.label3.Text = "Change Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bachelor_s_House.Properties.Resources.hack_passwords_using_usb_735x400;
            this.pictureBox1.Location = new System.Drawing.Point(18, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_Pass);
            this.Controls.Add(this.confirm_Pass);
            this.Controls.Add(this.n_Pass);
            this.Controls.Add(this.new_Pass);
            this.Controls.Add(this.o_Pass);
            this.Controls.Add(this.old_Pass);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Change_Password_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label old_Pass;
        private System.Windows.Forms.TextBox o_Pass;
        private System.Windows.Forms.TextBox n_Pass;
        private System.Windows.Forms.Label new_Pass;
        private System.Windows.Forms.TextBox c_Pass;
        private System.Windows.Forms.Label confirm_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}