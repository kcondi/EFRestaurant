namespace EFRestaurant.Presentation
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.OIBTextBoxAddEmployee = new System.Windows.Forms.TextBox();
            this.FirstNameTextBoxAddEmployee = new System.Windows.Forms.TextBox();
            this.LastNameTextBoxAddEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthYearUpDownAddEmployee = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MasterChefRadioAddEmployee = new System.Windows.Forms.RadioButton();
            this.AssistantChefRadioAddEmployee = new System.Windows.Forms.RadioButton();
            this.WaiterRadioAddEmployee = new System.Windows.Forms.RadioButton();
            this.EmployeeRoleGroupBoxAddEmployee = new System.Windows.Forms.GroupBox();
            this.OkButtonAddEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BirthYearUpDownAddEmployee)).BeginInit();
            this.EmployeeRoleGroupBoxAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // OIBTextBoxAddEmployee
            // 
            this.OIBTextBoxAddEmployee.Location = new System.Drawing.Point(140, 28);
            this.OIBTextBoxAddEmployee.Name = "OIBTextBoxAddEmployee";
            this.OIBTextBoxAddEmployee.Size = new System.Drawing.Size(120, 20);
            this.OIBTextBoxAddEmployee.TabIndex = 0;
            // 
            // FirstNameTextBoxAddEmployee
            // 
            this.FirstNameTextBoxAddEmployee.Location = new System.Drawing.Point(140, 55);
            this.FirstNameTextBoxAddEmployee.Name = "FirstNameTextBoxAddEmployee";
            this.FirstNameTextBoxAddEmployee.Size = new System.Drawing.Size(120, 20);
            this.FirstNameTextBoxAddEmployee.TabIndex = 1;
            // 
            // LastNameTextBoxAddEmployee
            // 
            this.LastNameTextBoxAddEmployee.Location = new System.Drawing.Point(140, 83);
            this.LastNameTextBoxAddEmployee.Name = "LastNameTextBoxAddEmployee";
            this.LastNameTextBoxAddEmployee.Size = new System.Drawing.Size(120, 20);
            this.LastNameTextBoxAddEmployee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OIB*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name*:";
            // 
            // BirthYearUpDownAddEmployee
            // 
            this.BirthYearUpDownAddEmployee.Location = new System.Drawing.Point(140, 118);
            this.BirthYearUpDownAddEmployee.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.BirthYearUpDownAddEmployee.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.BirthYearUpDownAddEmployee.Name = "BirthYearUpDownAddEmployee";
            this.BirthYearUpDownAddEmployee.ReadOnly = true;
            this.BirthYearUpDownAddEmployee.Size = new System.Drawing.Size(120, 20);
            this.BirthYearUpDownAddEmployee.TabIndex = 6;
            this.BirthYearUpDownAddEmployee.Value = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birth year:";
            // 
            // MasterChefRadioAddEmployee
            // 
            this.MasterChefRadioAddEmployee.AutoSize = true;
            this.MasterChefRadioAddEmployee.Location = new System.Drawing.Point(21, 31);
            this.MasterChefRadioAddEmployee.Name = "MasterChefRadioAddEmployee";
            this.MasterChefRadioAddEmployee.Size = new System.Drawing.Size(81, 17);
            this.MasterChefRadioAddEmployee.TabIndex = 8;
            this.MasterChefRadioAddEmployee.TabStop = true;
            this.MasterChefRadioAddEmployee.Text = "Master chef";
            this.MasterChefRadioAddEmployee.UseVisualStyleBackColor = true;
            // 
            // AssistantChefRadioAddEmployee
            // 
            this.AssistantChefRadioAddEmployee.AutoSize = true;
            this.AssistantChefRadioAddEmployee.Location = new System.Drawing.Point(21, 54);
            this.AssistantChefRadioAddEmployee.Name = "AssistantChefRadioAddEmployee";
            this.AssistantChefRadioAddEmployee.Size = new System.Drawing.Size(91, 17);
            this.AssistantChefRadioAddEmployee.TabIndex = 9;
            this.AssistantChefRadioAddEmployee.TabStop = true;
            this.AssistantChefRadioAddEmployee.Text = "Assistant chef";
            this.AssistantChefRadioAddEmployee.UseVisualStyleBackColor = true;
            // 
            // WaiterRadioAddEmployee
            // 
            this.WaiterRadioAddEmployee.AutoSize = true;
            this.WaiterRadioAddEmployee.Location = new System.Drawing.Point(21, 77);
            this.WaiterRadioAddEmployee.Name = "WaiterRadioAddEmployee";
            this.WaiterRadioAddEmployee.Size = new System.Drawing.Size(56, 17);
            this.WaiterRadioAddEmployee.TabIndex = 10;
            this.WaiterRadioAddEmployee.TabStop = true;
            this.WaiterRadioAddEmployee.Text = "Waiter";
            this.WaiterRadioAddEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeRoleGroupBoxAddEmployee
            // 
            this.EmployeeRoleGroupBoxAddEmployee.Controls.Add(this.MasterChefRadioAddEmployee);
            this.EmployeeRoleGroupBoxAddEmployee.Controls.Add(this.WaiterRadioAddEmployee);
            this.EmployeeRoleGroupBoxAddEmployee.Controls.Add(this.AssistantChefRadioAddEmployee);
            this.EmployeeRoleGroupBoxAddEmployee.Location = new System.Drawing.Point(26, 179);
            this.EmployeeRoleGroupBoxAddEmployee.Name = "EmployeeRoleGroupBoxAddEmployee";
            this.EmployeeRoleGroupBoxAddEmployee.Size = new System.Drawing.Size(200, 100);
            this.EmployeeRoleGroupBoxAddEmployee.TabIndex = 11;
            this.EmployeeRoleGroupBoxAddEmployee.TabStop = false;
            this.EmployeeRoleGroupBoxAddEmployee.Text = "Employee role";
            // 
            // OkButtonAddEmployee
            // 
            this.OkButtonAddEmployee.Location = new System.Drawing.Point(303, 250);
            this.OkButtonAddEmployee.Name = "OkButtonAddEmployee";
            this.OkButtonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.OkButtonAddEmployee.TabIndex = 12;
            this.OkButtonAddEmployee.Text = "Ok";
            this.OkButtonAddEmployee.UseVisualStyleBackColor = true;
            this.OkButtonAddEmployee.Click += new System.EventHandler(this.OkButtonAddEmployee_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 316);
            this.Controls.Add(this.OkButtonAddEmployee);
            this.Controls.Add(this.EmployeeRoleGroupBoxAddEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthYearUpDownAddEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameTextBoxAddEmployee);
            this.Controls.Add(this.FirstNameTextBoxAddEmployee);
            this.Controls.Add(this.OIBTextBoxAddEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Add new employee";
            ((System.ComponentModel.ISupportInitialize)(this.BirthYearUpDownAddEmployee)).EndInit();
            this.EmployeeRoleGroupBoxAddEmployee.ResumeLayout(false);
            this.EmployeeRoleGroupBoxAddEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OIBTextBoxAddEmployee;
        private System.Windows.Forms.TextBox FirstNameTextBoxAddEmployee;
        private System.Windows.Forms.TextBox LastNameTextBoxAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BirthYearUpDownAddEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MasterChefRadioAddEmployee;
        private System.Windows.Forms.RadioButton AssistantChefRadioAddEmployee;
        private System.Windows.Forms.RadioButton WaiterRadioAddEmployee;
        private System.Windows.Forms.GroupBox EmployeeRoleGroupBoxAddEmployee;
        private System.Windows.Forms.Button OkButtonAddEmployee;
    }
}