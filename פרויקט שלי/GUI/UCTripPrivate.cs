using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using פרויקט_שלי.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace פרויקט_שלי.GUI
{
    public partial class UCTripPrivate : UserControl
    {

        Trips currentTrip;
        string status;
        BookingTrip booking;
        HoursWork currentHw;
        bool single;
        bool t;
        DateTime til;
        DateTime from;

        public UCTripPrivate(string travel)
        {
            InitializeComponent();
            txtPkindtrip.Visible = false;
            if (travel == "מסייר")
            {
                single = true;
                txtPkindtrip.Text = "פרטי";
                txttrippernumber.Visible = false;
                label5.Visible = false;
                txttrippernumber.Text = 1.ToString();
            }
            else if (travel == "מנהל")
            {
                t = true;
                txtPkindtrip.Text = "קבוצתי";

            }

            currentTrip = new Trips();
            dtpdatetrip.MinDate = DateTime.Today;
            dtpdatetrip.MaxDate = DateTime.Today.AddMonths(2);
            status = "Add";
            //cbChooseTeacher.DataSource = MyDB.Teacher.GetList().Select(x => x.TFirstName).ToList();
            cbAreaTrip.DataSource = MyDB.Area.GetList().Select(x => x.Aname).ToList();
            currentHw = new HoursWork();

        }
        public UCTripPrivate(Trips tr, string travel)
        {
            InitializeComponent();
            if (travel == "מנהל")
            {
                status = "UpDate";
                currentTrip = tr;
                currentHw = new HoursWork();
                dtpdatetrip.MinDate = DateTime.Today;
                dtpdatetrip.MaxDate = DateTime.Today.AddMonths(2);
                FillFields();
            }
            //cbChooseTeacher.DataSource = MyDB.Teacher.GetList().Select(x => x.TFirstName).ToList();
            cbAreaTrip.DataSource = MyDB.Area.GetList().Select(x => x.Aname).ToList();
        }
        public UCTripPrivate(BookingTrip b, string travel1)
        {
            InitializeComponent();
            if (travel1 == "מסייר קיים")
            {
                single = false;
                txtPkindtrip.Text = "פרטי";
                txttrippernumber.Visible = false;
                label5.Visible = false;
                txttrippernumber.Text = 1.ToString();
            }
            booking = b;
            currentHw = new HoursWork();
            currentTrip = new Trips();
            dtpdatetrip.MinDate = DateTime.Today;
            dtpdatetrip.MaxDate = DateTime.Today.AddMonths(2);
            status = "Add";
            //cbChooseTeacher.DataSource = MyDB.Teacher.GetList().Select(x => x.TFirstName).ToList();
            cbAreaTrip.DataSource = MyDB.Area.GetList().Select(x => x.Aname).ToList();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            FillObj();
            if (status == "Add")
            {
                MyDB.Trips.AddItem(currentTrip);
                MyDB.Trips.SaveChanges();
                MyDB.HoursWork.AddItem(currentHw);
                MyDB.HoursWork.SaveChanges();
                MessageBox.Show("הסיור נוסף בהצלחה");
                if (single == true)
                {
                    UCBooking ub = new UCBooking(currentTrip);
                    (this.ParentForm as frMain).panel1.Controls.Add(ub);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
                else if (t == true)
                {
                    UCMannageTrip ub = new UCMannageTrip();
                    (this.ParentForm as frMain).panel1.Controls.Add(ub);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
                else if (single == false)
                {
                    UCBooking ub = new UCBooking(currentTrip, booking);
                    (this.ParentForm as frMain).panel1.Controls.Add(ub);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
            }
            else
            {
                MyDB.Trips.UpdateItem(currentTrip);
                MyDB.Trips.SaveChanges();
                MyDB.HoursWork.UpdateItem(currentHw);
                MyDB.HoursWork.SaveChanges();
                MessageBox.Show("הסיור עודכן בהצלחה");
                if (single == true)
                {
                    UCBooking ub = new UCBooking(currentTrip);
                    (this.ParentForm as frMain).panel1.Controls.Add(ub);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
            }
        }
        public void FillObj()
        {
            currentTrip.TripId = MyDB.Trips.GetNextKey();
            currentTrip.TDate = dtpdatetrip.Value;
            currentTrip.TFromHour = from;
            currentTrip.TTilHour = til;
            currentTrip.KindId = MyDB.KindTrip.GetList().FirstOrDefault(X => X.Kname == txtPkindtrip.Text.ToString()).KindId;
            currentTrip.AreaId = MyDB.Area.GetList().FirstOrDefault(x => x.Aname == cbAreaTrip.SelectedValue.ToString()).AreaID;
            currentTrip.MaxTripper = Convert.ToInt32(txttrippernumber.Text);
            currentTrip.PaymentTripper = Convert.ToInt32(lbl200.Text) * Convert.ToInt32(txttrippernumber.Text);
            currentTrip.TeacherId = MyDB.Teacher.GetList().FirstOrDefault(X => X.TFirstName + " " + X.TLastName == cbChooseTeacher.SelectedItem.ToString()).TeacherId;
            currentTrip.TStatus = true;
            currentTrip.TNowTrriper = 0;
            currentHw.HoursWorkId = MyDB.HoursWork.GetNextKey();
            currentHw.FromHour = from;
            currentHw.TilHour = til;
            currentHw.Day = dtpdatetrip.Value.DayOfWeek.ToString();
            currentHw.TeacherId = MyDB.Teacher.GetList().FirstOrDefault(x => x.TFirstName + " " + x.TLastName == cbChooseTeacher.SelectedItem.ToString()).TeacherId;
            currentHw.HStatus = true;

        }
        public void FillFields()
        {
            dtpdatetrip.Value = currentTrip.TDate;
            cbTime.SelectedText=currentTrip.TFromHour.ToString()+"-"+currentTrip.TTilHour.ToString();
            txtPkindtrip.Text = MyDB.KindTrip.GetList().FirstOrDefault(x => x.KindId == currentTrip.KindId).Kname;
            cbAreaTrip.SelectedItem = MyDB.Area.GetList().FirstOrDefault(x => x.AreaID == currentTrip.AreaId).Aname;
            txttrippernumber.Text = currentTrip.MaxTripper.ToString();
            lblPrice.Text = currentTrip.PaymentTripper.ToString();
            cbChooseTeacher.SelectedItem = MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == currentTrip.TeacherId).TFirstName;
            currentTrip.TStatus = true;
        }
        private void txttrippernumber_TextChanged(object sender, EventArgs e)
        {
            if (t == true)
            {
                if (txttrippernumber.Text != "")
                {
                    lbl200.Text = (Convert.ToInt32(txttrippernumber.Text) * 20+200).ToString();
                }
                else { lbl200.Text = "200"; }
            }
        }

        private void cbTime_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbTime.SelectedIndex == 0)   
            {
                from = DateTime.ParseExact("10:00:00", "HH:mm:ss", null);
                til = DateTime.ParseExact("11:00:00", "HH:mm:ss", null);
            }
            else if (cbTime.SelectedIndex == 1)
            {
                from = DateTime.ParseExact("13:00:00", "HH:mm:ss", null);
                til = DateTime.ParseExact("14:00:00", "HH:mm:ss", null);
            }
            else
            {
                from = DateTime.ParseExact("17:00:00", "HH:mm:ss", null);
                til = DateTime.ParseExact("18:00:00", "HH:mm:ss", null);
            }
            if (cbChooseTeacher.Items != null)
            {
                cbChooseTeacher.Items.Clear();
                cbChooseTeacher.Select();
                cbChooseTeacher.SelectedText = "נא לבחור מורה";

            }
            if (dtpdatetrip.Value.Date == DateTime.Today.Date)
            {
                MessageBox.Show("אין אפשרות לבחור תאריך זה");
            }
            else
            {

                foreach (Teacher item in MyDB.Teacher.GetList())
                {
                    if (MyDB.HoursWork.GetList().FirstOrDefault(x => x.TeacherId == item.TeacherId) == null)
                    {
                        cbChooseTeacher.Items.Add(item.TFirstName + " " + item.TLastName);
                    }
                    else if (MyDB.HoursWork.GetList().Where(x => x.TeacherId == item.TeacherId).FirstOrDefault(x => x.Day == dtpdatetrip.Value.DayOfWeek.ToString() && x.FromHour.TimeOfDay== from.TimeOfDay && x.TilHour.TimeOfDay == til.TimeOfDay)== null)
                    {
                        cbChooseTeacher.Items.Add(item.TFirstName + " " + item.TLastName);
                    }
                    else if (MyDB.HoursWork.GetList().FirstOrDefault(x => x.Day == dtpdatetrip.Value.DayOfWeek.ToString() && x.FromHour.Hour == from.Hour && x.TilHour.Hour == til.Hour).HStatus == false)
                    {
                        cbChooseTeacher.Items.Add(item.TFirstName + " " + item.TLastName);
                    }
                   
                }
            }
            if(cbChooseTeacher.Items==null)
            { 
                MessageBox.Show("אין מורה פנוי בשעות אלו נא בחר שעות אחרות");
            }

        }

        private void dtpdatetrip_ValueChanged(object sender, EventArgs e)
        {
          MessageBox.Show("נא בחר שעות","הודעה",MessageBoxButtons.OK);
            cbTime.Enabled = true;
            label3.Enabled = true;

        }

        private void txttrippernumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
