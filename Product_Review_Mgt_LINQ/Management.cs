using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Mgt_LINQ
{
    public class Management
    {

        public void RetrieveRecordsWithGreaterThanThreeRating(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.ProductId == 1 ||
                              products.ProductId == 4 ||
                              products.ProductId == 9)
                              && products.Rating > 3
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
    }
}
