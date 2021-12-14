using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Mgt_LINQ
{
    public class Management
    {
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordData = (from products in review
                              select products).Skip(5);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
    }
}
