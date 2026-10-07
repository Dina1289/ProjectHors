using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class Horses:GeneralRow
    {
        private string horseId;
        private string hName;
        private DateTime hbirthdate;
        private int cabinNumber;
        #region-פעולות גישה
        public int CabinNumber
        {
            get { return cabinNumber; }
            set { cabinNumber = value; }
        }


        public DateTime Hbirthdate
        {
            get { return hbirthdate; }
            set { hbirthdate = value; }
        }


        public string HName
        {
            get { return hName; }
            set { hName = value; }
        }


        public string HorseId
        {
            get { return horseId; }
            set { horseId = value; }
        }
        #endregion
        public Horses()
        {

        }
        public Horses(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.horseId = row["HorseId"].ToString();
            this.hName = row["HName"].ToString();
            this.hbirthdate = Convert.ToDateTime(row["Hbirthdate"]);
            this.cabinNumber = Convert.ToInt32(row["CabinNumber"]);
          
        }
        public override void FillDataRow()
        {
            row["HorseId"] = this.horseId;
            row["HName"] = this.hName;
            row["Hbirthdate"] = this.hbirthdate;
            row["CabinNumber"] = this.cabinNumber;
            
           
        }
    }
}

