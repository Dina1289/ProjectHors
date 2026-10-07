using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace פרויקט_שלי.BLL
{
    public class Cities:GeneralRow
    {
        private int cityId;
        private string cityName;
        #region-פעולות גישה
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        #endregion
        public Cities()
        {

        }
        public Cities(DataRow row) : base(row)
        {

        }
        protected override void FillFields()
        {
            this.cityId =Convert.ToInt32( row["CityId"]);
            this.cityName = row["CityName"].ToString();
         
        }
        public override void FillDataRow()
        {
            row["CityId"] = this.cityId;
            row["CityName"] = this.cityName;
           
        }
    }
}

