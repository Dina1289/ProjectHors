using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
   public class HoursWork:GeneralRow
    {
        private int hoursWorkId;
        private string teacherId;
        private string day;
        private DateTime fromHour;
        private DateTime tilHour;
        private bool hStatus;
        #region-פעולות גישה
        public bool HStatus
        {
            get { return hStatus; }
            set { hStatus = value; }
        }
        public DateTime TilHour
        {
            get { return tilHour; }
            set { tilHour = value; }
        }


        public DateTime FromHour
        {
            get { return fromHour; }
            set { fromHour = value; }
        }


        public string Day
        {
            get { return day; }
            set { day = value; }
        }


        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }


        public int HoursWorkId
        {
            get { return hoursWorkId; }
            set { hoursWorkId = value; }
        }
        public Teacher Teacher
        {
            get
            {
                return MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == this.TeacherId);
            }
        }
        #endregion
        public HoursWork()
        {

        }
        public HoursWork(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.hoursWorkId = Convert.ToInt32( row["HoursWorkId"]);
            this.teacherId = row["TeacherId"].ToString();
            this.day =  row["dayh"].ToString();
            this.fromHour = Convert.ToDateTime(row["fromHour"]);
            this.tilHour = Convert.ToDateTime(row["tilHour"]);
            this.hStatus = Convert.ToBoolean(row["HStatus"]);
          
        }
        public override void FillDataRow()
        {
            row["HoursWorkId"] = this.hoursWorkId;
            row["TeacherId"] = this.teacherId;
            row["dayh"] = this.day;
            row["fromHour"] = this.fromHour;
            row["tilHour"] = this.tilHour;
            row["HStatus"] = this.hStatus;
        }
    }
}
    
    

