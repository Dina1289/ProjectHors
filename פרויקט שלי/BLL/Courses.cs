using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
   public class Courses:GeneralRow
    {
        private int coursId;
        private DateTime cfromHour;
        private DateTime cTiLhour;
        private int meetingNumber;
        private string teacherId;
        private int firstAge;
        private int lastAge;
        private int maxAmount;
        private int percentAmount;
        private int cPrice;
        private DateTime cStartDate;
        #region-פעולות גישה
        public DateTime CStartDate
        {
            get { return cStartDate; }
            set { cStartDate = value; }
        }


        public int CPrice
        {
            get { return cPrice; }
            set { cPrice = value; }
        }


        public int PercentAmount
        {
            get { return percentAmount; }
            set { percentAmount = value; }
        }


        public int MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }


        public int LastAge
        {
            get { return lastAge; }
            set { lastAge = value; }
        }


        public int FirstAge
        {
            get { return firstAge; }
            set { firstAge = value; }
        }


        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }


        public int MeetingNumber
        {
            get { return meetingNumber; }
            set { meetingNumber = value; }
        }


        public DateTime CTiLhour
        {
            get { return cTiLhour; }
            set { cTiLhour = value; }
        }


        public DateTime CFromHour
        {
            get { return  cfromHour; }
            set { cfromHour = value; }
        }


        public int CoursId
        {
            get { return coursId; }
            set { coursId = value; }
        }
        public Teacher teacher
        {
            get
            {
                return MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == this.TeacherId);
            }
        }
        #endregion

        public Teacher Teacher
        {
            get
            {
                return MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == this.TeacherId);
            }
        }
        public Courses()
        {

        }
        public Courses(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.coursId =Convert.ToInt32( row["CoursId"]);
            this.cfromHour =Convert.ToDateTime( row["CFromHour"]);
            this.cTiLhour =Convert.ToDateTime( row["CTiLhour"]);
            this.meetingNumber = Convert.ToInt32(row["MeetingNumber"]);
            this.teacherId = row["TeacherId"].ToString();
            this.firstAge =Convert.ToInt32( row["FirstAge"]);
            this.lastAge =Convert.ToInt32( row["LastAge"]);
            this.maxAmount = Convert.ToInt32(row["MaxAmount"]);
            this.percentAmount =Convert.ToInt32( row["PercentAmount"]);
            this.cPrice = Convert.ToInt32(row["CPrice"]);
            this.cStartDate = Convert.ToDateTime(row["CStartDate"]);
        }
        public override void FillDataRow()
        {
            row["CoursId"] = this.coursId;
            row["CFromHour"] = this.cfromHour;
            row["CTiLhour"] = this.cTiLhour;
            row["MeetingNumber"]=this.meetingNumber;
            row["TeacherId"] = this.teacherId;
            row["FirstAge"] = this.firstAge;
            row["LastAge"] = this.lastAge;
            row["MaxAmount"] = this.maxAmount;
            row["PercentAmount"] = this.percentAmount;
            row["CPrice"] = this.cPrice;
            row["CStartDate"] = this.cStartDate;
    
        }
    }
}

    
      
   

