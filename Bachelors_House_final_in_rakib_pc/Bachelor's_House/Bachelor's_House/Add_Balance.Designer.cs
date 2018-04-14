namespace Bachelor_s_House
{
    partial class Add_Balance
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
            this.Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deduct = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IdMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(902, 222);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(200, 40);
            this.Id.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(902, 308);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(200, 40);
            this.Amount.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Amount";
            // 
            // Deduct
            // 
            this.Deduct.BackColor = System.Drawing.Color.DarkRed;
            this.Deduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Deduct.Location = new System.Drawing.Point(1047, 483);
            this.Deduct.Name = "Deduct";
            this.Deduct.Size = new System.Drawing.Size(112, 65);
            this.Deduct.TabIndex = 23;
            this.Deduct.Text = "Deduct";
            this.Deduct.UseVisualStyleBackColor = false;
            this.Deduct.Click += new System.EventHandler(this.Deduct_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(902, 483);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 65);
            this.back.TabIndex = 22;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkGreen;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(760, 483);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 65);
            this.Add.TabIndex = 24;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(669, 81);
            this.label3.TabIndex = 25;
            this.label3.Text = "Add/Deduct Balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bachelor_s_House.Properties.Resources.hand_giving_money_17748157;
            this.pictureBox1.Location = new System.Drawing.Point(38, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // IdMessage
            // 
            this.IdMessage.AutoSize = true;
            this.IdMessage.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMessage.ForeColor = System.Drawing.Color.Red;
            this.IdMessage.Location = new System.Drawing.Point(944, 269);
            this.IdMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdMessage.Name = "IdMessage";
            this.IdMessage.Size = new System.Drawing.Size(160, 19);
            this.IdMessage.TabIndex = 27;
            this.IdMessage.Text = "*Please fill up your id";
            this.IdMessage.Visible = false;
            // 
            // Add_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.IdMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Deduct);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Add_Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Deduct Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Balance_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deduct;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IdMessage;
    }
}