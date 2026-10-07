namespace פרויקט_שלי.GUI
{
    partial class UCTripPrivate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdatetrip = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbChooseTeacher = new System.Windows.Forms.ComboBox();
            this.txtPkindtrip = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbAreaTrip = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttrippernumber = new System.Windows.Forms.TextBox();
            this.lbl200 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(900, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "תאריך";
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.BackColor = System.Drawing.Color.Peru;
            this.btnAddTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddTrip.ForeColor = System.Drawing.Color.White;
            this.btnAddTrip.Location = new System.Drawing.Point(218, 608);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(200, 60);
            this.btnAddTrip.TabIndex = 2;
            this.btnAddTrip.Text = "אישור";
            this.btnAddTrip.UseVisualStyleBackColor = false;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(860, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "בחירת שעות";
            // 
            // dtpdatetrip
            // 
            this.dtpdatetrip.Location = new System.Drawing.Point(572, 234);
            this.dtpdatetrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpdatetrip.Name = "dtpdatetrip";
            this.dtpdatetrip.Size = new System.Drawing.Size(274, 26);
            this.dtpdatetrip.TabIndex = 3;
            this.dtpdatetrip.ValueChanged += new System.EventHandler(this.dtpdatetrip_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 492);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "סוג טיול";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "מ\'ס מטיילים";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "בחירת מורה";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.Location = new System.Drawing.Point(578, 622);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(234, 29);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "לתשלום :            ש\"ח";
            // 
            // cbChooseTeacher
            // 
            this.cbChooseTeacher.FormattingEnabled = true;
            this.cbChooseTeacher.Location = new System.Drawing.Point(228, 291);
            this.cbChooseTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbChooseTeacher.Name = "cbChooseTeacher";
            this.cbChooseTeacher.Size = new System.Drawing.Size(180, 28);
            this.cbChooseTeacher.TabIndex = 4;
            // 
            // txtPkindtrip
            // 
            this.txtPkindtrip.Enabled = false;
            this.txtPkindtrip.Location = new System.Drawing.Point(584, 489);
            this.txtPkindtrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPkindtrip.Name = "txtPkindtrip";
            this.txtPkindtrip.Size = new System.Drawing.Size(148, 26);
            this.txtPkindtrip.TabIndex = 5;
            this.txtPkindtrip.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "בחירת אזור";
            // 
            // cbAreaTrip
            // 
            this.cbAreaTrip.FormattingEnabled = true;
            this.cbAreaTrip.Location = new System.Drawing.Point(228, 232);
            this.cbAreaTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAreaTrip.Name = "cbAreaTrip";
            this.cbAreaTrip.Size = new System.Drawing.Size(180, 28);
            this.cbAreaTrip.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(510, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "פרטי טיול";
            // 
            // txttrippernumber
            // 
            this.txttrippernumber.Location = new System.Drawing.Point(228, 356);
            this.txttrippernumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttrippernumber.Name = "txttrippernumber";
            this.txttrippernumber.Size = new System.Drawing.Size(180, 26);
            this.txttrippernumber.TabIndex = 5;
            this.txttrippernumber.TextChanged += new System.EventHandler(this.txttrippernumber_TextChanged);
            this.txttrippernumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttrippernumber_KeyPress);
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl200.Location = new System.Drawing.Point(636, 622);
            this.lbl200.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(65, 32);
            this.lbl200.TabIndex = 6;
            this.lbl200.Text = "200";
            // 
            // cbTime
            // 
            this.cbTime.Enabled = false;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "10:00:00-11:00:00",
            "13:00:00-14:00:00",
            "17:00:00-18:00:00"});
            this.cbTime.Location = new System.Drawing.Point(672, 294);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(174, 28);
            this.cbTime.TabIndex = 7;
            this.cbTime.SelectedValueChanged += new System.EventHandler(this.cbTime_SelectedValueChanged);
            // 
            // UCTripPrivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.txtPkindtrip);
            this.Controls.Add(this.txttrippernumber);
            this.Controls.Add(this.cbAreaTrip);
            this.Controls.Add(this.cbChooseTeacher);
            this.Controls.Add(this.dtpdatetrip);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCTripPrivate";
            this.Size = new System.Drawing.Size(1182, 705);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdatetrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbChooseTeacher;
        private System.Windows.Forms.TextBox txtPkindtrip;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbAreaTrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttrippernumber;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.ComboBox cbTime;
    }
}
