using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class Payments:GeneralRow
    {
        private int paymentId;
        private DateTime pdate;
        private string studentId;
        private string paymentSum;
        #region-פעולות גישה
        public string PaymentSum
        {
            get { return paymentSum; }
            set { paymentSum = value; }
        }


        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }


        public DateTime Pdate
        {
            get { return pdate; }
            set { pdate = value; }
        }


        public int PaymentId
        {
            get { return paymentId; }
            set { paymentId = value; }
        }
        #endregion
        public Payments()
        {

        }
        public Payments(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.paymentId = Convert.ToInt32(row["PaymentId"]);
            this.pdate =Convert.ToDateTime( row["Pdate"]);
            this.studentId = row["StudentId"].ToString();
            this.paymentSum = row["PaymentSum"].ToString();
        }
        public override void FillDataRow()
        {
            row["PaymentId"] = this.paymentId;
            row["Pdate"] = this.pdate;
            row["StudentId"] = this.studentId;
            row["PaymentSum"] = this.paymentSum;
           
        }
    }

    
}
