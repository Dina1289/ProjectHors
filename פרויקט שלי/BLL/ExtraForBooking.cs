using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace פרויקט_שלי.BLL
{
    public class ExtraForBooking:GeneralRow
    {
        private int extraForBookingId;
        private int extraForTripId;
        private int bookingTripId;
        #region-פעולות גישה
        public int ExtraForBookingId
        {
            get { return extraForBookingId; }
            set { extraForBookingId = value; }
        }

      

        public int BookingTripId
        {
            get { return bookingTripId; }
            set { bookingTripId = value; }
        }


        public int ExtraForTripId
        {
            get { return extraForTripId; }
            set { extraForTripId = value; }
        }
        public ExtraforTrip extraforTrips
        {
            get
            {
                return MyDB.ExtraforTrip.GetList().FirstOrDefault(x => x.ExtraForTripId == this.ExtraForTripId);
            }
        }
        public BookingTrip  BookingTrips 
        {
            get
            {
                return MyDB.BookingTrip.GetList().FirstOrDefault(x => x.BookingTripId == this.BookingTripId);
            }
        }
        #endregion
        public ExtraForBooking()
        {

        }
        public ExtraForBooking(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.extraForBookingId =Convert.ToInt32( row["ExtraForBookingId"]);
            this.extraForTripId =Convert.ToInt32( row["ExtraForTripId"]);
            this.bookingTripId = Convert.ToInt32 (row["BookingTripId"]);
           
        }
        public override void FillDataRow()
        {
            row["ExtraForBookingId"] = this.extraForBookingId;
            row["ExtraForTripId"] = this.extraForTripId;
            row["BookingTripId"] = this.bookingTripId;
           
        }

    }
}
