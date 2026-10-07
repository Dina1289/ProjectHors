using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class CoursesTable : GeneralTable
    {
        public CoursesTable() : base("Courses")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Courses(item));
            }
        }
        public List<Courses> GetList()
        {
            return list.ConvertAll(x => (Courses)x);
        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.Courses.GetList().Max(x => x.CoursId) + 1;
        }
    }
}
