﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkCoreTutorial.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
