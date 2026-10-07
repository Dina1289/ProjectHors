using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_שלי.BLL
{
    public class MyDB
    {
        public static StudentTable Student=new StudentTable(); 
        public static TeacherTable Teacher=new TeacherTable();  
        public static ReferrerTable Referrer=new ReferrerTable();   
        public static CoursesTable Courses=new CoursesTable();  
        public static AreaTable Area=new AreaTable();   
        public static TripsTable Trips=new TripsTable();    
        public static PaymentsTable Payments=new PaymentsTable();   
        public static KindTripTable KindTrip=new KindTripTable();   
        public static HoursWorkTable HoursWork=new HoursWorkTable();
        public static HorsesTable Horses=new HorsesTable();
        public static ExtraForBookingTable ExtraForBooking=new ExtraForBookingTable();
        public static ExtraforTripTable ExtraforTrip=new ExtraforTripTable();
        public static BookingTripTable BookingTrip=new BookingTripTable();
        public static CitiesTable Cities=new CitiesTable();
        public static CoursMeetingTable CourseMeeting = new CoursMeetingTable();
        public static MeetingForStudentTable MeetingForStudent =new MeetingForStudentTable();    

        public static  string  Updateteacher;
    }
    
}
