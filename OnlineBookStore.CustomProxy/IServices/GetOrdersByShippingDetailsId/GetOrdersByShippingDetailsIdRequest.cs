﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.CustomProxy.IServices
{
    public class GetOrdersByShippingDetailsIdRequest : BaseRequest
    {
        public int ShippingDetailsId { get; set; }
    }
}
