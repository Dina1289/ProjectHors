using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{

    public class HoursWorkTable : GeneralTable
    {
        public HoursWorkTable() : base("HoursWork")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new HoursWork(item));
            }
        }
        public List<HoursWork> GetList()
        {
            return list.ConvertAll(x => (HoursWork)x);
        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.HoursWork.GetList().Max(x => x.HoursWorkId) + 1;
        }
    }
}   

