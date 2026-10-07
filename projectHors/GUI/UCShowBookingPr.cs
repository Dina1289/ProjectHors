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
    public partial class UCShowBookingPr : UserControl
    {
        BookingTrip b;
        int tripId;
        string p;
        int e;
        public UCShowBookingPr(string pn)
        {
            InitializeComponent();
            p = pn;
            dataGridView1.DataSource = MyDB.BookingTrip.GetList().Where(x => x.BookingPhone == p).Select(x => new { מספר_הזמנה = x.BookingTripId, שם_מזמין = x.BookingName, מספר_טלפון = x.BookingPhone, מספר_מטיילים = x.NumberTripper }).ToList();

        }
        public UCShowBookingPr(Trips t)
        {
            InitializeComponent();
            tripId = t.TripId;
        }

        private void btnAnotherBooking_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_הזמנה"].Value);
            b = MyDB.BookingTrip.GetList().FirstOrDefault(x => x.BookingTripId == i);
            string s = "מסייר קיים";
            UCTripPrivate up = new UCTripPrivate(b,s);
            (this.ParentForm as frMain).panel1.Controls.Add(up);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_הזמנה"].Value);
            b = MyDB.BookingTrip.GetList().FirstOrDefault(x => x.BookingTripId == i);
            UCBooking ub = new UCBooking(b);
            (this.ParentForm as frMain).panel1.Controls.Add(ub);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
    }
}
