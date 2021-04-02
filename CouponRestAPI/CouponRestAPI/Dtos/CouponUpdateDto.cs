using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CouponRestAPI.Dtos
{
    public class CouponUpdateDto
    {
        // public string Id { get; set; }
        [Required]        
        public string CouponCode { get; set; }
        [Required]
        public string StoreName { get; set; }
        public string ItemName { get; set; }
      //  public decimal OriginalPrice { get; set; }
     //   public decimal DiscountPercentage { get; set; }
    //    public DateTime ExpiredTime { get; set; }
    //    public DateTime CreatedTime { get; set; }
     //   public DateTime UpdatedTime { get; set; }
    }
}
