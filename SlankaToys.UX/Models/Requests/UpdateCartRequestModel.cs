using System;
namespace SlankaToys.UX.Models.Requests
{
    public class UpdateCartRequestModel
    {
        public UpdateCartRequestModel()
        {
        }

        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

