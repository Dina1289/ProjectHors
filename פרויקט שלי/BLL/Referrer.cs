using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
   public class Referrer:GeneralRow
    {
        private int referrerId;
        private string rName;
        private int downPercent;
        #region-פעולות גישה
        public int DownPercent
        {
            get { return downPercent; }
            set { downPercent = value; }
        }


        public string RName
        {
            get { return rName; }
            set { rName = value; }
        }


        public int ReferrerId
        {
            get { return referrerId; }
            set { referrerId = value; }
        }
        #endregion
        public Referrer()
        {

        }
        public Referrer(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.referrerId =Convert.ToInt32( row["ReferrerId"]);
            this.rName = row["RName"].ToString();
            this.downPercent = Convert.ToInt32(row["DownPercent"]);
           
        }
        public override void FillDataRow()
        {
            row["ReferrerId"] = this.referrerId;
            row["RName"] = this.rName;
            row["DownPercent"] = this.downPercent;
           
        }
    }
    
}
