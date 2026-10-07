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
    public partial class UCTeacher : UserControl
    {
        Teacher tr;
        public UCTeacher()
        {
            InitializeComponent();
            tr = new Teacher();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!Validation.CheckId(txtTeacherId.Text))
            {
                MessageBox.Show("התעודה זהות אינה תקינה");
            }
            else if( txtTeacherId.Text != "")
            {
                if (MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == txtTeacherId.Text) != null)
                {
                    MessageBox.Show("ברוך הבא למערכת!");
                    dataGridView1.DataSource = MyDB.Teacher.GetList().Where(x => x.TeacherId == txtTeacherId.Text).Select(x => new { תעודת_זהות = x.TeacherId, שם_פרטי = x.TFirstName, שם_משפחה = x.TLastName, גיל = x.Tage, טלפון = x.Tphone, עיר = x.CityId, רחוב = x.TStreet, מס_בית = x.THomeNumber, תאריך_תחילת_עבודה = x.TstartWork }).ToList();
                    dataGridView1.Visible = true;
                    btnUpdate.Enabled = true;
                    btnErase.Enabled = true;
                }
                else
                {
                    DialogResult r = MessageBox.Show("המורה אינו קיים במערכת ברצונך לרשום?", "הצעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UCAddTeacher uAddt = new UCAddTeacher();
                        (this.ParentForm as frMain).panel1.Controls.Add(uAddt);
                        (this.ParentForm as frMain).panel1.Controls.Remove(this);
                    }

                    else
                    {
                        MessageBox.Show("שים לב! אין לך אפשרות להכנס למערכת ללא הרשמה !");
                    }
                }
            }
            else
            {
                MessageBox.Show("נא הקש ת.ז");
            }
            
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            tr = MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId ==dataGridView1.CurrentRow.Cells["תעודת_זהות"].Value.ToString());
            DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את המורה?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MyDB.Teacher.DeleteItem(tr);
                MyDB.Teacher.SaveChanges();
                MessageBox.Show("המורה נמחק בהצלחה!");
                dataGridView1.DataSource = MyDB.Teacher.GetList().Select(x => new { תעודת_זהות = x.TeacherId, שם_פרטי = x.TFirstName, שם_משפחה = x.TLastName, גיל = x.Tage, טלפון = x.Tphone, עיר = x.CityId, רחוב = x.TStreet, מס_בית = x.THomeNumber, תאריך_תחילת_עבודה = x.TstartWork }).ToList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           string i = dataGridView1.CurrentRow.Cells["תעודת_זהות"].Value.ToString();
            tr = MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId== i);
            UCAddTeacher uAddt = new UCAddTeacher(tr);
            (this.ParentForm as frMain).panel1.Controls.Add(uAddt);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnWorkHour_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnUpdate.Enabled = true;
            btnErase.Enabled = true;
            dataGridView1.DataSource = MyDB.Teacher.GetList().Select(x => new { תעודת_זהות = x.TeacherId, שם_פרטי = x.TFirstName, שם_משפחה = x.TLastName, גיל = x.Tage, טלפון = x.Tphone, עיר = x.CityId, רחוב = x.TStreet, מס_בית = x.THomeNumber, תאריך_תחילת_עבודה = x.TstartWork }).ToList();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCMannagerMain um = new UCMannagerMain();
            (this.ParentForm as frMain).panel1.Controls.Add(um);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
