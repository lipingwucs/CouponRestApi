using CouponRestAPI.Models;
using CouponRestAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Microsoft.Extensions.Logging;

namespace CouponRestAPI.Data
{
    public class DynamoCouponRepo : ICouponRepo
    {
        private readonly IDynamoDBServices _service;

        //constructor
        public DynamoCouponRepo(IDynamoDBServices dynamoSvc)
        {
            this._service = dynamoSvc;
            
        }

        public async Task<Coupon> CreateCoupon(Coupon coupon)
        {
            if (coupon == null)
            {
                throw new ArgumentNullException(nameof(coupon));
            }

            return await _service.Create(coupon);
        }

        public async Task DeleteCoupon(Coupon coupon)
        {
            if (coupon == null)
            {
                throw new ArgumentNullException(nameof(coupon));
            }

            await _service.Delete(coupon);
        }

        public async Task<IEnumerable<Coupon>> GetAllCoupons()
        {
            return await _service.Get();
        }

        public async Task<Coupon> GetCouponById(string id)
        {
            return await _service.Get(id);
        }

        public async Task<IEnumerable<Coupon>> GetCouponByStore(string storename)
        {
            return await _service.GetCouponByStore(storename);
        }

        public async Task<Coupon> UpdateCoupon(string id, Coupon coupon)
        {
            if (coupon == null)
            {
                throw new ArgumentNullException(nameof(coupon));
            }

            return await _service.Update(coupon.Id, coupon);
        }
    }
}
