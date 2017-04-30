namespace EFRestaurant.Presentation
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
            this.NewRestaurantTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButtonNewRestaurant = new System.Windows.Forms.Button();
            this.KitchenModelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewRestaurantTextBox
            // 
            this.NewRestaurantTextBox.Location = new System.Drawing.Point(114, 25);
            this.NewRestaurantTextBox.Name = "NewRestaurantTextBox";
            this.NewRestaurantTextBox.Size = new System.Drawing.Size(140, 20);
            this.NewRestaurantTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OkButtonNewRestaurant
            // 
            this.OkButtonNewRestaurant.Location = new System.Drawing.Point(241, 103);
            this.OkButtonNewRestaurant.Name = "OkButtonNewRestaurant";
            this.OkButtonNewRestaurant.Size = new System.Drawing.Size(75, 23);
            this.OkButtonNewRestaurant.TabIndex = 2;
            this.OkButtonNewRestaurant.Text = "Ok";
            this.OkButtonNewRestaurant.UseVisualStyleBackColor = true;
            this.OkButtonNewRestaurant.Click += new System.EventHandler(this.OkButtonNewRestaurant_Click);
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
            this.KitchenModelComboBox.TabIndex = 3;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KitchenModelComboBox);
            this.Controls.Add(this.OkButtonNewRestaurant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewRestaurantTextBox);
            this.Name = "Form2";
            this.Text = "Add new restaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewRestaurantTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButtonNewRestaurant;
        private System.Windows.Forms.ComboBox KitchenModelComboBox;
        private System.Windows.Forms.Label label2;
    }
}