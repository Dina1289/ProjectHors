using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class Teacher:GeneralRow
    {
        private string teacherId;
        private string tFirstName;
        private string tLastName;
        private int tage;
        private DateTime tstartWork;
        private string tPhone;
        private string tStreet;
        private int tHomeNumber;
        private int cityId;

        #region-פעולות גישה
        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }

        public int THomeNumber
        {
            get { return tHomeNumber; }
            set { tHomeNumber = value; }
        }

        public string TStreet
        {
            get { return tStreet; }
            set { tStreet = value; }
        }

        public string Tphone
        {
            get { return tPhone; }
            set
            {
                if (value != "" && Validation.IsPelepon(value))
                    tPhone = value;
                else
                    throw new Exception("מספר טלפון אינו תקין!");
            }
        }

        public DateTime TstartWork
        {
            get { return tstartWork; }
            set { tstartWork = value; }
        }

        public int Tage
        {
            get { return tage; }
            set { tage = value; }
        }

        public string TLastName
        {
            get { return tLastName; }
            set { tLastName = value; }
        }

        public string TFirstName
        {
            get { return tFirstName; }
            set { tFirstName = value; }
        }

        public string TeacherId
        {
            get { return teacherId; }
            set
            {
                if (value != "" && Validation.CheckId(value))
                    teacherId = value;
                else
                    throw new Exception("תעודת זהות אינה תקינה");
            }
        }

        #endregion
        public Cities Cities
        {
            get
            {
                return MyDB.Cities.GetList().FirstOrDefault(x => x.CityId == this.CityId);
            }
        }

        public Teacher()
        {

        }
        public Teacher(DataRow row):base(row)
        {

        }
        protected override void FillFields()
        {
            this.teacherId = row["TeacherId"].ToString();
            this.tFirstName = row["TFirstName"].ToString();
            this.tLastName = row["TLastName"].ToString();
            this.tage = Convert.ToInt32(row["TAge"]);
            this.tstartWork = Convert.ToDateTime(row["TstartWork"]);
            this.tPhone = row["TPhone"].ToString();
            this.tStreet = row["TStreet"].ToString();
            this.tHomeNumber = Convert.ToInt32(row["ThomeNumber"]);
            this.cityId = Convert.ToInt32(row["CityId"]);
        }
        public override void FillDataRow()
        {
            row["TeacherId"]=this.teacherId;
            row["TFirstName"] = this.tFirstName;
            row["TLastName"] = this.tLastName;
            row["TAge"] = this.tage;
            row["TstartWork"] = this.tstartWork;
            row["TPhone"] = this.tPhone;
            row["TStreet"] = this.tStreet;
            row["ThomeNumber"] = this.tHomeNumber;
            row["CityId"] = this.cityId;

        }
    }
}
