using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_ProductReviewManagement
{
    public class Product_Review
    {
         public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

        //Method to override tostring for displaying assigned values
        public override string ToString()
        {
            return $"Product Id : {ProductId}  \tUser Id : {UserId}  \tProduct Rating : {Rating}  \tProduct Review : {Review}    \tIsLike : {IsLike}";
        }
    }
}
