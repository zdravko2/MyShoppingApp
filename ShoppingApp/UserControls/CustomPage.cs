using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShoppingAppData.Models;
using ShoppingApp.Controlers;

namespace ShoppingApp.UserControls
{
    public partial class CustomPage : UserControl
    {
        //Constructor for base Page
        public CustomPage()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        //Base properties of Page control
        #region Properties

        private string titleText;
        private TabPage previousPage;
        private Control mainControl;


        [Category("Custom Properties"), Description()]
        public string TitleText
        {
            get { return titleText; }
            set
            {
                titleText = value;
            }
        }

        [Category("Custom Properties"), Description()]
        public TabPage PreviousPage
        {
            get { return previousPage; }
            set
            {
                previousPage = value;
            }
        }


        [Category("Custom Properties"), Description()]
        public Control MainControl
        {
            get { return mainControl; }
            set
            {
                mainControl = value;
            }
        }


        #endregion
    }
}
