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
    public partial class UCViewGBooking : UserControl
    {
        int k;
        public UCViewGBooking()
        {
            InitializeComponent();
            k = MyDB.KindTrip.GetList().FirstOrDefault(x => x.Kname == "קבוצתי").KindId;
            dataGridView1.DataSource = MyDB.BookingTrip.GetList().Where(x => x.Trip.KindId == k).Select(x => new { מספר_הזמנה = x.BookingTripId, שם_המזמין = x.BookingName, מספר_טלפון = x.BookingPhone, מספר_מטיילים = x.NumberTripper}).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCMannageTrip ut = new UCMannageTrip();
            (this.ParentForm as frMain).panel1.Controls.Add(ut);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
    }
}
