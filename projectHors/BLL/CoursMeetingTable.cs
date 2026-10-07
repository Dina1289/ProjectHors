using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace פרויקט_שלי.BLL
{
    public class CoursMeetingTable:GeneralTable
    {
        public CoursMeetingTable() : base("CoursMeeting")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new CourseMeeting(item));
            }
        }
        public List<CourseMeeting> GetList()
        {
            return list.ConvertAll(x => (CourseMeeting)x);
        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.CourseMeeting.GetList().Max(x => x.CourseMeetingId) + 1;
        }
    }
}
