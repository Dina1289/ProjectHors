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
    public partial class UCGroup : UserControl
    {
        Trips t;
        BookingTrip booking;
        bool group;
      
        public UCGroup()
        {
            InitializeComponent(); 
            
            dataGridView1.DataSource = MyDB.Trips.GetList().Where(x => x.TDate.Date > DateTime.Now && x.TStatus == true && x.TNowTrriper < x.MaxTripper).Select(x => new { מספר = x.TripId, תאריך = x.TDate.Date, שעת_התחלה = x.TFromHour.TimeOfDay, שעת_סיום = x.TTilHour.TimeOfDay, איזור = x.Areas.Aname, מספר_מטיילים = x.MaxTripper, מחיר = x.PaymentTripper, מורה = x.Teachers.TFirstName + " " + x.Teachers.TLastName }).ToList();
        }
        public UCGroup(BookingTrip b,string travel)
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.Trips.GetList().Where(x => x.TDate.Date > DateTime.Now && x.TStatus == true && x.TNowTrriper < x.MaxTripper).Select(x => new { מספר = x.TripId, תאריך = x.TDate.Date, שעת_התחלה = x.TFromHour.TimeOfDay, שעת_סיום = x.TTilHour.TimeOfDay, איזור = x.Areas.Aname, מספר_מטיילים = x.MaxTripper, מחיר = x.PaymentTripper, מורה = x.Teachers.TFirstName+" "+x.Teachers.TLastName }).ToList();
            if (travel == "מסייר קיים")
            {
                group = true;
                booking = b;
            }
        }

        private void btnOkchoicetrip_Click(object sender, EventArgs e)
        {
            //int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר"].Value);
            //t = MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == i);
            if (group == true)
            {
                
                string s = "קבוצה";
                UCBooking ub = new UCBooking(t, booking, s);
                (this.ParentForm as frMain).panel1.Controls.Add(ub);
                (this.ParentForm as frMain).panel1.Controls.Remove(this);
            }
            else
            {
               
                UCBooking ub = new UCBooking(t);
                (this.ParentForm as frMain).panel1.Controls.Add(ub);
                (this.ParentForm as frMain).panel1.Controls.Remove(this);
            }
        }
       

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר"].Value);
                t = MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == i);
            }
            else if (t == null)
            {
                MessageBox.Show("נא לבחור");
            }
        }
    }
}

