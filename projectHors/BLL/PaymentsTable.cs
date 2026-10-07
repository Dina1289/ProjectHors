using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class PaymentsTable : GeneralTable
    {
        public PaymentsTable() : base("Payments")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Payments(item));
            }
        }
        public List<Payments> GetList()
        {
            return list.ConvertAll(x => (Payments)x);

        }
        public int GetNextKey()
        {
            if (list.Count() == 0)
                return 1;
            return MyDB.Payments.GetList().Max(x => x.PaymentId) + 1;
        }
    }
}
