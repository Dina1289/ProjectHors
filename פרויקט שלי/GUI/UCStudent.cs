using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using פרויקט_שלי.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace פרויקט_שלי.GUI
{
    public partial class UCStudent : UserControl
    {
        Student currentStudent;
        Referrer currentR;
        Courses currentC;
        Horses currentH;
        MeetingForStudent currentM;
        string status;
        int age;
     
        public UCStudent(string id)
        {
            InitializeComponent();
            currentStudent = new Student();
            currentR = new Referrer();
            currentC = new Courses();
            currentH = new Horses();
            currentM = new MeetingForStudent();
            txtSId.Text =id.ToString();
            status = "add";
            CbSCity.DataSource = MyDB.Cities.GetList().Select(x => x.CityName).ToList();
            cbchoosehorse.DataSource = MyDB.Horses.GetList().Select(x => x.HName).ToList();
            cbreferrerName.DataSource = MyDB.Referrer.GetList().Select(X => X.RName).ToList();
            dataGridView1.DataSource = MyDB.Courses.GetList().Where(x => x.PercentAmount < x.MaxAmount && x.FirstAge < age && x.LastAge > age).Select(x => new { מספר_קורס = x.CoursId, שעת_התחלה = x.CFromHour, שעת_סיום = x.CTiLhour, מספר_מפגשים = x.MeetingNumber, מורה = x.teacher.TFirstName, מגיל = x.FirstAge, עד_גיל = x.LastAge, כמות_משתתפים = x.MaxAmount, אחוזי_הנחה = x.PercentAmount, מחיר = x.CPrice, תאריך = x.CStartDate }).ToList();
        }
        public UCStudent(Student s)
        {
            InitializeComponent();
            status = "update";
            btnokstudent.Enabled= false;
            currentStudent = s;
            currentC = MyDB.Courses.GetList().FirstOrDefault(x=>x.CoursId == currentStudent.CoursId);
            currentR = MyDB.Referrer.GetList().FirstOrDefault(x => x.ReferrerId == currentStudent.ReferrerId);
            currentH=MyDB.Horses.GetList().FirstOrDefault(x=>x.HorseId == currentStudent.HorseId);  
            FillFields();
            CbSCity.DataSource = MyDB.Cities.GetList().Select(x => x.CityName).ToList();
            cbchoosehorse.DataSource = MyDB.Horses.GetList().Select(x => x.HName).ToList();
            cbreferrerName.DataSource = MyDB.Referrer.GetList().Select(x => x.RName).ToList();
            dataGridView1.DataSource = MyDB.Courses.GetList().Where(x => x.PercentAmount < x.MaxAmount && x.FirstAge < age && x.LastAge > age).Select(x => new { מספר_קורס = x.CoursId, שעת_התחלה = x.CFromHour, שעת_סיום = x.CTiLhour, מספר_מפגשים = x.MeetingNumber, מורה = x.teacher.TFirstName, מגיל = x.FirstAge, עד_גיל = x.LastAge, כמות_משתתפים = x.MaxAmount, אחוזי_הנחה = x.PercentAmount, מחיר = x.CPrice, תאריך = x.CStartDate }).ToList();
        }
  
        private void AddStudent_Click(object sender, EventArgs e)
        {
           if (FillObj())
            {

                if (status == "add")
                {
                    MyDB.Student.AddItem(currentStudent);
                    MyDB.Student.SaveChanges();
                    currentC.PercentAmount++;
                    MyDB.Courses.UpdateItem(currentC);
                    MyDB.Courses.SaveChanges();
                    MessageBox.Show("התלמיד נוסף בהצלחה");
                    MyDB.MeetingForStudent.AddItem(currentM);
                    MyDB.MeetingForStudent.SaveChanges();   
                    UCPayment up = new UCPayment(currentStudent,currentStudent.referrer.DownPercent,currentStudent.courses.CPrice);
                    (this.ParentForm as frMain).panel1.Controls.Add(up);
                    (this.ParentForm as frMain).panel1.Controls.Remove(this);

                }
                else
                {

                    MyDB.Student.UpdateItem(currentStudent);
                    MyDB.Student.SaveChanges();
                    MessageBox.Show("התלמיד עודכן בהצלחה");
                    UCPayment up = new UCPayment(currentStudent, currentStudent.referrer.DownPercent, currentStudent.courses.CPrice);
                    (this.ParentForm as frMain).panel1.Controls.Add(up);
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
                currentStudent.StudentId = txtSId.Text;
                currentStudent.SPhoneNumber=txtSphoneNumber.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSId, ex.Message);
                errorProvider2.SetError(txtSphoneNumber, ex.Message);
                txtSId.Text = "";
                txtSphoneNumber.Text = "";
                flag = false;

            }
            try
            {
                if (DateTime.Today == Convert.ToDateTime(dtpSbirthdate.Text))
                    throw new Exception("🤔🤔🤔?האם נולדת היום");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpSbirthdate, ex.Message);
                flag = false;
            }
            try
            {
                if (txtSfirstName.Text == "")
                    throw new Exception("!שדה חובה");
                else if (txtSfirstName.TextLength < 2)
                    throw new Exception("!שם לא תקין");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSfirstName, ex.Message);
                flag = false;
                txtSfirstName.Text = "";
            }
            try
            {
                if (CbSCity.SelectedItem == null)
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(CbSCity, ex.Message);
                flag = false;
            }
            try
            {
                if (txtSlastName.Text== "")
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSlastName, ex.Message);
                flag = false;
            }
            try
            {
                if (txtSnumberHome.Text == "")
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSnumberHome, ex.Message);
                flag = false;
            }
            try
            {
                if (txtSstreet.Text == "")
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSstreet, ex.Message);
                flag = false;
            }
            try
            {
                if (cbreferrerName.SelectedItem == null)
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbreferrerName, ex.Message);
                flag = false;
            }
            try
            {
                if (cbchoosehorse.SelectedItem == null)
                    throw new Exception("!שדה חובה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbchoosehorse, ex.Message);
                flag = false;
            }
            if (flag)
            {
                currentStudent.StudentId=txtSId.Text;
                currentStudent.SfirstName = txtSfirstName.Text;
                currentStudent.CityId = MyDB.Cities.GetList().FirstOrDefault(X => X.CityName == CbSCity.SelectedValue.ToString()).CityId;
                currentStudent.SPhoneNumber = txtSphoneNumber.Text;
                currentStudent.SlastName = txtSlastName.Text;
                currentStudent.Sbirthdate = dtpSbirthdate.Value;
                currentStudent.ShomeNumber = txtSnumberHome.Text;
                currentStudent.Sstreet = txtSstreet.Text;
                currentStudent.ReferrerId = MyDB.Referrer.GetList().FirstOrDefault(X => X.RName == cbreferrerName.SelectedItem.ToString()).ReferrerId;
                if (currentC != null)
                {
                    currentStudent.CoursId = currentC.CoursId;
                }
                currentStudent.HorseId = MyDB.Horses.GetList().FirstOrDefault(x => x.HName == cbchoosehorse.SelectedItem.ToString()).HorseId;
                currentM.StudentId = currentStudent.StudentId;
                currentM.CoursMeetingId = currentC.CoursId;
                currentM.MeetingForStudentId = MyDB.MeetingForStudent.GetNextKey();
                currentM.Note = "";
                //currentR.DownPercent =Convert.ToInt32(txtSale.Text);
            }
            return flag;
        }
        public void FillFields()
        {
            txtSId.Text = currentStudent.StudentId;
            txtSfirstName.Text = currentStudent.SfirstName.ToString();
            CbSCity.SelectedItem = MyDB.Cities.GetList().FirstOrDefault(X => X.CityId == currentStudent.CityId).CityName;
            txtSphoneNumber.Text = currentStudent.SPhoneNumber.ToString();
            txtSlastName.Text = currentStudent.SlastName.ToString();
            txtSstreet.Text = currentStudent.Sstreet.ToString();
            txtSnumberHome.Text = currentStudent.ShomeNumber;
            dtpSbirthdate.Text = currentStudent.Sbirthdate.ToString();
            cbreferrerName.SelectedItem = MyDB.Referrer.GetList().FirstOrDefault(x => x.ReferrerId == currentR.ReferrerId).RName;
            //string s = MyDB.Horses.GetList().FirstOrDefault(x => x.HorseId == "012").HName;
            cbchoosehorse.SelectedItem = MyDB.Horses.GetList().FirstOrDefault(x=>x.HorseId==currentH.HorseId).HName;
            txtSale.Text = currentStudent.ToString();

        }

   
        private void txtSId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void cbreferrerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            Referrer s = MyDB.Referrer.GetList().FirstOrDefault(x => x.RName == cbreferrerName.SelectedItem.ToString());
            txtSale.Text = s.DownPercent.ToString();

        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnokstudent_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); 
            try
            {
                currentStudent.Sbirthdate = dtpSbirthdate.Value;
                age = DateTime.Now.Year - dtpSbirthdate.Value.Year;
                if(age < 4)
                {
                    throw new Exception("!תאריך לא תקין");

                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpSbirthdate, ex.Message);
            }
            dataGridView1.DataSource = MyDB.Courses.GetList().Where(x => x.PercentAmount < x.MaxAmount && x.FirstAge < age && x.LastAge > age).Select(x => new { מספר_קורס = x.CoursId, שעת_התחלה = x.CFromHour, שעת_סיום = x.CTiLhour, מספר_מפגשים = x.MeetingNumber, מורה = x.teacher.TFirstName, מגיל = x.FirstAge, עד_גיל = x.LastAge, כמות_משתתפים = x.MaxAmount, אחוזי_הנחה = x.PercentAmount, מחיר = x.CPrice, תאריך = x.CStartDate }).ToList();
            dataGridView1.Visible = true;
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("אין קורסים זמינים");
            }
          
        }
       
        private void dtpSbirthdate_ValueChanged(object sender, EventArgs e)
        {
            btnokstudent.Enabled = true;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["מספר_קורס"].Value);
                currentC = MyDB.Courses.GetList().FirstOrDefault(x => x.CoursId == i);
            }
            else if (currentC == null)
            {
                MessageBox.Show("נא לבחור");
            }
        }

        private void UCStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtSId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSfirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtSlastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtSphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtSnumberHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}   