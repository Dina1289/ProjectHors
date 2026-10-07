using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class Student:GeneralRow
    {
       
        private string studentId;
        private string slastName;
        private string sfirstName;
        private string sPhoneNunber;
        private int cityId;
        private DateTime sbirthdate;
        private string sstreet;
        private string shomeNumber;
        private int referrerId;
        private string horseId;
        private int coursId;
        #region-פעולות גישה
        public int CoursId
        {
            get { return coursId; }
            set { coursId = value; }
        }

        public string HorseId
        {
            get { return horseId; }
            set { horseId = value; }
        }

        public int ReferrerId
        {
            get { return referrerId; }
            set { referrerId = value; }
        }

        public string ShomeNumber
        {
            get { return shomeNumber; }
            set { shomeNumber = value; }
        }

        public string Sstreet
        {
            get { return sstreet; }
            set { sstreet = value; }
        }


        public DateTime Sbirthdate
        {
            get { return sbirthdate; }
            set
            {
                if (DateTime.Today.AddYears(-4) < value)
                    throw new Exception("התלמיד חייב להיות מעל גיל 4");
                sbirthdate = value;
            }
        }


        public int CityId
        {
            get { return cityId;; }
            set { cityId = value; }
        }

        public string SPhoneNumber
        {
            get { return sPhoneNunber; }
            set
            {
                if (value != "" && Validation.IsPelepon(value))
                    sPhoneNunber = value;
                else
                    throw new Exception("מספר טלפון אינו תקין!");
            }
        }

        public string SfirstName
        {
            get { return sfirstName; }
            set { sfirstName = value; }
        }


        public string SlastName
        {
            get { return slastName; }
            set { slastName = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set
            {
                {
                    if (value != "" && Validation.CheckId(value))
                        studentId = value;
                    else
                        throw new Exception("תעודת זהות אינה תקינה");
                }
            }   
        }
        
        public Cities Cities
        {
            get
            {
                return MyDB.Cities.GetList().FirstOrDefault(x => x.CityId == this.CityId);
            }
        }
        public Referrer referrer
        {
            get
            {
                return MyDB.Referrer.GetList().FirstOrDefault(x => x.ReferrerId == this.ReferrerId);
            }
        }
        public Horses horses
        {
            get
            {
                return MyDB.Horses.GetList().FirstOrDefault(x => x.HorseId == this.HorseId);
            }
        }
        public Courses courses
        {
            get
            {
                return MyDB.Courses.GetList().FirstOrDefault(x => x.CoursId == this.CoursId);
            }
        }
        #endregion
        public Student()
        {

        }
        public Student(DataRow row):base(row)
        {

        }
        protected override void FillFields()
        {
            this.studentId = row["StudentId"].ToString();
            this.slastName = row["SlastName"].ToString();
            this.sfirstName = row["SfirstName"].ToString();
            this.SPhoneNumber =row["SPhoneNumber"].ToString();
            this.sbirthdate = Convert.ToDateTime(row["Sbirthdate"]);
            this.referrerId = Convert.ToInt32(row["ReferrerId"]);
            this.cityId = Convert.ToInt32(row["CityId"]);
            this.ShomeNumber =row["ShomeNumber"].ToString();
            this.sstreet = row["Sstreet"].ToString();
            this.coursId = Convert.ToInt32(row["CoursId"]);
            this.horseId = row["HorseId"].ToString();
        }
       public override void FillDataRow()
        {
            row["StudentId"] = this.studentId;
            row["SfirstName"] = this.sfirstName;
            row["SlastName"] = this.slastName;
            row["SPhoneNumber"] = this.SPhoneNumber;
            row["Sbirthdate"] = this.sbirthdate;
            row["ReferrerId"] = this.referrerId;
            row["CityId"] = this.cityId;
            row["ShomeNumber"] = this.shomeNumber;
            row["Sstreet"] = this.sstreet;
            row["CoursId"] = this.coursId;
            row["HorseId"] = this.horseId;
           
        }
    }
}
