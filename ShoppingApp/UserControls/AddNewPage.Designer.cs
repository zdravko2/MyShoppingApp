namespace ShoppingApp.UserControls
{
    partial class AddNewPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonCategory);
            this.panel1.Controls.Add(this.buttonProduct);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 503);
            this.panel1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add New Category"});
            this.comboBox1.Location = new System.Drawing.Point(463, 280);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 34);
            this.comboBox1.TabIndex = 25;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Image = global::ShoppingApp.Properties.Resources.icons8_close_32;
            this.buttonClose.Location = new System.Drawing.Point(1590, 20);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(40, 48);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonCategory
            // 
            this.buttonCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategory.Location = new System.Drawing.Point(495, 388);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(203, 74);
            this.buttonCategory.TabIndex = 20;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = false;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProduct.Location = new System.Drawing.Point(125, 388);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(203, 74);
            this.buttonProduct.TabIndex = 0;
            this.buttonProduct.Text = "Product";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(145, 56);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(572, 118);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Add Product or select a category to edit";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(463, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select category:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddNewPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.panel1);
            this.MainControl = this.panel1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddNewPage";
            this.Size = new System.Drawing.Size(1366, 726);
            this.Resize += new System.EventHandler(this.AddNewPage_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonClose;
        private Button buttonCategory;
        private Button buttonProduct;
        private Label labelTitle;
        private ComboBox comboBox1;
        private Label label1;
    }
}
