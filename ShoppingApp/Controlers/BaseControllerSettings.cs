using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingApp.Controlers;
using ShoppingAppData.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;

namespace ShoppingApp.Controlers
{
    public abstract class BaseControllerSettings<T> where T : BaseEntity
    {
        public SqlConnection _con { get; set; }

        public IBaseView<T> _view;

        public BaseControllerSettings()
        {
            //Set default connection and settings
            string dbFileName = "ShoppingApp_Database.mdf";
            string dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            _con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + dir + @"\" + dbFileName + @"; Integrated Security = True");
        }
    }
}
