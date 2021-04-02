using AutoMapper;
using CouponRestAPI.Dtos;
using CouponRestAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CouponRestAPI.Profiles
{
    //source ->target
    public class CouponProfile: Profile
    {
        //constructor
        public CouponProfile() {
            CreateMap<Coupon, CouponReadDto>();
            CreateMap<Coupon, CouponUpdateDto>();
            CreateMap<CouponUpdateDto, Coupon>();
            CreateMap<CouponCreateDto, Coupon>();


        }
    }
}
