using OnlineShoping.DAL;
using OnlineShoping.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Windows.Forms;

namespace OnlineShoping.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        OnlineShoppingEntities3 context = new OnlineShoppingEntities3();
        public IEnumerable<Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                   new SqlParameter("@search",search??(object)DBNull.Value)
            };
            IEnumerable<Product> data = context.Database.SqlQuery<Product>("GetbySearch @search", param).ToList();
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }
    }
}