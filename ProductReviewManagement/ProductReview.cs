using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

        public void ReviewSpecification(int ProductID, int UserID, int Rating, string Review, bool isLike)
        {
            this.ProductID = ProductID;
            this.UserID = UserID;
            this.Rating = Rating;
            this.Review = Review;
            this.isLike = isLike;
            
        }
    }
}
