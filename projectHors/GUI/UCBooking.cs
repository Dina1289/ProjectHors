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
    public partial class UCBooking : UserControl
    {
        int tripId;
        Trips t ;
        string status;
        BookingTrip currentBooking;
       
        public UCBooking(Trips tp)
        {
            InitializeComponent();
            currentBooking=new BookingTrip();
            tripId = tp.TripId;
            txtmaxtripper.Visible = false;
            label3.Visible = false;
            txtmaxtripper.Text = 1.ToString();
            status = "add";
        }

        public UCBooking(BookingTrip b)
        {
            InitializeComponent();
            currentBooking = b;
            txtmaxtripper.Visible = false;
            label3.Visible = false;
            txtmaxtripper.Text =1.ToString();
            status = "update";
            FillFields();  
        }

        public UCBooking( Trips t, BookingTrip b)
        {
            InitializeComponent();
            currentBooking = b;
            tripId=t.TripId;
            txtmaxtripper.Visible = false;
            label3.Visible = false;
            txtmaxtripper.Text = 1.ToString();
            status = "add";
            txtnamebooking.Text = currentBooking.BookingName;
            txtphonebooking.Text = currentBooking.BookingPhone;
        }
        public UCBooking(Trips t, BookingTrip b, string travel)
        {
            InitializeComponent();
            txtmaxtripper.Visible = false;
            label3.Visible = false;
            if (travel == "קבוצה")
            {                
                currentBooking = b;
                tripId = t.TripId;
                status = "add";
                txtnamebooking.Text = currentBooking.BookingName;
                txtphonebooking.Text = currentBooking.BookingPhone;
            }

        }
        public void FillObj()
        {
            currentBooking.BookingTripId = MyDB.BookingTrip.GetNextKey();
            currentBooking.BookingName = txtnamebooking.Text;
            currentBooking.BookingPhone = txtphonebooking.Text;
            currentBooking.NumberTripper = Convert.ToInt32(txtmaxtripper.Text);
            currentBooking.TripId = tripId;
          
              
        }
        public void FillFields()
        {
            txtnamebooking.Text = currentBooking.BookingName;
            txtphonebooking.Text = currentBooking.BookingPhone;
            txtmaxtripper.Text = currentBooking.NumberTripper.ToString();
            tripId = currentBooking.TripId;
           
        }
        private void btnbookingok_Click(object sender, EventArgs e)
        {
            FillObj();
            if (status == "add")
            {
                MyDB.BookingTrip.AddItem(currentBooking);
                MyDB.BookingTrip.SaveChanges();
                t=MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == currentBooking.TripId);
                t.TNowTrriper = currentBooking.NumberTripper;
                MyDB.Trips.UpdateItem(t);
                MyDB.Trips.SaveChanges();
                MessageBox.Show("ההזמנה נוספה בהצלחה");
                UCTripMain ut = new UCTripMain();
                (this.ParentForm as frMain).panel1.Controls.Add(ut);
                (this.ParentForm as frMain).panel1.Controls.Remove(this);
            }
            else
            {
                MyDB.BookingTrip.UpdateItem(currentBooking);
                MyDB.BookingTrip.SaveChanges();
                t = MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == currentBooking.TripId);
                t.TNowTrriper = currentBooking.NumberTripper;
                MyDB.Trips.UpdateItem(t);
                MyDB.Trips.SaveChanges();
                MessageBox.Show("ההזמנה עודכנה בהצלחה");
                UCTripMain ut = new UCTripMain();
                (this.ParentForm as frMain).panel1.Controls.Add(ut);
                (this.ParentForm as frMain).panel1.Controls.Remove(this);
            }

        }

        private void UCBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
