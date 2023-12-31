﻿namespace EBookStoreAPI.VM.OrderVM
{
    public class OrderItemsVM
    {
        public string Image { get; set; }
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }
}
