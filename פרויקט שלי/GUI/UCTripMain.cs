using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using פרויקט_שלי.BLL;

namespace פרויקט_שלי.GUI
{
    public partial class UCTripMain : UserControl
    {
        BookingTrip b;
        public UCTripMain()
        {
            InitializeComponent();
           
        }

        private void bnPrivate_Click(object sender, EventArgs e)
        {
            txtEnterPrivate.Visible = true;
            label2.Visible = true;
            btnEnterP.Visible = true;
        }

        private void bnGroup_Click(object sender, EventArgs e)
        {
            txtEntergroup.Visible = true;
            label1.Visible = true;
            btnEnterG.Visible = true;
                   
        }

        private void btnEnterG_Click(object sender, EventArgs e)
        {
            if (!Validation.IsPelepon(txtEntergroup.Text))
            {
                MessageBox.Show("פלאפון לא תקין");
            }
            else
            {
                b = MyDB.BookingTrip.GetList().FirstOrDefault(x => x.BookingPhone == txtEntergroup.Text);
                if (b == null)
                {
                    UCGroup ug = new UCGroup();
                    (this.ParentForm as frMain).panel1.Controls.Add(ug);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
                else
                {
                    MessageBox.Show("ברוך הבא");
                    UCShowBookingGr us = new UCShowBookingGr(b.BookingPhone.ToString());
                    (this.ParentForm as frMain).panel1.Controls.Add(us);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
            }
        }

        private void btnEnterP_Click(object sender, EventArgs e)
        {
            if (!Validation.IsPelepon(txtEnterPrivate.Text))
            {
                MessageBox.Show("פלאפון לא תקין");
            }
            else
            {
                b = MyDB.BookingTrip.GetList().FirstOrDefault(x => x.BookingPhone == txtEnterPrivate.Text);
                if (b == null)
                {
                    string s = "מסייר";
                    UCTripPrivate up = new UCTripPrivate(s);
                    (this.ParentForm as frMain).panel1.Controls.Add(up);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
                else
                {
                    MessageBox.Show("ברוך הבא");
                    UCShowBookingPr ub = new UCShowBookingPr(b.BookingPhone.ToString());
                    (this.ParentForm as frMain).panel1.Controls.Add(ub);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
            }
        }
        private void txtEnterPrivate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterPrivate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtEntergroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
