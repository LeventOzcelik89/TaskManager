using OnionArcExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArcExample.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
    }
}
