namespace Bachelor_s_House
{
    partial class Meal_List
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
            this.mealListGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mealListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mealListGrid
            // 
            this.mealListGrid.AllowUserToAddRows = false;
            this.mealListGrid.AllowUserToDeleteRows = false;
            this.mealListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealListGrid.Location = new System.Drawing.Point(612, 128);
            this.mealListGrid.Name = "mealListGrid";
            this.mealListGrid.ReadOnly = true;
            this.mealListGrid.RowTemplate.Height = 28;
            this.mealListGrid.Size = new System.Drawing.Size(548, 498);
            this.mealListGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 81);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meal List";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(18, 72);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 43);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bachelor_s_House.Properties.Resources.Bengali_Thali;
            this.pictureBox1.Location = new System.Drawing.Point(18, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Meal_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mealListGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Meal_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Meal_List_FormClosing);
            this.Load += new System.EventHandler(this.Meal_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mealListGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}