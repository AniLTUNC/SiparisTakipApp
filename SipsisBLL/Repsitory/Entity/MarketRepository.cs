using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipsisBLL.Repsitory.Entity
{
    public class MarketRepository : Base.BaseRepository<Market>
    {
        public void update(Market vm)
        {
            var bulunan = Find(vm.Id);
            bulunan.MarketName = vm.MarketName;
            bulunan.Commission = vm.Commission;
            bulunan.UserId = vm.UserId;
            Save();
        }
    }
}
