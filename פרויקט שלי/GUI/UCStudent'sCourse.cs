using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using פרויקט_שלי.BLL;

namespace פרויקט_שלי.GUI
{
    public partial class UCStudent_sCourse : UserControl
    {
        Courses course;
        Student s;
        Student sc;
        MeetingForStudent currentM;
        string status;
        bool n;
        int i;
        public UCStudent_sCourse(Courses cr)
        {
            currentM = new MeetingForStudent();
            InitializeComponent();
            course = cr;
            //i = MyDB.CourseMeeting.GetList().FirstOrDefault(x => x.CoursId == course.CoursId).CourseMeetingId;
            dataGridView1.DataSource = MyDB.MeetingForStudent.GetList().Where(x => x.CourseMeetings.CoursId== course.CoursId /*&& x.CourseMeetings.Meetingdate==DateTime.Today*/).Select(x => new { תעודה_זהות = x.StudentId, שם_פרטי = x.Students.SlastName, שם_משפחה = x.Students.SfirstName, מספר_טלפון = x.Students.SPhoneNumber, תאריך_לידה = x.Students.Sbirthdate, מספר_קורס = x.Students.CoursId }).ToList();
        }
        public UCStudent_sCourse(Student st)
        {
            InitializeComponent();
            sc = st;
            dataGridView1.DataSource = MyDB.MeetingForStudent.GetList().Where(x => x.CoursMeetingId == sc.CoursId && x.CourseMeetings.Meetingdate == DateTime.Today).Select(x => new { תעודה_זהות = x.StudentId, שם_פרטי = x.Students.SlastName, שם_משפחה = x.Students.SfirstName, מספר_טלפון = x.Students.SPhoneNumber, תאריך_לידה = x.Students.Sbirthdate, מספר_קורס = x.Students.CoursId }).ToList();

        }
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (n != false)
            {
                gbNote.Visible = true;
                status = "UpDate";
            }
            else
            {
                gbNote.Visible = true;
                status = "Add";
            }
        }
        public void FillObj()
        {
            currentM.MeetingForStudentId=MyDB.MeetingForStudent.GetNextKey();   
            currentM.CoursMeetingId=MyDB.CourseMeeting.GetList().FirstOrDefault(x=>x.CoursId==s.CoursId).CourseMeetingId;
            currentM.StudentId=s.StudentId;  
            currentM.Note=richTextBox1.Text;
        }
        public void FillFields()
        {
            richTextBox1.Text = currentM.Note;
        }

        private void btnOkNote_Click(object sender, EventArgs e)
        {
            FillObj();
            if (status == "Add")
            {
                MyDB.MeetingForStudent.UpdateItem(currentM);
                MyDB.MeetingForStudent.SaveChanges();
                MessageBox.Show("הערה נוספה בהצלחה");
                gbNote.Visible = false;
            }
            else if(status == "UpDate" || btnAddNote.Text == "לעדכן הערה")
            {
                MyDB.MeetingForStudent.UpdateItem(currentM);
                MyDB.MeetingForStudent.SaveChanges();
                MessageBox.Show("הערה עודכנה בהצלחה");
                gbNote.Visible = false;
            }
            else
            {
                MessageBox.Show("הצפיה נקלטה במערכת");
                btnAddNote.Text = "לעדכן הערה";
                gbNote.Visible = false;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string i = dataGridView1.CurrentRow.Cells["תעודה_זהות"].Value.ToString();
                s = MyDB.Student.GetList().FirstOrDefault(x => x.StudentId == i);
                if (s != null)
                {
                    currentM = MyDB.MeetingForStudent.GetList().FirstOrDefault(x => x.StudentId == s.StudentId);

                    if (currentM!=null&&currentM.Note!="")
                    {
                        n = true;
                        FillFields();
                       
                    }
                    else
                    {

                        n = false;
                        currentM = new MeetingForStudent();
                    }
                }
            }

        }

        private void btnViewNote_Click(object sender, EventArgs e)
        {
            if (currentM != null && currentM.Note != "")
            {
                gbNote.Visible = true;
                FillFields();
                status = "watch";
            }
            else
            {
                MessageBox.Show("אין הערה  לצפיה");
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string i = dataGridView1.CurrentRow.Cells["תעודה_זהות"].Value.ToString();
                s = MyDB.Student.GetList().FirstOrDefault(x => x.StudentId == i);
                if (s != null)
                {
                    UCAddNote un = new UCAddNote(s);
                    (this.ParentForm as frMain).panel1.Controls.Add(un);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);

                }
            }
        }
    }
}
