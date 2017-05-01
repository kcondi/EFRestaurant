namespace EFRestaurant.Presentation
{
    partial class EditRestaurantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRestaurantForm));
            this.OkButtonEditRestaurant = new System.Windows.Forms.Button();
            this.EditRestaurantTextBox = new System.Windows.Forms.TextBox();
            this.KitchenModelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButtonEditRestaurant
            // 
            this.OkButtonEditRestaurant.Location = new System.Drawing.Point(241, 103);
            this.OkButtonEditRestaurant.Name = "OkButtonEditRestaurant";
            this.OkButtonEditRestaurant.Size = new System.Drawing.Size(75, 23);
            this.OkButtonEditRestaurant.TabIndex = 0;
            this.OkButtonEditRestaurant.Text = "Ok";
            this.OkButtonEditRestaurant.UseVisualStyleBackColor = true;
            this.OkButtonEditRestaurant.Click += new System.EventHandler(this.OkButtonEditRestaurant_Click);
            // 
            // EditRestaurantTextBox
            // 
            this.EditRestaurantTextBox.Location = new System.Drawing.Point(114, 25);
            this.EditRestaurantTextBox.Name = "EditRestaurantTextBox";
            this.EditRestaurantTextBox.Size = new System.Drawing.Size(140, 20);
            this.EditRestaurantTextBox.TabIndex = 1;
            // 
            // KitchenModelComboBox
            // 
            this.KitchenModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KitchenModelComboBox.FormattingEnabled = true;
            this.KitchenModelComboBox.Items.AddRange(new object[] {
            "Simple Sam",
            "Barbecue Set",
            "Advanced CookStation",
            "Rostfrei cooking center",
            "Restaurant master deluxe"});
            this.KitchenModelComboBox.Location = new System.Drawing.Point(114, 66);
            this.KitchenModelComboBox.Name = "KitchenModelComboBox";
            this.KitchenModelComboBox.Size = new System.Drawing.Size(140, 21);
            this.KitchenModelComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitchen model:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KitchenModelComboBox);
            this.Controls.Add(this.EditRestaurantTextBox);
            this.Controls.Add(this.OkButtonEditRestaurant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Edit selected restaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButtonEditRestaurant;
        private System.Windows.Forms.TextBox EditRestaurantTextBox;
        private System.Windows.Forms.ComboBox KitchenModelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}