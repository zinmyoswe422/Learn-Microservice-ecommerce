﻿namespace Orange.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponName { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
