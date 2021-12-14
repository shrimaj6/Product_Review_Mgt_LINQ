using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Mgt_LINQ
{
    class DataTable
    {
        public static System.Data.DataTable table = new System.Data.DataTable();


        public void AddDataIntoDataTable()
        {
            table.Columns.Add("ProductId", typeof(Int32));
            table.Columns.Add("UserId", typeof(Int32));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));

            table.Rows.Add(101, 1, 4, "Nice", true);
            table.Rows.Add(102, 2, 1, "Low ", false);
            table.Rows.Add(103, 3, 4, "Good", true);
            table.Rows.Add(104, 4, 5, "Nice", true);
            table.Rows.Add(105, 5, 4, "Good", true);
            table.Rows.Add(106, 6, 3, "Low ", false);
            table.Rows.Add(104, 7, 5, "Nice", true);
            table.Rows.Add(105, 8, 3, "Low ", false);
            table.Rows.Add(101, 1, 4, "Nice", true);
            table.Rows.Add(102, 2, 1, "Low ", false);
            table.Rows.Add(103, 3, 4, "Good", true);
            table.Rows.Add(104, 4, 5, "Nice", true);
            table.Rows.Add(105, 5, 4, "Good", true);
            table.Rows.Add(106, 6, 3, "Low ", false);
            table.Rows.Add(104, 7, 5, "Nice", true);
            table.Rows.Add(105, 8, 3, "Low ", false);
            table.Rows.Add(101, 1, 4, "Nice", true);
            table.Rows.Add(102, 2, 1, "Low ", false);
            table.Rows.Add(103, 3, 4, "Good", true);
            table.Rows.Add(104, 4, 5, "Nice", true);
            table.Rows.Add(105, 5, 4, "Good", true);
            table.Rows.Add(106, 6, 3, "Low ", false);
            table.Rows.Add(104, 7, 5, "Nice", true);
            table.Rows.Add(105, 8, 3, "Low ", false);
            table.Rows.Add(105, 8, 3, "Low ", false);

            Console.WriteLine("\n Data Table contents : ");

            foreach (var list in table.AsEnumerable())
            {
                Console.WriteLine("Product Id : " + list.Field<int>("ProductId") + " || User Id : " + list.Field<int>("UserId") + " || Rating : " + list.Field<double>("Rating") + " || Review : " + list.Field<string>("Review") + " || Is Like : " + list.Field<bool>("IsLike"));
            }
        }
    }
}
