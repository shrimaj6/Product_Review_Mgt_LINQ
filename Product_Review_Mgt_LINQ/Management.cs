using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Mgt_LINQ
{
    public class Management
    {
        public void RetrieveProductIdAndReviewOfAllRecords(List<ProductReview> review)
        {
            var recordData = (from products in review
                              select new { ProductId = products.ProductId, Review = products.Review });

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
            }
        }
    }
}
