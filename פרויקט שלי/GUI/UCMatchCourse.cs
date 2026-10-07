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
    public partial class UCMatchCourse : UserControl
    {
        Courses c;
        public UCMatchCourse()
        {
            InitializeComponent();
            c = new Courses();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
