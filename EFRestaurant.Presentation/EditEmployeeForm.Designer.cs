namespace EFRestaurant.Presentation
{
    partial class EditEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeForm));
            this.OIBTextBoxEditEmployee = new System.Windows.Forms.TextBox();
            this.FirstNameTextBoxEditEmployee = new System.Windows.Forms.TextBox();
            this.LastNameTextBoxEditEmployee = new System.Windows.Forms.TextBox();
            this.BirthYearUpDownEditEmployee = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeRoleGroupBoxEditEmployee = new System.Windows.Forms.GroupBox();
            this.MasterChefRadioEditEmployee = new System.Windows.Forms.RadioButton();
            this.WaiterRadioEditEmployee = new System.Windows.Forms.RadioButton();
            this.AssistantChefRadioEditEmployee = new System.Windows.Forms.RadioButton();
            this.OkButtonEditEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BirthYearUpDownEditEmployee)).BeginInit();
            this.EmployeeRoleGroupBoxEditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // OIBTextBoxEditEmployee
            // 
            this.OIBTextBoxEditEmployee.Location = new System.Drawing.Point(140, 28);
            this.OIBTextBoxEditEmployee.Name = "OIBTextBoxEditEmployee";
            this.OIBTextBoxEditEmployee.Size = new System.Drawing.Size(120, 20);
            this.OIBTextBoxEditEmployee.TabIndex = 1;
            // 
            // FirstNameTextBoxEditEmployee
            // 
            this.FirstNameTextBoxEditEmployee.Location = new System.Drawing.Point(140, 55);
            this.FirstNameTextBoxEditEmployee.Name = "FirstNameTextBoxEditEmployee";
            this.FirstNameTextBoxEditEmployee.Size = new System.Drawing.Size(120, 20);
            this.FirstNameTextBoxEditEmployee.TabIndex = 2;
            // 
            // LastNameTextBoxEditEmployee
            // 
            this.LastNameTextBoxEditEmployee.Location = new System.Drawing.Point(140, 83);
            this.LastNameTextBoxEditEmployee.Name = "LastNameTextBoxEditEmployee";
            this.LastNameTextBoxEditEmployee.Size = new System.Drawing.Size(120, 20);
            this.LastNameTextBoxEditEmployee.TabIndex = 3;
            // 
            // BirthYearUpDownEditEmployee
            // 
            this.BirthYearUpDownEditEmployee.Location = new System.Drawing.Point(140, 118);
            this.BirthYearUpDownEditEmployee.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.BirthYearUpDownEditEmployee.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.BirthYearUpDownEditEmployee.Name = "BirthYearUpDownEditEmployee";
            this.BirthYearUpDownEditEmployee.ReadOnly = true;
            this.BirthYearUpDownEditEmployee.Size = new System.Drawing.Size(120, 20);
            this.BirthYearUpDownEditEmployee.TabIndex = 7;
            this.BirthYearUpDownEditEmployee.Value = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "OIB*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last name*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birth year:";
            // 
            // EmployeeRoleGroupBoxEditEmployee
            // 
            this.EmployeeRoleGroupBoxEditEmployee.Controls.Add(this.MasterChefRadioEditEmployee);
            this.EmployeeRoleGroupBoxEditEmployee.Controls.Add(this.WaiterRadioEditEmployee);
            this.EmployeeRoleGroupBoxEditEmployee.Controls.Add(this.AssistantChefRadioEditEmployee);
            this.EmployeeRoleGroupBoxEditEmployee.Location = new System.Drawing.Point(26, 179);
            this.EmployeeRoleGroupBoxEditEmployee.Name = "EmployeeRoleGroupBoxEditEmployee";
            this.EmployeeRoleGroupBoxEditEmployee.Size = new System.Drawing.Size(200, 100);
            this.EmployeeRoleGroupBoxEditEmployee.TabIndex = 12;
            this.EmployeeRoleGroupBoxEditEmployee.TabStop = false;
            this.EmployeeRoleGroupBoxEditEmployee.Text = "Employee role";
            // 
            // MasterChefRadioEditEmployee
            // 
            this.MasterChefRadioEditEmployee.AutoSize = true;
            this.MasterChefRadioEditEmployee.Location = new System.Drawing.Point(21, 31);
            this.MasterChefRadioEditEmployee.Name = "MasterChefRadioEditEmployee";
            this.MasterChefRadioEditEmployee.Size = new System.Drawing.Size(81, 17);
            this.MasterChefRadioEditEmployee.TabIndex = 8;
            this.MasterChefRadioEditEmployee.TabStop = true;
            this.MasterChefRadioEditEmployee.Text = "Master chef";
            this.MasterChefRadioEditEmployee.UseVisualStyleBackColor = true;
            // 
            // WaiterRadioEditEmployee
            // 
            this.WaiterRadioEditEmployee.AutoSize = true;
            this.WaiterRadioEditEmployee.Location = new System.Drawing.Point(21, 77);
            this.WaiterRadioEditEmployee.Name = "WaiterRadioEditEmployee";
            this.WaiterRadioEditEmployee.Size = new System.Drawing.Size(56, 17);
            this.WaiterRadioEditEmployee.TabIndex = 10;
            this.WaiterRadioEditEmployee.TabStop = true;
            this.WaiterRadioEditEmployee.Text = "Waiter";
            this.WaiterRadioEditEmployee.UseVisualStyleBackColor = true;
            // 
            // AssistantChefRadioEditEmployee
            // 
            this.AssistantChefRadioEditEmployee.AutoSize = true;
            this.AssistantChefRadioEditEmployee.Location = new System.Drawing.Point(21, 54);
            this.AssistantChefRadioEditEmployee.Name = "AssistantChefRadioEditEmployee";
            this.AssistantChefRadioEditEmployee.Size = new System.Drawing.Size(91, 17);
            this.AssistantChefRadioEditEmployee.TabIndex = 9;
            this.AssistantChefRadioEditEmployee.TabStop = true;
            this.AssistantChefRadioEditEmployee.Text = "Assistant chef";
            this.AssistantChefRadioEditEmployee.UseVisualStyleBackColor = true;
            // 
            // OkButtonEditEmployee
            // 
            this.OkButtonEditEmployee.Location = new System.Drawing.Point(303, 250);
            this.OkButtonEditEmployee.Name = "OkButtonEditEmployee";
            this.OkButtonEditEmployee.Size = new System.Drawing.Size(75, 23);
            this.OkButtonEditEmployee.TabIndex = 13;
            this.OkButtonEditEmployee.Text = "Ok";
            this.OkButtonEditEmployee.UseVisualStyleBackColor = true;
            this.OkButtonEditEmployee.Click += new System.EventHandler(this.OkButtonEditEmployee_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 316);
            this.Controls.Add(this.OkButtonEditEmployee);
            this.Controls.Add(this.EmployeeRoleGroupBoxEditEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthYearUpDownEditEmployee);
            this.Controls.Add(this.LastNameTextBoxEditEmployee);
            this.Controls.Add(this.FirstNameTextBoxEditEmployee);
            this.Controls.Add(this.OIBTextBoxEditEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Edit employee";
            ((System.ComponentModel.ISupportInitialize)(this.BirthYearUpDownEditEmployee)).EndInit();
            this.EmployeeRoleGroupBoxEditEmployee.ResumeLayout(false);
            this.EmployeeRoleGroupBoxEditEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OIBTextBoxEditEmployee;
        private System.Windows.Forms.TextBox FirstNameTextBoxEditEmployee;
        private System.Windows.Forms.TextBox LastNameTextBoxEditEmployee;
        private System.Windows.Forms.NumericUpDown BirthYearUpDownEditEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox EmployeeRoleGroupBoxEditEmployee;
        private System.Windows.Forms.RadioButton MasterChefRadioEditEmployee;
        private System.Windows.Forms.RadioButton WaiterRadioEditEmployee;
        private System.Windows.Forms.RadioButton AssistantChefRadioEditEmployee;
        private System.Windows.Forms.Button OkButtonEditEmployee;
    }
}