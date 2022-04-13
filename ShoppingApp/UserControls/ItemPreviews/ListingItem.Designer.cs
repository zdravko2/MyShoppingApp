namespace ShoppingApp.UserControls.ItemPreviews
{
    partial class ListingItem
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
            this.labelSpecifications = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPromotion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(3, 164);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(249, 43);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Product Title TextProduct Title TextProduct Title Text";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecifications
            // 
            this.labelSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSpecifications.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpecifications.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSpecifications.Location = new System.Drawing.Point(3, 213);
            this.labelSpecifications.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelSpecifications.Name = "labelSpecifications";
            this.labelSpecifications.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.labelSpecifications.Size = new System.Drawing.Size(249, 147);
            this.labelSpecifications.TabIndex = 2;
            this.labelSpecifications.Text = "‣ spec1\r\n‣ spec2\r\n‣ spec3\r\n‣ spec4\r\n‣ spec5\r\n‣ spec6\r\n‣ spec7";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Location = new System.Drawing.Point(3, 363);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(252, 28);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "1000";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelPromotion
            // 
            this.labelPromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPromotion.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.labelPromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPromotion.Location = new System.Drawing.Point(3, 394);
            this.labelPromotion.Margin = new System.Windows.Forms.Padding(0);
            this.labelPromotion.Name = "labelPromotion";
            this.labelPromotion.Size = new System.Drawing.Size(249, 26);
            this.labelPromotion.TabIndex = 4;
            this.labelPromotion.Text = "1000";
            this.labelPromotion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPromotion.Visible = false;
            // 
            // ListingItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.labelPromotion);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSpecifications);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(247)))));
            this.Name = "ListingItem";
            this.Size = new System.Drawing.Size(255, 428);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitle;
        private Label labelSpecifications;
        private Label labelPrice;
        private Label labelPromotion;
    }
}
