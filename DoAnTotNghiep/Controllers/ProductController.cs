using DoAnTotNghiep.Models;
using PagedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace DoAnTotNghiep.Controllers
{
    public class ProductController : Controller
    {
        private Db_Connection db = new Db_Connection();
        public List<TopProduct> ListAllPaging(int page, int pageSize)
        {
            try
            {
                string query = "SELECT top 40 [id],[sku],[name],[price],[original_price],[rating_average],[thumbnail_url],[brand_id],[brand_name],[review_count],[value],[address],[discount]"
                       + "FROM [DoAnTotNghiep].[dbo].[TopProduct] "
                       + "WHERE 1 = 1 " +
                       "  ORDER BY CONVERT(float,[value])*CONVERT(float,[rating_average]) desc";
                IEnumerable<TopProduct> data = db.Database.SqlQuery<TopProduct>(query);

                //IQueryable<Product> model = db.Products;
                return data.ToList<TopProduct>();
            }
            catch (Exception ex)
            {
                return new List<TopProduct>();
            }
           
        }

        [HttpGet]
        public ActionResult PageProduct(int page )
        {
            try
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                List<TopProduct> model = new List<TopProduct>();
                model = ListAllPaging(page, 40);
                for (int i = 0; i < model.Count ; i++)
                {
                    model[i].price = double.Parse(model[i].price).ToString("#,###", cul.NumberFormat);
                    model[i].original_price = double.Parse(model[i].original_price).ToString("#,###", cul.NumberFormat);
                }
                ViewBag.TotalPage = 50;
                return PartialView("PageData",model);

            }
            catch (Exception ex)
            {
                return Json(new { status = "err" });
            }
        }
        [HttpGet]
        public ActionResult LoadProduct()
        {
            try
            {
                var model = ListAllPaging(1, 20);
                ViewBag.TotalPage = 50;
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = "err"});
            }
        }

    }
}