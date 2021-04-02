using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponRestAPI.Models
{
    public interface ICouponApiSettings
    {
        string CouponsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
