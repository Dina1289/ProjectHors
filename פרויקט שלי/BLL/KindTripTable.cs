using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class KindTripTable : GeneralTable
    {
        public KindTripTable() : base("KindTrip")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new KindTrip(item));
            }
        }
        public List<KindTrip> GetList()
        {
            return list.ConvertAll(x => (KindTrip)x);

        }
    }
}
