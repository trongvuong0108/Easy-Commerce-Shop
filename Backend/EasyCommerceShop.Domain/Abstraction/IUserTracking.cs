﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Domain.Abstraction
{
    public interface IUserTracking
    {
        public string? CreatedBy { get; set; }
        public string? ChangedBy { get; set; }
    }
}
