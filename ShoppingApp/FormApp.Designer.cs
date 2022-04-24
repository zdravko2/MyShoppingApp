namespace ShoppingApp
{
    partial class FormApp
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtonIndex = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonMyOrders = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonUsersList = new System.Windows.Forms.Button();
            this.buttonOrdersList = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.panelButtonIndex);
            this.panelMenu.Controls.Add(this.buttonUser);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonCart);
            this.panelMenu.Controls.Add(this.buttonCategory);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.buttonMyOrders);
            this.panelMenu.Controls.Add(this.buttonAddNew);
            this.panelMenu.Controls.Add(this.buttonUsersList);
            this.panelMenu.Controls.Add(this.buttonOrdersList);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(247)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 646);
            this.panelMenu.TabIndex = 0;
            // 
            // panelButtonIndex
            // 
            this.panelButtonIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(247)))));
            this.panelButtonIndex.Location = new System.Drawing.Point(0, 100);
            this.panelButtonIndex.Name = "panelButtonIndex";
            this.panelButtonIndex.Size = new System.Drawing.Size(10, 50);
            this.panelButtonIndex.TabIndex = 1;
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(203)))), ((int)(((byte)(180)))));
            this.buttonUser.Image = global::ShoppingApp.Properties.Resources.icons8_user_32;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUser.Location = new System.Drawing.Point(0, 523);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.buttonUser.Size = new System.Drawing.Size(200, 123);
            this.buttonUser.TabIndex = 9;
            this.buttonUser.Text = "User";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.Image = global::ShoppingApp.Properties.Resources.icons8_settings_32;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 250);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(200, 50);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.FlatAppearance.BorderSize = 0;
            this.buttonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCart.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCart.Image = global::ShoppingApp.Properties.Resources.icons8_shopping_cart_32;
            this.buttonCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCart.Location = new System.Drawing.Point(0, 200);
            this.buttonCart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCart.Size = new System.Drawing.Size(200, 50);
            this.buttonCart.TabIndex = 2;
            this.buttonCart.Text = "Cart";
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // buttonCategory
            // 
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCategory.Image = global::ShoppingApp.Properties.Resources.icons8_category_32;
            this.buttonCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategory.Location = new System.Drawing.Point(0, 150);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCategory.Size = new System.Drawing.Size(200, 50);
            this.buttonCategory.TabIndex = 1;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.Image = global::ShoppingApp.Properties.Resources.icons8_home_page_32;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 100);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(200, 50);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonMyOrders
            // 
            this.buttonMyOrders.FlatAppearance.BorderSize = 0;
            this.buttonMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyOrders.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMyOrders.Image = global::ShoppingApp.Properties.Resources.icons8_purchase_order_32;
            this.buttonMyOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyOrders.Location = new System.Drawing.Point(0, 300);
            this.buttonMyOrders.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMyOrders.Name = "buttonMyOrders";
            this.buttonMyOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMyOrders.Size = new System.Drawing.Size(200, 50);
            this.buttonMyOrders.TabIndex = 4;
            this.buttonMyOrders.Text = "My Orders";
            this.buttonMyOrders.UseVisualStyleBackColor = true;
            this.buttonMyOrders.Click += new System.EventHandler(this.buttonMyOrders_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.FlatAppearance.BorderSize = 0;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNew.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddNew.Image = global::ShoppingApp.Properties.Resources.icons8_add_new_32;
            this.buttonAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNew.Location = new System.Drawing.Point(1, 350);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAddNew.Size = new System.Drawing.Size(200, 50);
            this.buttonAddNew.TabIndex = 5;
            this.buttonAddNew.Text = "Add/Edit";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Visible = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonUsersList
            // 
            this.buttonUsersList.FlatAppearance.BorderSize = 0;
            this.buttonUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersList.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsersList.Image = global::ShoppingApp.Properties.Resources.icons8_users_list_32;
            this.buttonUsersList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersList.Location = new System.Drawing.Point(0, 400);
            this.buttonUsersList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUsersList.Name = "buttonUsersList";
            this.buttonUsersList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonUsersList.Size = new System.Drawing.Size(200, 50);
            this.buttonUsersList.TabIndex = 6;
            this.buttonUsersList.Text = "Users";
            this.buttonUsersList.UseVisualStyleBackColor = true;
            this.buttonUsersList.Visible = false;
            this.buttonUsersList.Click += new System.EventHandler(this.buttonUsersList_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.FlatAppearance.BorderSize = 0;
            this.buttonOrdersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdersList.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrdersList.Image = global::ShoppingApp.Properties.Resources.icons8_purchase_order_32;
            this.buttonOrdersList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrdersList.Location = new System.Drawing.Point(0, 450);
            this.buttonOrdersList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOrdersList.Size = new System.Drawing.Size(200, 50);
            this.buttonOrdersList.TabIndex = 7;
            this.buttonOrdersList.Text = "Orders";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Visible = false;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.textBox1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(994, 100);
            this.panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(510, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.textBox1.Location = new System.Drawing.Point(595, 54);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 31);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_OnPressEnterDown);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(15, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(967, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControlMain.Location = new System.Drawing.Point(200, 100);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(0, 0);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(994, 546);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(986, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::ShoppingApp.Properties.Resources.toru_logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 10);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(178, 72);
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(187)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1194, 646);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "FormApp";
            this.Text = "Toru App";
            this.Resize += new System.EventHandler(this.FormApp_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button buttonHome;
        private Panel panelTitle;
        private TabControl tabControlMain;
        private Button buttonAddNew;
        private Button buttonSettings;
        private Button buttonCart;
        private Button buttonCategory;
        private Panel panelButtonIndex;
        private TextBox textBox1;
        private Label labelTitle;
        private TabPage tabPage1;
        private Button buttonUser;
        private Label label1;
        private Button buttonUsersList;
        private Button buttonOrdersList;
        private Button buttonMyOrders;
        private PictureBox pictureBoxLogo;
    }
}