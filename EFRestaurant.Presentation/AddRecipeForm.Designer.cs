namespace EFRestaurant.Presentation
{
    partial class AddRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecipeNameTextBoxAddRecipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExistingRecipesListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExistingIngredientsListBox = new System.Windows.Forms.ListBox();
            this.AddExistingIngredientButtonAddRecipe = new System.Windows.Forms.Button();
            this.AddNewIngredientButtonAddRecipe = new System.Windows.Forms.Button();
            this.AddNewRecipeButton = new System.Windows.Forms.Button();
            this.AddExistingRecipeButton = new System.Windows.Forms.Button();
            this.AddNewIngredientTextBoxAddRecipe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteIngredientButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteExistingRecipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preparation time:";
            // 
            // RecipeNameTextBoxAddRecipe
            // 
            this.RecipeNameTextBoxAddRecipe.Location = new System.Drawing.Point(129, 45);
            this.RecipeNameTextBoxAddRecipe.Name = "RecipeNameTextBoxAddRecipe";
            this.RecipeNameTextBoxAddRecipe.Size = new System.Drawing.Size(143, 20);
            this.RecipeNameTextBoxAddRecipe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add new:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add existing:";
            // 
            // ExistingRecipesListBox
            // 
            this.ExistingRecipesListBox.FormattingEnabled = true;
            this.ExistingRecipesListBox.Location = new System.Drawing.Point(368, 48);
            this.ExistingRecipesListBox.Name = "ExistingRecipesListBox";
            this.ExistingRecipesListBox.Size = new System.Drawing.Size(151, 199);
            this.ExistingRecipesListBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Add ingredients from existing:";
            // 
            // ExistingIngredientsListBox
            // 
            this.ExistingIngredientsListBox.FormattingEnabled = true;
            this.ExistingIngredientsListBox.Location = new System.Drawing.Point(39, 134);
            this.ExistingIngredientsListBox.Name = "ExistingIngredientsListBox";
            this.ExistingIngredientsListBox.Size = new System.Drawing.Size(143, 121);
            this.ExistingIngredientsListBox.TabIndex = 7;
            // 
            // AddExistingIngredientButtonAddRecipe
            // 
            this.AddExistingIngredientButtonAddRecipe.Location = new System.Drawing.Point(39, 261);
            this.AddExistingIngredientButtonAddRecipe.Name = "AddExistingIngredientButtonAddRecipe";
            this.AddExistingIngredientButtonAddRecipe.Size = new System.Drawing.Size(143, 23);
            this.AddExistingIngredientButtonAddRecipe.TabIndex = 8;
            this.AddExistingIngredientButtonAddRecipe.Text = "Add ingredient (to recipe)";
            this.AddExistingIngredientButtonAddRecipe.UseVisualStyleBackColor = true;
            this.AddExistingIngredientButtonAddRecipe.Click += new System.EventHandler(this.AddExistingIngredientButtonAddRecipe_Click);
            // 
            // AddNewIngredientButtonAddRecipe
            // 
            this.AddNewIngredientButtonAddRecipe.Location = new System.Drawing.Point(209, 189);
            this.AddNewIngredientButtonAddRecipe.Name = "AddNewIngredientButtonAddRecipe";
            this.AddNewIngredientButtonAddRecipe.Size = new System.Drawing.Size(124, 49);
            this.AddNewIngredientButtonAddRecipe.TabIndex = 9;
            this.AddNewIngredientButtonAddRecipe.Text = "Add new ingredient (permanently and to recipe)";
            this.AddNewIngredientButtonAddRecipe.UseVisualStyleBackColor = true;
            this.AddNewIngredientButtonAddRecipe.Click += new System.EventHandler(this.AddNewIngredientButtonAddRecipe_Click);
            // 
            // AddNewRecipeButton
            // 
            this.AddNewRecipeButton.Location = new System.Drawing.Point(236, 262);
            this.AddNewRecipeButton.Name = "AddNewRecipeButton";
            this.AddNewRecipeButton.Size = new System.Drawing.Size(97, 62);
            this.AddNewRecipeButton.TabIndex = 11;
            this.AddNewRecipeButton.Text = "Add new recipe";
            this.AddNewRecipeButton.UseVisualStyleBackColor = true;
            this.AddNewRecipeButton.Click += new System.EventHandler(this.AddNewRecipeButton_Click);
            // 
            // AddExistingRecipeButton
            // 
            this.AddExistingRecipeButton.Location = new System.Drawing.Point(390, 253);
            this.AddExistingRecipeButton.Name = "AddExistingRecipeButton";
            this.AddExistingRecipeButton.Size = new System.Drawing.Size(97, 62);
            this.AddExistingRecipeButton.TabIndex = 12;
            this.AddExistingRecipeButton.Text = "Add existing recipe";
            this.AddExistingRecipeButton.UseVisualStyleBackColor = true;
            this.AddExistingRecipeButton.Click += new System.EventHandler(this.AddExistingRecipeButton_Click);
            // 
            // AddNewIngredientTextBoxAddRecipe
            // 
            this.AddNewIngredientTextBoxAddRecipe.Location = new System.Drawing.Point(221, 163);
            this.AddNewIngredientTextBoxAddRecipe.Name = "AddNewIngredientTextBoxAddRecipe";
            this.AddNewIngredientTextBoxAddRecipe.Size = new System.Drawing.Size(100, 20);
            this.AddNewIngredientTextBoxAddRecipe.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Add new ingredient:";
            // 
            // DeleteIngredientButton
            // 
            this.DeleteIngredientButton.Location = new System.Drawing.Point(39, 290);
            this.DeleteIngredientButton.Name = "DeleteIngredientButton";
            this.DeleteIngredientButton.Size = new System.Drawing.Size(143, 34);
            this.DeleteIngredientButton.TabIndex = 15;
            this.DeleteIngredientButton.Text = "Delete ingredient (permanently)";
            this.toolTip1.SetToolTip(this.DeleteIngredientButton, "If an ingredient is added and deleted, it will be removed from every other recipe" +
        ", but a new instance of it will be made and added to the current one.");
            this.DeleteIngredientButton.UseVisualStyleBackColor = true;
            this.DeleteIngredientButton.Click += new System.EventHandler(this.DeleteIngredientButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "hours,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "minutes";
            // 
            // HoursNumericUpDown
            // 
            this.HoursNumericUpDown.Location = new System.Drawing.Point(128, 82);
            this.HoursNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.HoursNumericUpDown.Name = "HoursNumericUpDown";
            this.HoursNumericUpDown.ReadOnly = true;
            this.HoursNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.HoursNumericUpDown.TabIndex = 20;
            // 
            // MinutesNumericUpDown
            // 
            this.MinutesNumericUpDown.Location = new System.Drawing.Point(211, 82);
            this.MinutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesNumericUpDown.Name = "MinutesNumericUpDown";
            this.MinutesNumericUpDown.ReadOnly = true;
            this.MinutesNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.MinutesNumericUpDown.TabIndex = 21;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // DeleteExistingRecipeButton
            // 
            this.DeleteExistingRecipeButton.Location = new System.Drawing.Point(390, 321);
            this.DeleteExistingRecipeButton.Name = "DeleteExistingRecipeButton";
            this.DeleteExistingRecipeButton.Size = new System.Drawing.Size(97, 31);
            this.DeleteExistingRecipeButton.TabIndex = 22;
            this.DeleteExistingRecipeButton.Text = "Delete recipe";
            this.DeleteExistingRecipeButton.UseVisualStyleBackColor = true;
            this.DeleteExistingRecipeButton.Click += new System.EventHandler(this.DeleteExistingRecipeButton_Click);
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 376);
            this.Controls.Add(this.DeleteExistingRecipeButton);
            this.Controls.Add(this.MinutesNumericUpDown);
            this.Controls.Add(this.HoursNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteIngredientButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddNewIngredientTextBoxAddRecipe);
            this.Controls.Add(this.AddExistingRecipeButton);
            this.Controls.Add(this.AddNewRecipeButton);
            this.Controls.Add(this.AddNewIngredientButtonAddRecipe);
            this.Controls.Add(this.AddExistingIngredientButtonAddRecipe);
            this.Controls.Add(this.ExistingIngredientsListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExistingRecipesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecipeNameTextBoxAddRecipe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRecipeForm";
            this.Text = "Add recipe";
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RecipeNameTextBoxAddRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ExistingRecipesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ExistingIngredientsListBox;
        private System.Windows.Forms.Button AddExistingIngredientButtonAddRecipe;
        private System.Windows.Forms.Button AddNewIngredientButtonAddRecipe;
        private System.Windows.Forms.Button AddNewRecipeButton;
        private System.Windows.Forms.Button AddExistingRecipeButton;
        private System.Windows.Forms.TextBox AddNewIngredientTextBoxAddRecipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteIngredientButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown HoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinutesNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button DeleteExistingRecipeButton;
    }
}