namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CategoryComboBox = new ComboBox();
            ProductsListBox = new ListBox();
            CartProductsList = new ListBox();
            RemoveItemButton = new Button();
            TotalToPayTextBox = new TextBox();
            FinishOrderButton = new Button();
            AddItemButton = new Button();
            DetailsButton = new Button();
            SuspendLayout();
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(12, 12);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(121, 23);
            CategoryComboBox.TabIndex = 0;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(139, 12);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(345, 364);
            ProductsListBox.TabIndex = 1;
            // 
            // CartProductsList
            // 
            CartProductsList.FormattingEnabled = true;
            CartProductsList.ItemHeight = 15;
            CartProductsList.Location = new Point(502, 12);
            CartProductsList.Name = "CartProductsList";
            CartProductsList.Size = new Size(286, 334);
            CartProductsList.TabIndex = 2;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(502, 353);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(286, 23);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // TotalToPayTextBox
            // 
            TotalToPayTextBox.Location = new Point(502, 382);
            TotalToPayTextBox.Name = "TotalToPayTextBox";
            TotalToPayTextBox.ReadOnly = true;
            TotalToPayTextBox.Size = new Size(286, 23);
            TotalToPayTextBox.TabIndex = 4;
            TotalToPayTextBox.Text = "Total to pay: 0";
            // 
            // FinishOrderButton
            // 
            FinishOrderButton.Location = new Point(639, 415);
            FinishOrderButton.Name = "FinishOrderButton";
            FinishOrderButton.Size = new Size(149, 23);
            FinishOrderButton.TabIndex = 5;
            FinishOrderButton.Text = "Finish Order";
            FinishOrderButton.UseVisualStyleBackColor = true;
            FinishOrderButton.Click += FinishOrderButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(139, 382);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(120, 23);
            AddItemButton.TabIndex = 6;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // DetailsButton
            // 
            DetailsButton.Location = new Point(364, 381);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(120, 23);
            DetailsButton.TabIndex = 7;
            DetailsButton.Text = "Details";
            DetailsButton.UseVisualStyleBackColor = true;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DetailsButton);
            Controls.Add(AddItemButton);
            Controls.Add(FinishOrderButton);
            Controls.Add(TotalToPayTextBox);
            Controls.Add(RemoveItemButton);
            Controls.Add(CartProductsList);
            Controls.Add(ProductsListBox);
            Controls.Add(CategoryComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryComboBox;
        private ListBox ProductsListBox;
        private ListBox CartProductsList;
        private Button RemoveItemButton;
        private TextBox TotalToPayTextBox;
        private Button FinishOrderButton;
        private Button AddItemButton;
        private Button DetailsButton;
    }
}
