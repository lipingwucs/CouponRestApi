using CouponRestAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CouponRestAPI.Data
{
    public interface IDynamoDBServices
    {
        Task<List<Coupon>> Get();
        Task<List<Coupon>> GetCouponByStore(string storename);
        Task<Coupon> Get(string id);
        Task<Coupon> Create(Coupon coupon);
        Task<Coupon> Update(string id, Coupon coupon);
        Task Delete(Coupon coupon);

    }
}