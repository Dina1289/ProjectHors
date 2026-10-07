using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class Trips:GeneralRow
    {
        private int tripId;
        private DateTime tDate;
        private DateTime tFromHour;
        private DateTime tTilHour;
        private int kindId;
        private int areaId;
        private int maxTripper;
        private int paymentTripper;
        private string teacherId;
        private bool tStatus;
        private int tNowTrriper;

        #region-פעולות גישה
        public int TNowTrriper
        {
            get { return tNowTrriper; }
            set { tNowTrriper = value; }
        }


        public bool TStatus
        {
            get { return tStatus; }
            set { tStatus = value; }
        }

       
        public string TeacherId
        {
            get { return teacherId; }
            set {teacherId = value; }
        }


        public int PaymentTripper
        {
            get { return paymentTripper; }
            set { paymentTripper = value; }
        }


        public int MaxTripper
        {
            get { return maxTripper; }
            set { maxTripper = value; }
        }

        public int AreaId
        {
            get { return areaId; }
            set { areaId = value; }
        }


        public int KindId
        {
            get { return kindId; }
            set { kindId = value; }
        }

        public DateTime TTilHour
        {
            get { return tTilHour; }
            set { tTilHour = value; }
        }


        public DateTime TFromHour
        {
            get { return tFromHour; }
            set { tFromHour = value; }
        }

        public DateTime TDate
        {
            get { return tDate; }
            set { tDate = value; }
        }


        public int  TripId
        {
            get { return tripId; }
            set { tripId = value; }
        }
        public Area Areas
        {
            get
            {
                return MyDB.Area.GetList().FirstOrDefault(x => x.AreaID == this.AreaId);
            }
        }
        public Teacher Teachers

        {
            get
            {
                return MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == this.TeacherId);
            }
        }
        public KindTrip kindTrip

        {
            get
            {
                return MyDB.KindTrip.GetList().FirstOrDefault(x => x.KindId == this.KindId);
            }
        }

        #endregion
        public Trips()
        {

        }
        public Trips(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.tripId = Convert.ToInt32(row["TripId"]);
            this.tDate =Convert.ToDateTime( row["TDate"]);
            this.tFromHour =Convert.ToDateTime(  row["TFromHour"]);
            this.tTilHour = Convert.ToDateTime(row["TTilHour"]);
            this.kindId = Convert.ToInt32(row["KindId"]);
            this.areaId =Convert.ToInt32( row["AreaId"] );
            this.maxTripper =Convert.ToInt32( row["MaxTripper"]);
            this.paymentTripper = Convert.ToInt32(row["PaymentTripper"]);
            this.teacherId =row["TeacherId"].ToString();
            this.tStatus =Convert.ToBoolean( row["TStatus"]);
            this.tNowTrriper =Convert.ToInt32( row["TNowTrriper"]);
        }
        public override void FillDataRow()
        {
            row["TripId"] = this.tripId;
            row["TDate"] = this.tDate;
            row["TFromHour"] = this.tFromHour;
            row["TTilHour"] = this.tTilHour;
            row["KindId"] = this.kindId;
            row["AreaId"] = this.areaId;
            row["MaxTripper"] = this.maxTripper;
            row["PaymentTripper"] = this.paymentTripper;
            row["TeacherId"] = this.teacherId;
            row["TStatus"] = this.tStatus;
            row["TNowTrriper"] = this.tNowTrriper;
        }
    }
}
