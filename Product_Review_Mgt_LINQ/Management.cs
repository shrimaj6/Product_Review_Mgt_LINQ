using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Mgt_LINQ
{
    public class Management
    {
        public void RetrieveCountOfReviewForEachProductId(List<ProductReview> review)
        {
            var recordData = review.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Count : " + list.Count);
            }
        }
    }
}
