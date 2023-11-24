namespace WindowsFormsApp23
{
    partial class Form2
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
            this.newEmployeeName = new System.Windows.Forms.TextBox();
            this.newEmployeeAge = new System.Windows.Forms.TextBox();
            this.employeeName = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.addingNewEmployeeButton = new System.Windows.Forms.Button();
            this.positionsComboBox = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newEmployeeName
            // 
            this.newEmployeeName.Location = new System.Drawing.Point(244, 64);
            this.newEmployeeName.Name = "newEmployeeName";
            this.newEmployeeName.Size = new System.Drawing.Size(122, 22);
            this.newEmployeeName.TabIndex = 0;
            this.newEmployeeName.TextChanged += new System.EventHandler(this.newEmployeeName_TextChanged);
            // 
            // newEmployeeAge
            // 
            this.newEmployeeAge.Location = new System.Drawing.Point(244, 121);
            this.newEmployeeAge.Name = "newEmployeeAge";
            this.newEmployeeAge.Size = new System.Drawing.Size(122, 22);
            this.newEmployeeAge.TabIndex = 1;
            this.newEmployeeAge.TextChanged += new System.EventHandler(this.newEmployeeAge_TextChanged);
            // 
            // employeeName
            // 
            this.employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeName.Location = new System.Drawing.Point(77, 64);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(122, 22);
            this.employeeName.TabIndex = 3;
            this.employeeName.Text = "Name";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(77, 121);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 26);
            this.age.TabIndex = 5;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.label1_Click);
            // 
            // addingNewEmployeeButton
            // 
            this.addingNewEmployeeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addingNewEmployeeButton.Location = new System.Drawing.Point(447, 110);
            this.addingNewEmployeeButton.Name = "addingNewEmployeeButton";
            this.addingNewEmployeeButton.Size = new System.Drawing.Size(75, 44);
            this.addingNewEmployeeButton.TabIndex = 6;
            this.addingNewEmployeeButton.Text = "OK";
            this.addingNewEmployeeButton.UseVisualStyleBackColor = false;
            this.addingNewEmployeeButton.Click += new System.EventHandler(this.addingNewEmployeeButton_Click);
            // 
            // positionsComboBox
            // 
            this.positionsComboBox.FormattingEnabled = true;
            this.positionsComboBox.Location = new System.Drawing.Point(245, 185);
            this.positionsComboBox.Name = "positionsComboBox";
            this.positionsComboBox.Size = new System.Drawing.Size(121, 24);
            this.positionsComboBox.TabIndex = 7;
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position.Location = new System.Drawing.Point(77, 186);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(100, 23);
            this.position.TabIndex = 8;
            this.position.Text = "Position";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 269);
            this.Controls.Add(this.position);
            this.Controls.Add(this.positionsComboBox);
            this.Controls.Add(this.addingNewEmployeeButton);
            this.Controls.Add(this.age);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.newEmployeeAge);
            this.Controls.Add(this.newEmployeeName);
            this.Name = "Form2";
            this.Text = "Adding new employee";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newEmployeeName;
        private System.Windows.Forms.TextBox newEmployeeAge;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Button addingNewEmployeeButton;
        private System.Windows.Forms.ComboBox positionsComboBox;
        private System.Windows.Forms.Label position;
    }
}