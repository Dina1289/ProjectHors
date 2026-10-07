using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class BookingTripTable : GeneralTable
    {
        public BookingTripTable() : base("BookingTrip")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new BookingTrip(item));
            }
        }
        public List<BookingTrip> GetList()
        {
            return list.ConvertAll(x => (BookingTrip)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.BookingTrip.GetList().Max(x => x.BookingTripId) + 1;
        }
    }
}
