using CouponRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CouponRestAPI.Data
{
    public interface ICouponRepo
    {

         Task<IEnumerable<Coupon>> GetAllCoupons();
         Task<IEnumerable<Coupon>> GetCouponByStore(string storename);
         Task<Coupon> GetCouponById(string id);
         Task<Coupon> CreateCoupon(Coupon coupon);
         Task<Coupon> UpdateCoupon(string id, Coupon coupon);
         Task DeleteCoupon(Coupon coupon);

    }
}
