﻿using System;
using System.Collections.Generic;
using WebStore.DomainNew.Entities.Base;
namespace WebStore.DomainNew.Dto.Order
{
    public class orderDto : NamedEntity
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}
