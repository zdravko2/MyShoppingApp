namespace ShoppingApp.UserControls.ItemPreviews
{
    partial class CartItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPromotion = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.checkBoxSelected = new System.Windows.Forms.CheckBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(247)))));
            this.labelTitle.Location = new System.Drawing.Point(166, 3);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(207, 48);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Product Title Text";
            // 
            // labelPromotion
            // 
            this.labelPromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPromotion.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.labelPromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPromotion.Location = new System.Drawing.Point(352, 31);
            this.labelPromotion.Margin = new System.Windows.Forms.Padding(0);
            this.labelPromotion.Name = "labelPromotion";
            this.labelPromotion.Size = new System.Drawing.Size(114, 20);
            this.labelPromotion.TabIndex = 6;
            this.labelPromotion.Text = "1000";
            this.labelPromotion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPromotion.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Location = new System.Drawing.Point(352, 3);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(114, 25);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "1000";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(352, 61);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRemove.Size = new System.Drawing.Size(134, 41);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // checkBoxSelected
            // 
            this.checkBoxSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSelected.AutoSize = true;
            this.checkBoxSelected.Checked = true;
            this.checkBoxSelected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelected.Location = new System.Drawing.Point(471, 3);
            this.checkBoxSelected.Name = "checkBoxSelected";
            this.checkBoxSelected.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSelected.TabIndex = 8;
            this.checkBoxSelected.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuantity.DisplayMember = "int";
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxQuantity.Location = new System.Drawing.Point(289, 72);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(51, 23);
            this.comboBoxQuantity.TabIndex = 9;
            this.comboBoxQuantity.Text = "1";
            this.comboBoxQuantity.TextChanged += new System.EventHandler(this.comboBoxQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(209, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity:";
            // 
            // CartItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.checkBoxSelected);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelPromotion);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(489, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitle;
        private Label labelPromotion;
        private Label labelPrice;
        public Button buttonRemove;
        public CheckBox checkBoxSelected;
        public ComboBox comboBoxQuantity;
        private Label label1;
    }
}
