﻿namespace NorthWind.Sales.BusinessObjects.DTOs.CreateOrder
{
    public class CreateOrderDetailDto
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
