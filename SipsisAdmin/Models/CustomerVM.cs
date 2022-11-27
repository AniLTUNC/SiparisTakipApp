using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SipsisAdmin.Models
{
    public class CustomerVM
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public int UserId { get; set; }
        public int MarketId { get; set; }
    }
}