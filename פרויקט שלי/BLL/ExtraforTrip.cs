using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
   public class ExtraforTrip:GeneralRow
    {
        private int extraForTripId;
        private string ename;
        private string eprice;
        #region
        public string Eprice
        {
            get { return Eprice; }
            set { Eprice = value; }
        }


        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }


        public int ExtraForTripId
        {
            get { return extraForTripId; }
            set { extraForTripId = value; }
        }
        #endregion
        public ExtraforTrip()
        {

        }
        public ExtraforTrip(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.extraForTripId =Convert.ToInt32( row["ExtraForTripId"]);
            this.ename = row["Ename"].ToString();
            this.eprice = row["Eprice"].ToString();
          
        }
        public override void FillDataRow()
        {
            row["ExtraForTripId"] = this.extraForTripId;
            row["Ename"] = this.ename;
            row["Eprice"] = this.eprice;
           
        }
    }
}

