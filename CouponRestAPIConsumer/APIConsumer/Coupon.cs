using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIConsumer
{
    class Coupon
    {
        public string Id { get; set; }
        public string CouponCode { get; set; }
        public string StoreName { get; set; }
        public string ItemName { get; set; }
    }
}
