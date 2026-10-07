using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class HorsesTable : GeneralTable
    {
        public HorsesTable() : base("Horses")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Horses(item));
            }
        }
        public List<Horses> GetList()
        {
            return list.ConvertAll(x => (Horses)x);
        }
    }
}
