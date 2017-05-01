namespace EFRestaurant.Presentation
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RestaurantListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.RecipeListBox = new System.Windows.Forms.ListBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.DeleteRecipeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddRestaurantButton = new System.Windows.Forms.Button();
            this.EditRestaurantButton = new System.Windows.Forms.Button();
            this.DeleteRestaurantButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.IngredientsList = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestaurantListBox
            // 
            this.RestaurantListBox.FormattingEnabled = true;
            this.RestaurantListBox.Location = new System.Drawing.Point(12, 28);
            this.RestaurantListBox.Name = "RestaurantListBox";
            this.RestaurantListBox.Size = new System.Drawing.Size(205, 251);
            this.RestaurantListBox.TabIndex = 0;
            this.RestaurantListBox.SelectedIndexChanged += new System.EventHandler(this.RestaurantListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of restaurants:";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(255, 76);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(401, 95);
            this.EmployeeListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees in the selected restaurant:";
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(255, 177);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEmployeeButton.TabIndex = 4;
            this.AddEmployeeButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddEmployeeButton, "Add a new employee to the selected restaurant.");
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(336, 177);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.EditEmployeeButton.TabIndex = 5;
            this.EditEmployeeButton.Text = "Edit";
            this.toolTip1.SetToolTip(this.EditEmployeeButton, "Edit the selected employee\'s info.");
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(420, 177);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteEmployeeButton.TabIndex = 6;
            this.DeleteEmployeeButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DeleteEmployeeButton, "Delete the selected employee.");
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // RecipeListBox
            // 
            this.RecipeListBox.FormattingEnabled = true;
            this.RecipeListBox.Location = new System.Drawing.Point(255, 219);
            this.RecipeListBox.Name = "RecipeListBox";
            this.RecipeListBox.Size = new System.Drawing.Size(240, 95);
            this.RecipeListBox.TabIndex = 7;
            this.RecipeListBox.SelectedIndexChanged += new System.EventHandler(this.RecipeListBox_SelectedIndexChanged);
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(255, 320);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.AddRecipeButton.TabIndex = 8;
            this.AddRecipeButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddRecipeButton, "Add a recipe to the selected restaurant.");
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DeleteRecipeButton
            // 
            this.DeleteRecipeButton.Location = new System.Drawing.Point(348, 320);
            this.DeleteRecipeButton.Name = "DeleteRecipeButton";
            this.DeleteRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRecipeButton.TabIndex = 10;
            this.DeleteRecipeButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DeleteRecipeButton, "Delete the selected recipe.");
            this.DeleteRecipeButton.UseVisualStyleBackColor = true;
            this.DeleteRecipeButton.Click += new System.EventHandler(this.DeleteRecipeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Recipes in the selected restaurant:";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.Location = new System.Drawing.Point(44, 285);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(126, 29);
            this.AddRestaurantButton.TabIndex = 12;
            this.AddRestaurantButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddRestaurantButton, "Add a new restaurant.");
            this.AddRestaurantButton.UseVisualStyleBackColor = true;
            this.AddRestaurantButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // EditRestaurantButton
            // 
            this.EditRestaurantButton.Location = new System.Drawing.Point(30, 320);
            this.EditRestaurantButton.Name = "EditRestaurantButton";
            this.EditRestaurantButton.Size = new System.Drawing.Size(75, 23);
            this.EditRestaurantButton.TabIndex = 13;
            this.EditRestaurantButton.Text = "Edit";
            this.toolTip1.SetToolTip(this.EditRestaurantButton, "Edit the selected restuarant.");
            this.EditRestaurantButton.UseVisualStyleBackColor = true;
            this.EditRestaurantButton.Click += new System.EventHandler(this.EditRestaurantButton_Click);
            // 
            // DeleteRestaurantButton
            // 
            this.DeleteRestaurantButton.Location = new System.Drawing.Point(111, 320);
            this.DeleteRestaurantButton.Name = "DeleteRestaurantButton";
            this.DeleteRestaurantButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRestaurantButton.TabIndex = 14;
            this.DeleteRestaurantButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DeleteRestaurantButton, "Delete the selected restaurant.");
            this.DeleteRestaurantButton.UseVisualStyleBackColor = true;
            this.DeleteRestaurantButton.Click += new System.EventHandler(this.DeleteRestaurantButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kitchen model:";
            // 
            // KitchenModelLabel
            // 
            this.KitchenModelLabel.AutoSize = true;
            this.KitchenModelLabel.Location = new System.Drawing.Point(264, 37);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(0, 13);
            this.KitchenModelLabel.TabIndex = 16;
            // 
            // IngredientsList
            // 
            this.IngredientsList.Location = new System.Drawing.Point(520, 219);
            this.IngredientsList.Name = "IngredientsList";
            this.IngredientsList.Size = new System.Drawing.Size(121, 97);
            this.IngredientsList.TabIndex = 17;
            this.IngredientsList.UseCompatibleStateImageBehavior = false;
            this.IngredientsList.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ingredients of selected recipe: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IngredientsList);
            this.Controls.Add(this.KitchenModelLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteRestaurantButton);
            this.Controls.Add(this.EditRestaurantButton);
            this.Controls.Add(this.AddRestaurantButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteRecipeButton);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.RecipeListBox);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestaurantListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MyRestaurant Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RestaurantListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.ListBox RecipeListBox;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.Button DeleteRecipeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button AddRestaurantButton;
        private System.Windows.Forms.Button EditRestaurantButton;
        private System.Windows.Forms.Button DeleteRestaurantButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KitchenModelLabel;
        private System.Windows.Forms.ListView IngredientsList;
        private System.Windows.Forms.Label label5;
    }
}

