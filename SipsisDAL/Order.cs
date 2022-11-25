//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SipsisDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> MarketId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public Nullable<int> Widht { get; set; }
        public Nullable<int> Lenght { get; set; }
        public Nullable<double> M2 { get; set; }
        public string Description { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string CargoCode { get; set; }
        public Nullable<int> CargoId { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Market Market { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual user user { get; set; }
    }
}
