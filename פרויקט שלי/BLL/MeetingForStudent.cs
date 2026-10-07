using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class MeetingForStudent:GeneralRow
    {
        private int meetingForStudentId;
        private string studentId;
        private int coursMeetingId;
        private string note;
        #region-פעולות גישה
        public string Note
        {
            get { return note; }
            set { note = value; }
        }


        public int CoursMeetingId
        {
            get { return coursMeetingId; }
            set { coursMeetingId = value; }
        }


        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }


        public int MeetingForStudentId
        {
            get { return meetingForStudentId; }
            set { meetingForStudentId = value; }
        }
        public CourseMeeting CourseMeetings
        {
            get
            {
                return MyDB.CourseMeeting.GetList().FirstOrDefault(x => x.CourseMeetingId == this.CoursMeetingId);
            }
        }
        public Student Students
        {
            get
            {
                return MyDB.Student.GetList().FirstOrDefault(x => x.StudentId == this.StudentId);
            }
        }
        #endregion-
        public MeetingForStudent()
        {

        }
        public MeetingForStudent(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.MeetingForStudentId = Convert.ToInt32(row["MeetingForStudentId"]);
            this.StudentId = row["StudentId"].ToString();
            this.CoursMeetingId = Convert.ToInt32(row["CoursMeetingId"]);
            this.Note = row["Notes"].ToString();
           
        }
        public override void FillDataRow()
        {
            row["MeetingForStudentId"] = this.MeetingForStudentId;
            row["StudentId"] = this.StudentId;
            row["CoursMeetingId"] = this.CoursMeetingId;
            row["Notes"] = this.Note;
            
        }
    }
}
