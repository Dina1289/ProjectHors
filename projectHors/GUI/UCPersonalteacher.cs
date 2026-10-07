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
    public partial class UCPersonalteacher : UserControl
    {
        Courses c;
        Teacher teacher;
        public UCPersonalteacher(Teacher t)
        {
            InitializeComponent();
            teacher = t;
            dataGridView1.DataSource = MyDB.Courses.GetList().Where(x => x.TeacherId == teacher.TeacherId).Select(x => new { מספר_קורס = x.CoursId, שעת_התחלה = x.CFromHour, שעת_סיום = x.CTiLhour, מספר_מפגשים = x.MeetingNumber, מורה = x.teacher.TFirstName, מגיל = x.FirstAge, עד_גיל = x.LastAge, כמות_משתתפים = x.MaxAmount, כמות_עכשוית = x.PercentAmount, מחיר = x.CPrice, תאריך = x.CStartDate }).ToList();

        }
        public UCPersonalteacher()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_קורס"].Value);
                c = MyDB.Courses.GetList().FirstOrDefault(x => x.CoursId == i);
                UCStudent_sCourse us = new UCStudent_sCourse(c);
                (this.ParentForm as frMain).panel1.Controls.Add(us);
                (this.ParentForm as frMain).panel1.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("נא לבחור קורס");
            }

        }
    }
}