namespace car_rental_1
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.calculationButton = new System.Windows.Forms.Button();
            this.returncarButton = new System.Windows.Forms.Button();
            this.rentalButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.carRegButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(165, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Ayubo Drive";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoutButton);
            this.groupBox1.Controls.Add(this.calculationButton);
            this.groupBox1.Controls.Add(this.returncarButton);
            this.groupBox1.Controls.Add(this.rentalButton);
            this.groupBox1.Controls.Add(this.customerButton);
            this.groupBox1.Controls.Add(this.carRegButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(74, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the option";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutButton.Location = new System.Drawing.Point(458, 146);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(153, 33);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // calculationButton
            // 
            this.calculationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculationButton.Location = new System.Drawing.Point(260, 146);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(153, 33);
            this.calculationButton.TabIndex = 4;
            this.calculationButton.Text = "Calculation";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // returncarButton
            // 
            this.returncarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returncarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returncarButton.Location = new System.Drawing.Point(67, 146);
            this.returncarButton.Name = "returncarButton";
            this.returncarButton.Size = new System.Drawing.Size(153, 33);
            this.returncarButton.TabIndex = 3;
            this.returncarButton.Text = "Return Car";
            this.returncarButton.UseVisualStyleBackColor = true;
            this.returncarButton.Click += new System.EventHandler(this.returncarButton_Click);
            // 
            // rentalButton
            // 
            this.rentalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentalButton.Location = new System.Drawing.Point(458, 53);
            this.rentalButton.Name = "rentalButton";
            this.rentalButton.Size = new System.Drawing.Size(153, 33);
            this.rentalButton.TabIndex = 2;
            this.rentalButton.Text = "Rental";
            this.rentalButton.UseVisualStyleBackColor = true;
            this.rentalButton.Click += new System.EventHandler(this.rentalButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerButton.Location = new System.Drawing.Point(260, 53);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(153, 33);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // carRegButton
            // 
            this.carRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRegButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carRegButton.Location = new System.Drawing.Point(67, 53);
            this.carRegButton.Name = "carRegButton";
            this.carRegButton.Size = new System.Drawing.Size(153, 33);
            this.carRegButton.TabIndex = 0;
            this.carRegButton.Text = "Car Registration";
            this.carRegButton.UseVisualStyleBackColor = true;
            this.carRegButton.Click += new System.EventHandler(this.carRegButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Button returncarButton;
        private System.Windows.Forms.Button rentalButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button carRegButton;
    }
}