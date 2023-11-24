namespace WindowsFormsApp23
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.createPositionButton = new System.Windows.Forms.Button();
            this.listOfEmplyeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createEmployeeButton.Location = new System.Drawing.Point(53, 79);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(169, 63);
            this.createEmployeeButton.TabIndex = 0;
            this.createEmployeeButton.Text = "create employee";
            this.createEmployeeButton.UseVisualStyleBackColor = false;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // createPositionButton
            // 
            this.createPositionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createPositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPositionButton.Location = new System.Drawing.Point(392, 79);
            this.createPositionButton.Name = "createPositionButton";
            this.createPositionButton.Size = new System.Drawing.Size(152, 62);
            this.createPositionButton.TabIndex = 1;
            this.createPositionButton.Text = "create position";
            this.createPositionButton.UseVisualStyleBackColor = false;
            this.createPositionButton.Click += new System.EventHandler(this.createPositionButton_Click);
            // 
            // listOfEmplyeesButton
            // 
            this.listOfEmplyeesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listOfEmplyeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfEmplyeesButton.Location = new System.Drawing.Point(211, 201);
            this.listOfEmplyeesButton.Name = "listOfEmplyeesButton";
            this.listOfEmplyeesButton.Size = new System.Drawing.Size(175, 53);
            this.listOfEmplyeesButton.TabIndex = 2;
            this.listOfEmplyeesButton.Text = "list of employees";
            this.listOfEmplyeesButton.UseVisualStyleBackColor = false;
            this.listOfEmplyeesButton.Click += new System.EventHandler(this.listOfEmplyeesButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 289);
            this.Controls.Add(this.listOfEmplyeesButton);
            this.Controls.Add(this.createPositionButton);
            this.Controls.Add(this.createEmployeeButton);
            this.Name = "Form1";
            this.Text = "Employee editor";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Button createPositionButton;
        private System.Windows.Forms.Button listOfEmplyeesButton;
    }
}

