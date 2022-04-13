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
    public interface IBaseController<T> where T : BaseEntity
    {
        bool AddOrUpdate(T entity);
        bool Delete(int Id);
        T Get(int Id);
        List<T> GetAll();
        List<T> GetAll(string criteria);
    }
}
