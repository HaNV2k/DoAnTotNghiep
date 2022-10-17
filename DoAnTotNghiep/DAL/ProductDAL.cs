using DoAnTotNghiep.Models;
using Microsoft.Build.Tasks;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnTotNghiep.Models
{
    public class ProductDAL
    {
        private Db_Connection db = new Db_Connection();
        public IEnumerable<Product> ListAllPaging(int page, int pageSize)
        {
            string query = "SELECT TOP (1000) [id],[sku],[name],[price],[original_price],[rating_average],[thumbnail_url],[brand_id],[brand_name],[review_count],[value] "
                        + "FROM [DoAnTotNghiep].[dbo].[Product] "
                        + "WHERE 1 = 1 " +
                        "  ORDER BY CONVERT(float,[value])*CONVERT(float,[rating_average]) desc";
            IEnumerable<Product> data = db.Database.SqlQuery<Product>(query);

            //IQueryable<Product> model = db.Products;
            return data.OrderByDescending(x => x.Id).ToPagedList(page, pageSize);
        }
    }
}