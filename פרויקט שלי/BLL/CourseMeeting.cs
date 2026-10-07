using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace פרויקט_שלי.BLL
{
    public class CourseMeeting:GeneralRow
    {
		private int courseMeetingId;
		private int coursId;
		private DateTime meetingdate;
        #region-פעולות גישה
        public DateTime Meetingdate
        {
			get { return meetingdate; }
			set { meetingdate = value; }
		}


		public int CoursId
        {
			get { return coursId; }
			set { coursId = value; }
		}


		public int CourseMeetingId
        {
			get { return courseMeetingId; }
			set { courseMeetingId = value; }
		}
        #endregion
        public CourseMeeting()
        {

        }
        public CourseMeeting(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.courseMeetingId = Convert.ToInt32(row["CoursMeetingId"]);
            this.coursId = Convert.ToInt32(row["CoursId"]);
            this.meetingdate = Convert.ToDateTime(row["Meetingdate"]);
            

        }
        public override void FillDataRow()
        {
            row["CoursMeetingId"] = this.courseMeetingId;
            row["CoursId"] = this.coursId;
            row["Meetingdate"] = this.meetingdate;
        }
    }
}
