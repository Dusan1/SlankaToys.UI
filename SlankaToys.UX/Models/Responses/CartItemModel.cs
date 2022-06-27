using System;
namespace SlankaToys.UX.Models.Responses
{
	public class CartItemModel
	{
		public CartItemModel()
		{
		}

		public string ProductName { get; set; }
		public string QuantityForView { get; set; }
		public decimal Price { get; set; }

		public int Quantity { get; set; }

		public decimal TotalPrice => Price * Quantity;

		public string ImageFileName { get; set; }
		public int ProductId { get; set; }
	}
}

