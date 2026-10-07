using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class ReferrerTable : GeneralTable
    {
        public ReferrerTable() : base("Referrer")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Referrer(item));
            }
        }
        public List<Referrer> GetList()
        {
            return list.ConvertAll(x => (Referrer)x);

        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.Referrer.GetList().Max(x => x.ReferrerId) + 1;
        }
    }
}
