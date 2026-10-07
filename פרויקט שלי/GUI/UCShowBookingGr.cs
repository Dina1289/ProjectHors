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
    public partial class UCShowBookingGr : UserControl
    {
        string phone;
        BookingTrip b;
        public UCShowBookingGr(string p)
        {
            InitializeComponent();
            phone = p;
            dataGridView1.DataSource = MyDB.BookingTrip.GetList().Where(x => x.BookingPhone == phone).Select(x => new { מספר_הזמנה = x.BookingTripId, שם_מזמין = x.BookingName, מספר_טלפון = x.BookingPhone, מספר_מטיילים = x.NumberTripper }).ToList();
        }

        private void UCShowBookingGr_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNeBook_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_הזמנה"].Value);
            b = MyDB.BookingTrip.GetList().FirstOrDefault(x => x.BookingTripId == i);
            string s = "מסייר קיים";
            UCGroup up = new UCGroup(b,s);
            (this.ParentForm as frMain).panel1.Controls.Add(up);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
    }
}
