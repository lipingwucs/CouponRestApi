using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponRestAPI.Dtos
{
    public class CouponReadDto
    {
        public string Id { get; set; }           
        public string CouponCode { get; set; }      
        public string StoreName { get; set; }
        public string ItemName { get; set; }
      //  public decimal OriginalPrice { get; set; }
       // public decimal DiscountPercentage { get; set; }
       // public DateTime ExpiredTime { get; set; }
       /* public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }*/
    }
}
