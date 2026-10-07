using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class StudentTable : GeneralTable
    {
        public StudentTable() : base("Students")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Student(item));
            }
        }
        public List<Student> GetList()
        {
            return list.ConvertAll(x => (Student)x);
        }
    }
}
