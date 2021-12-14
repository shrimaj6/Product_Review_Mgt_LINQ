using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Mgt_LINQ
{
    public class Management
    {
        public void RetrieveProductIdLike(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.isLike == true)
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Is Like : " + list.isLike);
            }
        }
    }
}
