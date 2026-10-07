using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
   public class CoursMeeting:GeneralRow
    {
		private int coursMeetingId;
		private int coursId;
		private DateTime meetingdate;

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


		public int CoursMeetingId
        {
			get { return coursMeetingId; }
			set { coursMeetingId = value; }
		}
        public CoursMeeting()
        {

        }
        public CoursMeeting(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.coursMeetingId = Convert.ToInt32(row["CoursMeetingId"]);
            this.coursId = Convert.ToInt32( row["CoursId"]);
            this.meetingdate =Convert.ToDateTime( row["Meetingdate"]);
          
        }
        public override void FillDataRow()
        {
            row["CoursMeetingId"] = this.coursMeetingId;
            row["CoursId"] = this.coursId;
            row["Meetingdate"] = this.meetingdate;
        }
           
    }
}
    

    

