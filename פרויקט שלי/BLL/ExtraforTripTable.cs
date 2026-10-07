using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class ExtraforTripTable : GeneralTable
    {
        public ExtraforTripTable() : base("ExtraforTrip")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ExtraforTrip(item));
            }
        }
        public List<ExtraforTrip> GetList()
        {
            return list.ConvertAll(x => (ExtraforTrip)x);
        }
    }
}
