using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProductModel> Products = new List<ProductModel>();
        public string wmessage = "WelcometoGGGG";
       

        public void OnGet()
        {
            //DBQuery dbQuery = new DBQuery();
            //Products = dbQuery.Data;

            Products.Add(new ProductModel() { ModelId = 1, ModelName = "Prod 1", Description = "Prod1desc" });

            Products.Add(new ProductModel() { ModelId = 2, ModelName = "Prod 2", Description = "Prod2desc" });

            Products.Add(new ProductModel() { ModelId = 3, ModelName = "Prod 3", Description = "Prod3desc" });
        }
    }
}
