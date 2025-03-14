﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Coupon
{
    public class CouponViewModel
    {
        public int Id { get; set; }
        public string CouponName { get; set; }
        public decimal Discount { get; set; }
    }
}
