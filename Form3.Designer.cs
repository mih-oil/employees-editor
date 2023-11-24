namespace WindowsFormsApp23
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nextEmployeesButton = new System.Windows.Forms.Button();
            this.previousEmployeesButton = new System.Windows.Forms.Button();
            this.employeeName = new System.Windows.Forms.Label();
            this.newEmployeeName = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.newEmployeeAge = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.deliteUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nextEmployeesButton
            // 
            this.nextEmployeesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextEmployeesButton.Location = new System.Drawing.Point(600, 406);
            this.nextEmployeesButton.Name = "nextEmployeesButton";
            this.nextEmployeesButton.Size = new System.Drawing.Size(119, 32);
            this.nextEmployeesButton.TabIndex = 1;
            this.nextEmployeesButton.Text = "next";
            this.nextEmployeesButton.UseVisualStyleBackColor = false;
            this.nextEmployeesButton.Click += new System.EventHandler(this.nextEmployeesButton_Click);
            // 
            // previousEmployeesButton
            // 
            this.previousEmployeesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.previousEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousEmployeesButton.Location = new System.Drawing.Point(91, 406);
            this.previousEmployeesButton.Name = "previousEmployeesButton";
            this.previousEmployeesButton.Size = new System.Drawing.Size(134, 32);
            this.previousEmployeesButton.TabIndex = 2;
            this.previousEmployeesButton.Text = "previous";
            this.previousEmployeesButton.UseVisualStyleBackColor = false;
            this.previousEmployeesButton.Click += new System.EventHandler(this.previousEmployeesButton_Click);
            // 
            // employeeName
            // 
            this.employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeName.Location = new System.Drawing.Point(12, 34);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(85, 22);
            this.employeeName.TabIndex = 5;
            this.employeeName.Text = "Name";
            // 
            // newEmployeeName
            // 
            this.newEmployeeName.Location = new System.Drawing.Point(103, 34);
            this.newEmployeeName.Name = "newEmployeeName";
            this.newEmployeeName.Size = new System.Drawing.Size(122, 22);
            this.newEmployeeName.TabIndex = 4;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(242, 34);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(84, 26);
            this.age.TabIndex = 7;
            this.age.Text = "Age";
            // 
            // newEmployeeAge
            // 
            this.newEmployeeAge.Location = new System.Drawing.Point(332, 34);
            this.newEmployeeAge.Name = "newEmployeeAge";
            this.newEmployeeAge.Size = new System.Drawing.Size(122, 22);
            this.newEmployeeAge.TabIndex = 6;
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position.Location = new System.Drawing.Point(477, 34);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(117, 26);
            this.position.TabIndex = 9;
            this.position.Text = "Position id";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(600, 34);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(122, 22);
            this.positionTextBox.TabIndex = 8;
            // 
            // updateUserButton
            // 
            this.updateUserButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateUserButton.Location = new System.Drawing.Point(818, 12);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(105, 36);
            this.updateUserButton.TabIndex = 10;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = false;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // deliteUserButton
            // 
            this.deliteUserButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deliteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliteUserButton.Location = new System.Drawing.Point(818, 72);
            this.deliteUserButton.Name = "deliteUserButton";
            this.deliteUserButton.Size = new System.Drawing.Size(105, 36);
            this.deliteUserButton.TabIndex = 11;
            this.deliteUserButton.Text = "Delite";
            this.deliteUserButton.UseVisualStyleBackColor = false;
            this.deliteUserButton.Click += new System.EventHandler(this.deliteUserButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.deliteUserButton);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.position);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.newEmployeeAge);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.newEmployeeName);
            this.Controls.Add(this.previousEmployeesButton);
            this.Controls.Add(this.nextEmployeesButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nextEmployeesButton;
        private System.Windows.Forms.Button previousEmployeesButton;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.TextBox newEmployeeName;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox newEmployeeAge;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button deliteUserButton;
    }
}