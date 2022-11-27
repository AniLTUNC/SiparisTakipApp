using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SipsisBLL.Repsitory.Entity
{
    public class CustomerRepository : Base.BaseRepository<Customer>
    {
        public Customer PhoneSearch(string Phone)
        {
            var bulunan = (from c in GetAll() 
                           where c.CustomerPhone == Phone
                           select new Customer
                           {
                               CustomerAddress = c.CustomerAddress,
                               CustomerPhone= c.CustomerPhone,
                               Id = c.Id,
                               MarketId = c.MarketId,
                               UserId= c.UserId,
                           }).SingleOrDefault();    
            if (bulunan != null) 
            {
                return bulunan;            
            }
            else
            {
                return new Customer();
            }
        }

        public void Update(Customer gelen)
        {
            var bulunan = this.Find(gelen.Id);
            bulunan.CustomerName = gelen.CustomerName;
            bulunan.CustomerPhone = gelen.CustomerPhone;
            bulunan.CustomerAddress = gelen.CustomerAddress;
            bulunan.MarketId = gelen.MarketId;
            bulunan.UserId = gelen.UserId;
            Save();
        }
    }
}
