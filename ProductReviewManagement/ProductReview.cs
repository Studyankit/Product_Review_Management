using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductReview
    {
        private int ProductID { get; set; }
        private int UserID { get; set; }
        private int Rating { get; set; }
        private int Review { get; set; }
        private int isLike { get; set; }

        public void ReviewSpecification(int ProductID, int UserID, int Rating, int Review, isLike)
        {
            this.ProductID = ProductID;
            this.UserID = UserID;
            this.Rating = Rating;
            this.Review = Review;
            this.isLike = isLike;
            
        }
    }
}
