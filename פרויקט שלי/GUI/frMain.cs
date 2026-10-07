using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using פרויקט_שלי.BLL;



namespace פרויקט_שלי.GUI
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Student> ls = new List<Student>(MyDB.Student.GetList());
            //ls = MyDB.Student.GetList();
            if (!Validation.CheckId(txtstudentId.Text))
            {
                MessageBox.Show("התעודת זהות אינה תקינה");
                txtstudentId.Text = "";
            }
            else
            {
                if (MyDB.Student.GetList().FirstOrDefault(x => x.StudentId == txtstudentId.Text) != null)
                {
                    MessageBox.Show("ברוך הבא למערכת");
                    panel1.Controls.Clear();
                    UCStudent us = new UCStudent(MyDB.Student.GetList().FirstOrDefault(x => x.StudentId == txtstudentId.Text));
                    panel1.Controls.Add(us);
                    txtstudentId.Text = "";
                    button3.Visible= false;
                    txtstudentId.Visible= false;
                    lblstudentId.Visible= false;
                    button5.Visible= false;
                }
                else
                {
                    DialogResult r = MessageBox.Show("אינך רשום במערכת. האם ברצונך להירשם ?", "הצעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        panel1.Controls.Clear();
                        UCStudent us = new UCStudent(txtstudentId.Text);
                        panel1.Controls.Add(us);
                        txtstudentId.Text = "";
                        button3.Visible = false;
                        txtstudentId.Visible = false;
                        lblstudentId.Visible = false;
                        button5.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("אין באפשרותך להיכנס למערכת ללא רישום");
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtstudentId.Visible = true;
            button5.Visible = true;
            lblstudentId.Visible = true;
            button4.Visible = false;
            button2.Visible=false;  
            button1.Visible=false;  
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtteacherId.Visible = true;
            button6.Visible = true;
            lblteacherId.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmannagerCode.Visible = true;
            button7.Visible = true;
            lblmannagerCode.Visible=true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            panel1.Controls.Clear();
            UCTripMain um = new UCTripMain();
            panel1.Controls.Add(um);
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
                if (txtmannagerCode.Text == "1234")
                {
                    lblmannagerCode.Visible = false;
                    button4.Visible = false;
                    txtmannagerCode.Visible = false;
                    button7.Visible = false;
                    MessageBox.Show("ברוך הבא!!");
                    txtmannagerCode.Text = "";
                    panel1.Controls.Clear();
                    UCMannagerMain uM = new UCMannagerMain();
                    panel1.Controls.Add(uM);
                    
                }
                else
                {
                    MessageBox.Show("הסיסמא שגויה נסה שוב","שגיאה!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckId(txtstudentId.Text))
            {
                MessageBox.Show("התעודת זהות אינה תקינה");
                txtstudentId.Text = "";
            }
            else
            {
                if (MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == txtteacherId.Text) != null)
                {
                    button2.Visible = false;
                    button6.Visible = false;
                    lblteacherId.Visible = false;
                    txtteacherId.Visible = false;
                    MessageBox.Show("ברוך הבא למערכת");
                    panel1.Controls.Clear();
                    UCPersonalteacher up = new UCPersonalteacher(MyDB.Teacher.GetList().FirstOrDefault(x => x.TeacherId == txtteacherId.Text));
                    panel1.Controls.Add(up);
                    txtteacherId.Text = "";
                }
                else
                {
                    MessageBox.Show("אין באפשרותך להיכנס למערכת ללא רישום");
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            panel1.Controls.Clear();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            lblstudentId.Visible = false;
            txtstudentId.Visible=false;
            txtmannagerCode.Visible = false;
            txtteacherId.Visible=false;
            lblmannagerCode.Visible=false;
            lblteacherId.Visible = false;
            button6 .Visible = false;
            button7 .Visible = false;
        }
        private void txtteacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtstudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
