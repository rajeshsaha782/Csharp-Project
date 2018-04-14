namespace Bachelor_s_House
{
    partial class Total_Calculation
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
            this.MealRate = new System.Windows.Forms.Label();
            this.TotalMeal = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.TotalData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TotalData)).BeginInit();
            this.SuspendLayout();
            // 
            // MealRate
            // 
            this.MealRate.AutoSize = true;
            this.MealRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MealRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealRate.ForeColor = System.Drawing.Color.Red;
            this.MealRate.Location = new System.Drawing.Point(12, 189);
            this.MealRate.Name = "MealRate";
            this.MealRate.Size = new System.Drawing.Size(109, 25);
            this.MealRate.TabIndex = 22;
            this.MealRate.Text = "Meal Rate";
            // 
            // TotalMeal
            // 
            this.TotalMeal.AutoSize = true;
            this.TotalMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMeal.Location = new System.Drawing.Point(14, 140);
            this.TotalMeal.Name = "TotalMeal";
            this.TotalMeal.Size = new System.Drawing.Size(137, 29);
            this.TotalMeal.TabIndex = 21;
            this.TotalMeal.Text = "Total Meal";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost.Location = new System.Drawing.Point(14, 95);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(133, 29);
            this.TotalCost.TabIndex = 20;
            this.TotalCost.Text = "Total Cost";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(16, 358);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(124, 49);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(16, 462);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(124, 49);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // TotalData
            // 
            this.TotalData.AllowUserToAddRows = false;
            this.TotalData.AllowUserToDeleteRows = false;
            this.TotalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalData.Location = new System.Drawing.Point(237, 20);
            this.TotalData.Name = "TotalData";
            this.TotalData.ReadOnly = true;
            this.TotalData.RowTemplate.Height = 28;
            this.TotalData.Size = new System.Drawing.Size(929, 612);
            this.TotalData.TabIndex = 17;
            // 
            // Total_Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.MealRate);
            this.Controls.Add(this.TotalMeal);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.TotalData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Total_Calculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Calculation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Total_Calculation_FormClosing);
            this.Load += new System.EventHandler(this.Total_Calculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MealRate;
        private System.Windows.Forms.Label TotalMeal;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.DataGridView TotalData;
    }
}