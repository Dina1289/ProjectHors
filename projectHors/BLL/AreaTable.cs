using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace פרויקט_שלי.BLL
{
    public class AreaTable : GeneralTable
    {
        public AreaTable() : base("Area")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Area(item));
            }
        }
        public List<Area> GetList()
        {
            return list.ConvertAll(x => (Area)x);
        }
    }
}
