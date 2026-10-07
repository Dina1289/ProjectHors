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
    public partial class UCAddNote : UserControl
    {
        Student s;
        public UCAddNote(Student st)
        {
            InitializeComponent();
            s=st;
            dataGridView1.DataSource = MyDB.MeetingForStudent.GetList().Where(x => x.StudentId == s.StudentId).Select(x => new { הערות = x.Note, תלמיד = x.Students.SfirstName + " " + x.Students.SlastName }).ToList();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCStudent_sCourse us = new UCStudent_sCourse(s);
            (this.ParentForm as frMain).panel1.Controls.Add(us);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
    }
}
