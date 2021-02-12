using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public class Order:IEntity
    {
        public int OrderID { get; set; }
        public string CustomerId { get; set; }
        public int EmployedId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
