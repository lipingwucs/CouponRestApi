using Amazon.DynamoDBv2.DataModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponRestAPI.Models
{
    public class Coupon
    {
        [DynamoDBProperty("id")]
        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty("CouponCode")]
        public string CouponCode { get; set; }
        [DynamoDBProperty("StoreName")]
        public string StoreName { get; set; }
        [DynamoDBProperty("ItemName")]
        public string ItemName { get; set; }
        [DynamoDBProperty("OriginalPrice")]
        public decimal OriginalPrice { get; set; }
        [DynamoDBProperty("DiscountPercentage")]
        public decimal DiscountPercentage { get; set; }
     /*   public DateTime ExpiredTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }*/

        //constructor
       /* public Coupon(int id, string couponCode, string storeName, string itemName, decimal originalPrice, decimal discountPercentage, DateTime expiredTime, DateTime createdTime, DateTime updatedTime)
        {
            Id = id;
            CouponCode = couponCode;
            StoreName = storeName;
            ItemName = itemName;
            OriginalPrice = originalPrice;
            DiscountPercentage = discountPercentage;
            ExpiredTime = expiredTime;
            CreatedTime = createdTime;
            UpdatedTime = updatedTime;
        }*/

       /* public Coupon(int id, string couponCode, string storeName) {
            Id = id;
            CouponCode = couponCode;
            StoreName = storeName;
        }
*/
    }
}
