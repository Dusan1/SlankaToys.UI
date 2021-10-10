using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlankaToys.UX.Models.Requests
{
    public class AddToCartRequestModel
    {
        public AddToCartRequestModel()
        {

        }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
