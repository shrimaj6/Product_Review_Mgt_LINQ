using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Mgt_LINQ
{
    public class Management
    {
        public void RetrieveProductId10WithRating(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.ProductId == 10)
                              orderby products.Rating descending
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Rating : " + list.Rating);
            }
        }
    }
}
