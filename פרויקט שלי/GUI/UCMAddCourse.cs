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
    public partial class UCMAddCourse : UserControl
    {
        Courses currentCourse;
        string status;
        HoursWork currentHw;
        CourseMeeting currentM;
        string idteacher;
        public UCMAddCourse()
        {
            InitializeComponent();
            currentCourse = new Courses();
            currentHw = new HoursWork();
            currentM=new CourseMeeting();
            dtpCDateStart.MinDate= DateTime.Today;
            dtpCDateStart.MaxDate= DateTime.Today.AddMonths(2);
            txtNowAmount.Text=0.ToString();
            status = "Add";
           // cbMTeacher.DataSource = MyDB.Teacher.GetList().Select(x => x.TFirstName + " " + x.TLastName).ToList();
        }
        public UCMAddCourse(Courses c)
        {
            InitializeComponent();
            currentCourse = c;
            status = "Update";
            MyDB.Updateteacher = c.TeacherId;
            FillFields();
           // cbMTeacher.DataSource = MyDB.Teacher.GetList().Select(x => x.TFirstName + " " + x.TLastName).ToList();

        }
        public void FilObj()
        {
            currentCourse.CStartDate = dtpCDateStart.Value;
            currentCourse.CFromHour = dtpCStartHour.Value;
            currentCourse.CTiLhour = dtpCFinishHour.Value;
            currentCourse.TeacherId = MyDB.Teacher.GetList().FirstOrDefault(x => x.TFirstName + " " + x.TLastName == cbMTeacher.SelectedItem.ToString()).TeacherId;
            currentCourse.CoursId = MyDB.Courses.GetNextKey();
            currentCourse.CPrice = Convert.ToInt32(txtCprice.Text);
            currentCourse.MeetingNumber = Convert.ToInt32(txtCmeetingNumber.Text);
            currentCourse.FirstAge =Convert.ToInt32(txtFromAge.Text);
            currentCourse.LastAge = Convert.ToInt32( txtTilAge.Text);
            currentCourse.MaxAmount = Convert.ToInt32(txtMaxAmount.Text);
            currentCourse.PercentAmount = Convert.ToInt32(txtNowAmount.Text);
            currentHw.HoursWorkId = MyDB.HoursWork.GetNextKey();
            currentHw.FromHour = dtpCStartHour.Value;
            currentHw.TilHour = dtpCFinishHour.Value;
            currentHw.Day = dtpCDateStart.Value.DayOfWeek.ToString();
            currentHw.TeacherId = MyDB.Teacher.GetList().FirstOrDefault(x => x.TFirstName + " " + x.TLastName == cbMTeacher.SelectedItem.ToString()).TeacherId;
            currentHw.HStatus = true;
        }
        public void FillFields()
        {
            dtpCDateStart.Value = currentCourse.CStartDate;
            dtpCStartHour.Value = currentCourse.CFromHour;
            dtpCFinishHour.Value = currentCourse.CTiLhour;
            cbMTeacher.SelectedValue = currentCourse.TeacherId;
            txtCprice.Text = currentCourse.CPrice.ToString();
            txtCmeetingNumber.Text = currentCourse.MeetingNumber.ToString();
            txtFromAge.Text = currentCourse.FirstAge.ToString();
            txtTilAge.Text = currentCourse.LastAge.ToString();
            txtMaxAmount.Text = currentCourse.MaxAmount.ToString();
            txtNowAmount.Text = currentCourse.PercentAmount.ToString();
        }

        private void btnokCourse_Click(object sender, EventArgs e)
        {
            if (status == "Add")
            {

                FilObj();
                MyDB.Courses.AddItem(currentCourse);
                MyDB.Courses.SaveChanges();
                MyDB.HoursWork.AddItem(currentHw);
                MyDB.HoursWork.SaveChanges();
                MessageBox.Show("הקורס נוסף בהצלחה");
                DateTime c = currentCourse.CStartDate;
                for (int i = 0; i < currentCourse.MeetingNumber; i++)
                {
                    DateTimePicker d = new DateTimePicker();
                   
                    if (i > 1)
                    {
                        c = currentCourse.CStartDate.AddDays(7);
                        d.Value = c;
                        flowLayoutPanel1.Controls.Add(d);
                    }
                    else
                    {
                        d.Value = c;
                        flowLayoutPanel1.Controls.Add(d);
                        c = currentCourse.CStartDate.AddDays(7);
                    }
                    
                }
                button2.Visible = true;

               
            }

            else
            {

                FilObj();
                MyDB.Courses.UpdateItem(currentCourse);
                MyDB.Courses.SaveChanges();
                MyDB.HoursWork.UpdateItem(currentHw);
                MyDB.HoursWork.SaveChanges();
                MyDB.CourseMeeting.UpdateItem(currentM);
                MyDB.CourseMeeting.SaveChanges();
                MessageBox.Show("הקורס עודכן בהצלחה");
                UCManaagecourse um = new UCManaagecourse();
                (this.ParentForm as frMain).panel1.Controls.Add(um);
                (this.ParentForm as frMain).panel1.Controls.Remove(this);
            }

        }

        private void dtpCDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (cbMTeacher.Items != null)
            { 
                cbMTeacher.Items.Clear();
                cbMTeacher.Select();
                cbMTeacher.SelectedText="נא בחר מורה";

            }
            if (dtpCDateStart.Value.Date == DateTime.Today.Date)
            {
                MessageBox.Show("אין אפשרות לבחור תאריך זה");
            }
            else
            {
                foreach (Teacher item in MyDB.Teacher.GetList())
                {
                    if (MyDB.HoursWork.GetList().FirstOrDefault(x => x.TeacherId == item.TeacherId) == null)
                    {
                        cbMTeacher.Items.Add(item.TFirstName + " " + item.TLastName);
                    }
                    else if (MyDB.HoursWork.GetList().Where(x => x.TeacherId == item.TeacherId).FirstOrDefault(x => x.Day == dtpCDateStart.Value.DayOfWeek.ToString() && x.FromHour.TimeOfDay == dtpCStartHour.Value.TimeOfDay && x.TilHour.TimeOfDay == dtpCFinishHour.Value.TimeOfDay) == null)
                    {
                        cbMTeacher.Items.Add(item.TFirstName + " " + item.TLastName);
                    }
                    else if (MyDB.HoursWork.GetList().FirstOrDefault(x => x.Day == dtpCDateStart.Value.DayOfWeek.ToString() && x.FromHour.TimeOfDay == dtpCStartHour.Value.TimeOfDay && x.TilHour.TimeOfDay == dtpCFinishHour.Value.TimeOfDay).HStatus == false)
                    {
                        cbMTeacher.Items.Add(item.TFirstName + " " + item.TLastName);

                    }
                }
            }
            if (cbMTeacher.Items == null)
            {
                MessageBox.Show("אין מורה פנוי בשעות אלו נא בחר שעות אחרות");
            }

        }

        private void txtFromAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtMaxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtTilAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtCprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtCmeetingNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseMeeting c = new CourseMeeting();
            foreach (DateTimePicker item in flowLayoutPanel1.Controls)
            {
                c.CourseMeetingId = MyDB.CourseMeeting.GetNextKey();
                c.Meetingdate = item.Value;
                c.CoursId = currentCourse.CoursId;
                MyDB.CourseMeeting.AddItem(c);
            }
            MyDB.CourseMeeting.SaveChanges();
            UCManaagecourse um = new UCManaagecourse();
            (this.ParentForm as frMain).panel1.Controls.Add(um);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void UCMAddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
