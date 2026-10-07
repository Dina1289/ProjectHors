using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{

    public class TripsTable : GeneralTable
    {
        public TripsTable() : base("Trips")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Trips(item));
            }
        }
        public List<Trips> GetList()
        {
            return list.ConvertAll(x => (Trips)x);

        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Trips.GetList().Max(x => x.TripId) + 1;
        }

    }
}
