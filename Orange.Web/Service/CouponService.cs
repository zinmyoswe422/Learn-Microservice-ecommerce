﻿using Orange.Web.Models;
using Orange.Web.Service.IService;
using Orange.Web.Utility;

namespace Orange.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendSync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"

            });
        }

        public async Task<ResponseDto> DeleteCouponAsync(int id)
        {
            return await _baseService.SendSync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id

            });
        }

        public async Task<ResponseDto> GetAllCouponAsync()
        {
            return await _baseService.SendSync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon"

            });
        }

        public async Task<ResponseDto> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendSync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetZinByCode/" + couponCode

            });
        }

        public async Task<ResponseDto> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendSync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id

            });
        }

        public async Task<ResponseDto> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendSync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"

            });
        }
    }
}
