using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponRestAPI.Models
{
    public class CouponApiSettings : ICouponApiSettings
    {
        public string CouponsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
