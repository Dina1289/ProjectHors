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
    public partial class UCMannageTrip : UserControl
    {
        
        Trips t;
        int k;
        string idteacher;
        HoursWork hw = new HoursWork();



        public UCMannageTrip()
        {
            InitializeComponent();
            t = new Trips();

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            UCViewGBooking ug = new UCViewGBooking();
            (this.ParentForm as frMain).panel1.Controls.Add(ug);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnPrivateViewB_Click(object sender, EventArgs e)
        {
            UCViewPBooking uv = new UCViewPBooking();
            (this.ParentForm as frMain).panel1.Controls.Add(uv);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnViewGTrip_Click(object sender, EventArgs e)
        {
            k = MyDB.KindTrip.GetList().FirstOrDefault(x => x.Kname == "קבוצתי").KindId;
            dataGridView1.DataSource = MyDB.Trips.GetList().Where(x => x.KindId == k).Select(x => new { מספר_טיול = x.TripId, תאריך = x.TDate.Date, משעה = x.TFromHour.TimeOfDay, עד_שעה = x.TTilHour.TimeOfDay, סוג_טיול = x.kindTrip.Kname, מספר_מטיילים = x.MaxTripper, תשלום = x.PaymentTripper, מורה = x.Teachers.TFirstName }).ToList(); 
        }

        private void btnViewPTrips_Click(object sender, EventArgs e)
        {
            k = MyDB.KindTrip.GetList().FirstOrDefault(x => x.Kname == "פרטי").KindId;
            dataGridView1.DataSource = MyDB.Trips.GetList().Where(x => x.KindId == k).Select(x => new { מספר_טיול= x.TripId,תאריך=x.TDate.Date, משעה = x.TFromHour.TimeOfDay, עד_שעה = x.TTilHour.TimeOfDay, סוג_טיול = x.kindTrip.Kname, מספר_מטיילים = x.MaxTripper, תשלום = x.PaymentTripper, מורה = x.Teachers.TFirstName }).ToList();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCMannagerMain um = new UCMannagerMain();
            (this.ParentForm as frMain).panel1.Controls.Add(um);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string s = "מנהל";
            UCTripPrivate up = new UCTripPrivate(s);
            (this.ParentForm as frMain).panel1.Controls.Add(up);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            t = MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_טיול"].Value));
            idteacher = MyDB.Trips.GetList().FirstOrDefault(x => x.TeacherId == t.TeacherId).TeacherId.ToString();
            DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הסיור?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                hw = MyDB.HoursWork.GetList().Where(x => x.TeacherId == idteacher).FirstOrDefault(x => x.Day == t.TDate.DayOfWeek.ToString() && x.FromHour.TimeOfDay == t.TFromHour.TimeOfDay && x.TilHour.TimeOfDay == t.TTilHour.TimeOfDay);
                if (hw != null)
                {
                    hw.HStatus = false;
                    MyDB.HoursWork.UpdateItem(hw);
                    MyDB.HoursWork.SaveChanges();
                }
                t.TStatus = false;
                MyDB.Trips.DeleteItem(t);
                MyDB.Trips.SaveChanges();
                MessageBox.Show("הסיור נמחק בהצלחה!");
                //dataGridView1.DataSource = MyDB.Teacher.GetList();
            }
        }

        private void PictureUpDate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_טיול"].Value);
            t = MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == i);
            string s = "מנהל";
            UCTripPrivate uc = new UCTripPrivate(t,s);
            (this.ParentForm as frMain).panel1.Controls.Add(uc);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);

        }
    }
}
