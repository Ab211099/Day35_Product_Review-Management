using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_ProductReviewManagement
{
    public class AddValues
    {
        public static List<Product_Review> AddProductReviewToList(List<Product_Review> products)
        {
            //List<Product_Review> products = new List<Product_Review>();
            try
            {
                
                products.Add(new Product_Review() { ProductId = 1, UserId = 1, Review = "Very Good", Rating = 2.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 2, UserId = 2, Review = "Good", Rating = 3.4, IsLike = true });
                products.Add(new Product_Review() { ProductId = 3, UserId = 3, Review = "Good", Rating = 2.5, IsLike = false });
                products.Add(new Product_Review() { ProductId = 4, UserId = 4, Review = "Very Good", Rating = 4, IsLike = true });
                products.Add(new Product_Review() { ProductId = 5, UserId = 5, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 6, UserId = 6, Review = "Bad", Rating = 2, IsLike = false });
                products.Add(new Product_Review() { ProductId = 7, UserId = 7, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 8, UserId = 15, Review = "Average", Rating = 2.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 9, UserId = 9, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 10, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new Product_Review() { ProductId = 1, UserId = 7, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new Product_Review() { ProductId = 3, UserId = 8, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 2, UserId = 8, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new Product_Review() { ProductId = 4, UserId = 9, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new Product_Review() { ProductId = 6, UserId = 10, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 8, UserId = 11, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new Product_Review() { ProductId = 9, UserId = 12, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 5, UserId = 13, Review = "Average", Rating = 4.5, IsLike = false });
                products.Add(new Product_Review() { ProductId = 10, UserId = 14, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new Product_Review() { ProductId = 2, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 3, UserId = 2, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new Product_Review() { ProductId = 5, UserId = 3, Review = "Average", Rating = 4.5, IsLike = true });
                products.Add(new Product_Review() { ProductId = 7, UserId = 4, Review = "Good", Rating = 3.2, IsLike = true });
                products.Add(new Product_Review() { ProductId = 9, UserId = 5, Review = "Average", Rating = 4, IsLike = true });
                products.Add(new Product_Review() { ProductId = 11, UserId = 6, Review = "Good", Rating = 3.5, IsLike = false });

                Console.WriteLine("Added The Products Review To The List Successfully !!!!!!");
            }
            catch (Exception )
            {
                throw ;
            }
            return products;
        }
        public static void IterateOverList(List<Product_Review> products)
        {
            
                if (products != null)
                {
                    foreach (Product_Review product in products)
                    {
                        Console.WriteLine(product);
                    }
                }
                else
                    Console.WriteLine("No Products Review Added In The List.....");
          
        }
        public static int RetrieveTopThreeRating(List<Product_Review> products)
        {
            AddProductReviewToList(products);
            Console.WriteLine("\nRetrieving Top Three Records Based On Rating");
            var res = (from product in products orderby product.Rating descending select product).Take(3).ToList();
            IterateOverList(res);
            return res.Count;
        }
        public static List<Product_Review> RetrieveRecordsBasedOnRatingAndProductId(List<Product_Review> products)
        {
            AddProductReviewToList(products);
            var resProductList = (from product in products where (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) && product.Rating > 3 select product).ToList();
            Console.WriteLine("\nDisplauy the records based on Rating And ProductId");
            IterateOverList(resProductList);
            return resProductList;
        }

    }
}
