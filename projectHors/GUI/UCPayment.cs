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
    

    public partial class UCPayment : UserControl
    {
        Payments currentP;
        string id;
        double price;
        double down;
        public UCPayment(Student s ,int d,int sum)
        {
            InitializeComponent();
            currentP = new Payments();
            id = s.StudentId.ToString();
            price =Convert.ToDouble (sum);
            down =((double)d / 100);
            txtFinalPay.Text =(price-(price*down)).ToString();   
            txtID.Text = id;    
            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
        public void FilObJ()
        {
            currentP.PaymentId = MyDB.Payments.GetNextKey();
            currentP.Pdate =DateTime.Today;    
            currentP.StudentId=txtID.Text;
            currentP.PaymentSum = txtFinalPay.Text;
        }

        private void btnOkPayment_Click(object sender, EventArgs e)
        {
            FilObJ();
            MyDB.Payments.AddItem(currentP);
            MyDB.Payments.SaveChanges();
            MessageBox.Show("התשלום התקבל בהצלחה");
        }

        private void UCPayment_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
