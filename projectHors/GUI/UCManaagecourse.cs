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
    public partial class UCManaagecourse : UserControl
    {
        Courses c = new Courses();
        HoursWork hw = new HoursWork();
        string idteacher;
        public UCManaagecourse()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = MyDB.Courses.GetList().Select(x => new { מספר_קורס = x.CoursId, שעת_התחלה = x.CFromHour.TimeOfDay, שעת_סיום = x.CTiLhour.TimeOfDay, מספר_מפגשים = x.MeetingNumber, מורה = x.teacher.TFirstName, מגיל = x.FirstAge, עד_גיל = x.LastAge, מספר_משתתפים = x.MaxAmount, כמות_רשומים = x.PercentAmount, מחיר = x.CPrice, תאריך = x.CStartDate.Date }).ToList();
         
        }

        private void btnAddMgCourse_Click(object sender, EventArgs e)
        {
            UCMAddCourse uc=new UCMAddCourse();
            (this.ParentForm as frMain).panel1.Controls.Add(uc);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
            
        private void bnMUpdateCou_Click(object sender, EventArgs e)
        {
            int i =Convert.ToInt32( dataGridView1.CurrentRow.Cells["מספר_קורס"].Value);
            c = MyDB.Courses.GetList().FirstOrDefault(x => x.CoursId == i);
            UCMAddCourse uc = new UCMAddCourse(c);
            (this.ParentForm as frMain).panel1.Controls.Add(uc);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnEraseCour_Click(object sender, EventArgs e)
        {
            c = MyDB.Courses.GetList().FirstOrDefault(x => x.CoursId == Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_קורס"].Value));
            idteacher = MyDB.Courses.GetList().FirstOrDefault(x => x.TeacherId==c.TeacherId).TeacherId.ToString();
            DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הקורס?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                hw = MyDB.HoursWork.GetList().Where(x => x.TeacherId == idteacher).FirstOrDefault(x => x.Day == c.CStartDate.DayOfWeek.ToString() && x.FromHour.TimeOfDay == c.CFromHour.TimeOfDay && x.TilHour.TimeOfDay == c.CTiLhour.TimeOfDay);
                hw.HStatus = false;
                MyDB.HoursWork.UpdateItem(hw);
                MyDB.HoursWork.SaveChanges();
                MyDB.Courses.DeleteItem(c);
                MyDB.Courses.SaveChanges();
                MessageBox.Show("הקורס נמחק בהצלחה!");
                dataGridView1.DataSource = MyDB.Courses.GetList().Select(x => new { מספר_קורס = x.CoursId, שעת_התחלה = x.CFromHour, שעת_סיום = x.CTiLhour, מספר_מפגשים = x.MeetingNumber, מורה = x.teacher.TFirstName, מגיל = x.FirstAge, עד_גיל = x.LastAge, מספר_משתתפים = x.MaxAmount, כמות_רשומים = x.PercentAmount, מחיר = x.CPrice, תאריך = x.CStartDate }).ToList();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCMannagerMain um = new UCMannagerMain();
            (this.ParentForm as frMain).panel1.Controls.Add(um);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
    }
}
