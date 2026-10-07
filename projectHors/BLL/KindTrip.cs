using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class KindTrip:GeneralRow
    {
        private int kindId;
        private string kname;
        #region-פעולות גישה
        public string Kname
        {
            get { return kname; }
            set { kname = value; }
        }


        public int KindId
        {
            get { return kindId; }
            set { kindId = value; }
        }
        #endregion
        public KindTrip()
        {

        }
        public KindTrip(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.kindId = Convert.ToInt32( row["KindId"]);
            this.kname = row["Kname"].ToString();
          
        }
        public override void FillDataRow()
        {
            row["KindId"] = this.kindId;
            row["Kname"] = this.kname;
           
        }
    }
}

