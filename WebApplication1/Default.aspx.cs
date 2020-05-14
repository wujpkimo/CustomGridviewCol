using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fateData = new List<Test>()
            {
                new Test("TestProductName","TestCategoryName","TestSupplierName",10,DateTime.Now),
                new Test("TestProductName1","TestCategoryName1","TestSupplierName1",5,DateTime.Now),
                new Test("TestProductName2","TestCategoryName2","TestSupplierName2",10,DateTime.Now),
                new Test("TestProductName3","TestCategoryName3","TestSupplierName3",10,DateTime.Now),
                new Test("TestProductName4","TestCategoryName4","TestSupplierName4",10,DateTime.Now),
            };
            GdvTest.DataSource = fateData;
            GdvTest.DataBind();
        }

        private class Test
        {
            public string ProductName { get; set; }
            public string CategoryName { get; set; }
            public string SupplierName { get; set; }
            public int QuantityPerUnit { get; set; }
            public DateTime CreateDate { get; set; }

            public Test(string productName, string categoryName, string supplierNmae, int qty, DateTime createDate)
            {
                this.ProductName = productName;
                this.CategoryName = categoryName;
                this.SupplierName = supplierNmae;
                this.QuantityPerUnit = qty;
                this.CreateDate = createDate;
            }
        }
    }
}