namespace WindowsFormsApp23
{
    partial class Form4
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
            this.position_name = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.addNewPositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // position_name
            // 
            this.position_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_name.Location = new System.Drawing.Point(100, 82);
            this.position_name.Name = "position_name";
            this.position_name.Size = new System.Drawing.Size(100, 23);
            this.position_name.TabIndex = 9;
            this.position_name.Text = "Position";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(195, 83);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 10;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(195, 132);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 12;
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary.Location = new System.Drawing.Point(100, 131);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 23);
            this.salary.TabIndex = 11;
            this.salary.Text = "Salary";
            // 
            // addNewPositionButton
            // 
            this.addNewPositionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewPositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewPositionButton.Location = new System.Drawing.Point(339, 95);
            this.addNewPositionButton.Name = "addNewPositionButton";
            this.addNewPositionButton.Size = new System.Drawing.Size(112, 48);
            this.addNewPositionButton.TabIndex = 13;
            this.addNewPositionButton.Text = "OK";
            this.addNewPositionButton.UseVisualStyleBackColor = false;
            this.addNewPositionButton.Click += new System.EventHandler(this.addNewPositionButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 231);
            this.Controls.Add(this.addNewPositionButton);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.position_name);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label position_name;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Button addNewPositionButton;
    }
}