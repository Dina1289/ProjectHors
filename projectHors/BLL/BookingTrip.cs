using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace פרויקט_שלי.BLL
{
    public class BookingTrip : GeneralRow
    {
        private int bookingTripId;
        private int tripId;
        private int numberTripper;
        private string bookingPhone;
        private string bookingName;
        #region-פעולות גישה
        public string BookingName
        {
            get { return bookingName; }
            set { bookingName = value; }
        }


        public string BookingPhone
        {
            get { return bookingPhone; }
            set { bookingPhone = value; }
        }


        public int NumberTripper
        {
            get { return numberTripper; }
            set { numberTripper = value; }
        }



        public int TripId
        {
            get { return tripId; }
            set { tripId = value; }
        }


        public int BookingTripId
        {
            get { return bookingTripId; }
            set { bookingTripId = value; }
        }


        #endregion
        public BookingTrip()
        {

        }
        public BookingTrip(DataRow row) : base(row)
        {

        }
        public Trips Trip
        {
            get
            {
                return MyDB.Trips.GetList().FirstOrDefault(x => x.TripId == this.tripId);
            }
        }
        protected override void FillFields()
        {
            this.bookingTripId = Convert.ToInt32(row["BookingTripId"]);
            this.tripId = Convert.ToInt32(row["TripId"]);
            this.numberTripper = Convert.ToInt32(row["NumberTripper"]);
            this.bookingName = row["BookingName"].ToString();
            this.bookingPhone = row["BookingPhone"].ToString();

        }
        public override void FillDataRow()
        {
            row["BookingTripId"] = this.bookingTripId;
            row["TripId"] = this.tripId;
            row["NumberTripper"] = this.numberTripper;
            row["BookingName"] = this.bookingName;
            row["BookingPhone"] = this.bookingPhone;


        }
    }
    
}



