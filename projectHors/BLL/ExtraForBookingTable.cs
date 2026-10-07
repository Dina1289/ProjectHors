using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class ExtraForBookingTable : GeneralTable
    {
        public ExtraForBookingTable() : base("ExtraForBooking")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ExtraForBooking(item));
            }
        }
        public List<ExtraForBooking> GetList()
        {
            return list.ConvertAll(x => (ExtraForBooking)x);
        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.Courses.GetList().Max(x => x.CoursId) + 1;
        }
    }
}
