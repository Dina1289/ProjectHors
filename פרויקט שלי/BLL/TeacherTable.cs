using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class TeacherTable : GeneralTable
    {
        public TeacherTable() : base("Teachers")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Teacher(item));
            }
        }
        public List<Teacher> GetList()
        {
            return list.ConvertAll(x => (Teacher)x);

        }
    }
}