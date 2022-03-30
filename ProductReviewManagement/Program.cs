using ProductReviewManagement;


Console.WriteLine("Welcome to product review management");

List<ProductReview> products = new List<ProductReview>()
{
        new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=true},
        new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
        new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=true},
        new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",isLike=false},
        new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",isLike=true},
        new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",isLike=true},
        new ProductReview(){ProductID=8,UserID=1,Rating=10,Review="Good",isLike=false},
        new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",isLike=true},
        new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="nice",isLike=true},
        new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",isLike=true},
        new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",isLike=true}
};

//Uc2
//ReviewOperation.TopRecord(products);

//UC3
//ReviewOperation.specificRecords(products);

//Uc4
//ReviewOperation.recordCount(products);

//UC5
ReviewOperation.retrieveColoumn(products);
