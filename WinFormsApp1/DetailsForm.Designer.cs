namespace WinFormsApp1
{
    partial class DetailsForm
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
            ProductsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Dock = DockStyle.Fill;
            ProductsDataGridView.Location = new Point(0, 0);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.Size = new Size(584, 450);
            ProductsDataGridView.TabIndex = 0;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(ProductsDataGridView);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGridView;
    }
}