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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace פרויקט_שלי.GUI
{
    public partial class UCAddTeacher : UserControl
    {
        Teacher currentTeacher;
        string status;
        public UCAddTeacher()
        {
            InitializeComponent();
            currentTeacher = new Teacher();
            status = "Add";
            cbTcity.DataSource = MyDB.Cities.GetList().Select(X => X.CityName).ToList();

        }
        public UCAddTeacher(Teacher tr)
        {
            InitializeComponent();
            currentTeacher = new Teacher();
            currentTeacher=tr;
            status = "update";
            FillFields();   
            cbTcity.DataSource = MyDB.Cities.GetList().Select(X => X.CityName).ToList();
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (FillObj())
            {
                if (status == "Add")
                {

                    MyDB.Teacher.AddItem(currentTeacher);
                    MyDB.Teacher.SaveChanges();
                    MessageBox.Show("המורה נוסף בהצלחה!");
                    UCTeacher ut = new UCTeacher();
                    (this.ParentForm as frMain).panel1.Controls.Add(ut);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);

                }
                else
                {

                    MyDB.Teacher.UpdateItem(currentTeacher);
                    MyDB.Teacher.SaveChanges();
                    MessageBox.Show("המורה עודכן בהצלחה!");
                    UCTeacher ut = new UCTeacher();
                    (this.ParentForm as frMain).panel1.Controls.Add(ut);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);
                }
            }
        }
        public bool FillObj()
        {
            errorProvider1.Clear();
            bool flag = true;

            try
            {
                currentTeacher.TeacherId = txtTeacherID.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTeacherID, ex.Message);
                txtTeacherID.Text = "";
                flag = false;
            }
            try
            {
                if (txtTfirstName.Text == "")
                    throw new Exception("!שדה חובה");
                else if (txtTfirstName.TextLength < 2)
                    throw new Exception("!שם לא תקין");
               
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTfirstName, ex.Message);
                flag = false;
                txtTfirstName.Text = "";
            }
            try
            {
                if (txtTlastName.Text == "")
                    throw new Exception("!שדה חובה");
                
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTlastName, ex.Message);
                flag = false;
            }
            try
            {
                currentTeacher.Tphone = txtTphone.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTphone, ex.Message);
                flag = false;
            }
            try
            {
                if (txtTage.Text == "")
                    throw new Exception("!שדה חובה");
                else if (Convert.ToInt32(txtTage.Text) < 25)
                    throw new Exception("!מורה חייב להיות מעל גיל 25");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTage, ex.Message);
                flag = false;
                txtTage.Text = "";
            }
            try
            {
                if (txtThomenumber.Text == "")
                    throw new Exception("!שדה חובה");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtThomenumber, ex.Message);
                flag = false;
            }
            try
            {
                if (txtTsreet.Text == "")
                    throw new Exception("!שדה חובה");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTsreet, ex.Message);
                flag = false;
            }
            try
            {
                if (cbTcity.SelectedItem == null)
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbTcity, ex.Message);
                flag = false;
            }
            if (flag)
            {
                currentTeacher.TFirstName = txtTfirstName.Text;
                currentTeacher.TLastName = txtTlastName.Text;
                currentTeacher.TeacherId = txtTeacherID.Text;
                currentTeacher.Tphone = txtTphone.Text;
                currentTeacher.Tage = Convert.ToInt32(txtTage.Text);
                currentTeacher.THomeNumber = Convert.ToInt32(txtThomenumber.Text);
                currentTeacher.TStreet = txtTsreet.Text;
                currentTeacher.TstartWork = dtpTstartWork.Value;
                currentTeacher.CityId = MyDB.Cities.GetList().FirstOrDefault(X => X.CityName == cbTcity.SelectedValue.ToString()).CityId;
            }
            return flag;
        }
        public void FillFields()
        {
            txtTeacherID.Text = currentTeacher.TeacherId.ToString();
            txtTfirstName.Text = currentTeacher.TFirstName;
            txtTlastName.Text = currentTeacher.TLastName;
            txtTphone.Text = currentTeacher.Tphone;
            txtTsreet.Text = currentTeacher.TStreet;
            txtThomenumber.Text = currentTeacher.THomeNumber.ToString();
            txtTage.Text = currentTeacher.Tage.ToString();
            dtpTstartWork.Value = currentTeacher.TstartWork;
            cbTcity.SelectedItem = MyDB.Cities.GetList().FirstOrDefault(X => X.CityId == currentTeacher.CityId).CityName;
        }

        private void txtTeacherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeacherID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtTage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtTphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtThomenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtTfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtTlastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtTsreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
