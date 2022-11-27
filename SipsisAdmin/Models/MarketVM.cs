using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SipsisAdmin.Models
{
    public class MarketVM
    {
        public int Id { get; set; }
        public string MarketName { get; set; }
        public int Commission { get; set;}
        public int UserId { get; set; }
    }
}