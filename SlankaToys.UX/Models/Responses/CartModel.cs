using System;
using System.Collections.Generic;
using System.Linq;

namespace SlankaToys.UX.Models.Responses
{
	public class CartModel
	{
		public CartModel()
		{
		}

		public DateTime Date { get; set; }
		public int CartId { get; set; }
		public List<CartItemModel> Items { get; set; }

		public decimal TotalItemsPrice => Items.Select(it => it.TotalPrice).Sum();
		public decimal VAT => TotalItemsPrice * 0.17m;
		public decimal SubTotal => TotalItemsPrice - VAT;
	}
}

