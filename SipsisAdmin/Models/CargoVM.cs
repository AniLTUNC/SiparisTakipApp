using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SipsisAdmin.Models
{
    public class CargoVM
    {
        public int Id { get; set; }
        public string CargoName { get; set; }
        public string CargoImageURL { get; set; }
        public int UserId { get; set; }

    }
}