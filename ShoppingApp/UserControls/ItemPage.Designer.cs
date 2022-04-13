namespace ShoppingApp.UserControls
{
    partial class ItemPage
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPromotion = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSpecifications = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.buttonAddToCart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelPromotion);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.labelSpecifications);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 503);
            this.panel1.TabIndex = 23;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Image = global::ShoppingApp.Properties.Resources.icons8_close_32;
            this.buttonClose.Location = new System.Drawing.Point(777, 14);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.buttonClose.Size = new System.Drawing.Size(31, 34);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(117, 399);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(185, 51);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit Product";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 264);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 101);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 78);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(124, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 78);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(245, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 78);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.buttonAddToCart.FlatAppearance.BorderSize = 0;
            this.buttonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToCart.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToCart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddToCart.Location = new System.Drawing.Point(425, 399);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(185, 51);
            this.buttonAddToCart.TabIndex = 0;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShoppingApp.Properties.Resources.image_error;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 209);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelPromotion
            // 
            this.labelPromotion.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.labelPromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPromotion.Location = new System.Drawing.Point(653, 430);
            this.labelPromotion.Margin = new System.Windows.Forms.Padding(3);
            this.labelPromotion.Name = "labelPromotion";
            this.labelPromotion.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.labelPromotion.Size = new System.Drawing.Size(155, 32);
            this.labelPromotion.TabIndex = 19;
            this.labelPromotion.Text = "$1200";
            this.labelPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPromotion.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Location = new System.Drawing.Point(653, 392);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(155, 32);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "$1000";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(425, 44);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(383, 32);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title text";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSpecifications
            // 
            this.labelSpecifications.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpecifications.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSpecifications.Location = new System.Drawing.Point(425, 96);
            this.labelSpecifications.Margin = new System.Windows.Forms.Padding(10);
            this.labelSpecifications.Name = "labelSpecifications";
            this.labelSpecifications.Size = new System.Drawing.Size(361, 283);
            this.labelSpecifications.TabIndex = 13;
            this.labelSpecifications.Text = "Specifications:";
            // 
            // ItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ItemPage";
            this.Size = new System.Drawing.Size(1366, 726);
            this.Resize += new System.EventHandler(this.ItemPage_Resize);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonAddToCart;
        private PictureBox pictureBox1;
        private Label labelPromotion;
        private Label labelPrice;
        private Label labelTitle;
        private Label labelSpecifications;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button buttonEdit;
        private Button buttonClose;
    }
}
