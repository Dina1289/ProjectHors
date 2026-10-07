using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_שלי.BLL
{
   public class Area:GeneralRow
    {
		private int areaID;
		private string aname;

        #region-פעולות גישה
        public string Aname
        {
			get { return aname; }
			set { aname = value; }
		}


		public int AreaID
        {
			get { return areaID; }
			set { areaID = value; }
		}
        #endregion
        public Area()
        {

        }
        public Area(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.areaID = Convert.ToInt32(row["AreaId"]);
            this.aname = row["Aname"].ToString();

        }
        public override void FillDataRow()
        {
            row["AreaId"] = this.areaID;
            row["Aname"] = this.aname;

        }
    }
}
