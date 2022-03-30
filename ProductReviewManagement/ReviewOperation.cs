﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ReviewOperation
    {
        public static void TopRecord(List<ProductReview> products)
        {
            var record = (from productReviews in products
                          orderby productReviews.Rating descending
                          select productReviews).Take(3);

            foreach (var list in record)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }
        public static void specificRecords(List<ProductReview> products)
        {
            var record1 = from productReviews in products
                          where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                          && productReviews.Rating > 3
                          select productReviews;

            foreach (var list in record1)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
    }
}
