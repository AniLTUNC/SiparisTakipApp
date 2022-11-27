using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipsisBLL.Repsitory.Entity
{
    public class CargoRepository : Base.BaseRepository<Cargo>
    {
        public void Update(Cargo gelen)
        {
            var bul = this.Find(gelen.Id);
            bul.UserId = gelen.UserId;
            bul.CargoName = gelen.CargoName;
            bul.CargoImageURL = gelen.CargoImageURL;
            Save();

        }
    }
}
