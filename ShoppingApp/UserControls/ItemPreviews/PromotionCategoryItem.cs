using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShoppingAppData.Models;
using ShoppingApp.ViewInterfaces;
using ShoppingAppData;

namespace ShoppingApp.UserControls.ItemPreviews
{
    public partial class PromotionCategoryItem : UserControl
    {
        private readonly DataContext _dataContext = new DataContext();
        public PromotionCategoryItem()
        {
            InitializeComponent();
        }

        #region Properties

        private Byte[] thumbnail;

        public Byte[] Thumbnail
        {
            get { return this.thumbnail; }
            set { this.thumbnail = value; pictureBox1.BackgroundImage = Converter.ToImage(thumbnail); }
        }

        #endregion

        //Event that handles clicking on the item
        private void OnClick(object sender, EventArgs e)
        {
            List<Product> products = _dataContext.Products.Include(p => p.Category).Where(p => p.Promotion > 0).ToList();
            ListingPage listingPage = new ListingPage(products);
        }
    }
}
