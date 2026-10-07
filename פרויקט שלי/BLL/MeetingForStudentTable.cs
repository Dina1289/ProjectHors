using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class MeetingForStudentTable:GeneralTable
    {
        public MeetingForStudentTable() : base("MeetingForStudent")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new MeetingForStudent(item));
            }
        }
        public List<MeetingForStudent> GetList()
        {
            return list.ConvertAll(x => (MeetingForStudent)x);
        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.MeetingForStudent.GetList().Max(x => x.MeetingForStudentId) + 1;
        }
    }
}
