using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace פרויקט_שלי.GUI
{
    public partial class UCMannagerMain : UserControl
    {
        public UCMannagerMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCTeacher ut = new UCTeacher();
            (this.ParentForm as frMain).panel1.Controls.Add(ut);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnMTrips_Click(object sender, EventArgs e)
        {
            UCMannageTrip ut = new UCMannageTrip();
            (this.ParentForm as frMain).panel1.Controls.Add(ut);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }

        private void btnMannageCou_Click(object sender, EventArgs e)
        {
            UCManaagecourse uc = new UCManaagecourse();
            (this.ParentForm as frMain).panel1.Controls.Add(uc);
            (this.ParentForm as frMain).panel1.Controls.Remove(this);
        }
    }
}
