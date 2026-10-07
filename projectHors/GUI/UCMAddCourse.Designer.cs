namespace פרויקט_שלי.GUI
{
    partial class UCMAddCourse
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
            this.dtpCStartHour = new System.Windows.Forms.DateTimePicker();
            this.dtpCFinishHour = new System.Windows.Forms.DateTimePicker();
            this.dtpCDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtMaxAmount = new System.Windows.Forms.TextBox();
            this.txtTilAge = new System.Windows.Forms.TextBox();
            this.txtCmeetingNumber = new System.Windows.Forms.TextBox();
            this.txtNowAmount = new System.Windows.Forms.TextBox();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.txtCprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnokCourse = new System.Windows.Forms.Button();
            this.cbMTeacher = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpCStartHour
            // 
            this.dtpCStartHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCStartHour.Location = new System.Drawing.Point(484, 177);
            this.dtpCStartHour.Name = "dtpCStartHour";
            this.dtpCStartHour.Size = new System.Drawing.Size(174, 26);
            this.dtpCStartHour.TabIndex = 24;
            // 
            // dtpCFinishHour
            // 
            this.dtpCFinishHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCFinishHour.Location = new System.Drawing.Point(832, 177);
            this.dtpCFinishHour.Name = "dtpCFinishHour";
            this.dtpCFinishHour.Size = new System.Drawing.Size(200, 26);
            this.dtpCFinishHour.TabIndex = 23;
            // 
            // dtpCDateStart
            // 
            this.dtpCDateStart.Location = new System.Drawing.Point(832, 243);
            this.dtpCDateStart.Name = "dtpCDateStart";
            this.dtpCDateStart.Size = new System.Drawing.Size(200, 26);
            this.dtpCDateStart.TabIndex = 22;
            this.dtpCDateStart.ValueChanged += new System.EventHandler(this.dtpCDateStart_ValueChanged);
            // 
            // txtMaxAmount
            // 
            this.txtMaxAmount.Location = new System.Drawing.Point(484, 304);
            this.txtMaxAmount.Name = "txtMaxAmount";
            this.txtMaxAmount.Size = new System.Drawing.Size(100, 26);
            this.txtMaxAmount.TabIndex = 20;
            this.txtMaxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAmount_KeyPress);
            // 
            // txtTilAge
            // 
            this.txtTilAge.Location = new System.Drawing.Point(484, 361);
            this.txtTilAge.Name = "txtTilAge";
            this.txtTilAge.Size = new System.Drawing.Size(174, 26);
            this.txtTilAge.TabIndex = 19;
            this.txtTilAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTilAge_KeyPress);
            // 
            // txtCmeetingNumber
            // 
            this.txtCmeetingNumber.Location = new System.Drawing.Point(484, 243);
            this.txtCmeetingNumber.Name = "txtCmeetingNumber";
            this.txtCmeetingNumber.Size = new System.Drawing.Size(174, 26);
            this.txtCmeetingNumber.TabIndex = 17;
            this.txtCmeetingNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmeetingNumber_KeyPress);
            // 
            // txtNowAmount
            // 
            this.txtNowAmount.Location = new System.Drawing.Point(832, 304);
            this.txtNowAmount.Name = "txtNowAmount";
            this.txtNowAmount.Size = new System.Drawing.Size(198, 26);
            this.txtNowAmount.TabIndex = 16;
            // 
            // txtFromAge
            // 
            this.txtFromAge.Location = new System.Drawing.Point(832, 361);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(200, 26);
            this.txtFromAge.TabIndex = 18;
            this.txtFromAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAge_KeyPress);
            // 
            // txtCprice
            // 
            this.txtCprice.Location = new System.Drawing.Point(523, 424);
            this.txtCprice.Name = "txtCprice";
            this.txtCprice.Size = new System.Drawing.Size(128, 26);
            this.txtCprice.TabIndex = 15;
            this.txtCprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCprice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "מספר מפגשים";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1146, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "מגיל";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(716, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "מחיר";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "עד גיל";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "מס משתתפים מקסימלית";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(724, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "פרטי קורס";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1087, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "כמות עכשיוית";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "שעת התחלה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1116, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "שעת סיום";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1038, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "תאריך התחלת הקורס";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1146, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "מורה";
            // 
            // btnokCourse
            // 
            this.btnokCourse.BackColor = System.Drawing.Color.Peru;
            this.btnokCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnokCourse.ForeColor = System.Drawing.Color.White;
            this.btnokCourse.Location = new System.Drawing.Point(682, 546);
            this.btnokCourse.Name = "btnokCourse";
            this.btnokCourse.Size = new System.Drawing.Size(200, 60);
            this.btnokCourse.TabIndex = 25;
            this.btnokCourse.Text = "אישור";
            this.btnokCourse.UseVisualStyleBackColor = false;
            this.btnokCourse.Click += new System.EventHandler(this.btnokCourse_Click);
            // 
            // cbMTeacher
            // 
            this.cbMTeacher.FormattingEnabled = true;
            this.cbMTeacher.Location = new System.Drawing.Point(829, 423);
            this.cbMTeacher.Name = "cbMTeacher";
            this.cbMTeacher.Size = new System.Drawing.Size(200, 28);
            this.cbMTeacher.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 94);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(353, 554);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(117, 672);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 57);
            this.button2.TabIndex = 29;
            this.button2.Text = "אישור";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UCMAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbMTeacher);
            this.Controls.Add(this.btnokCourse);
            this.Controls.Add(this.dtpCStartHour);
            this.Controls.Add(this.dtpCFinishHour);
            this.Controls.Add(this.dtpCDateStart);
            this.Controls.Add(this.txtMaxAmount);
            this.Controls.Add(this.txtTilAge);
            this.Controls.Add(this.txtCmeetingNumber);
            this.Controls.Add(this.txtNowAmount);
            this.Controls.Add(this.txtFromAge);
            this.Controls.Add(this.txtCprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UCMAddCourse";
            this.Size = new System.Drawing.Size(1263, 752);
            this.Load += new System.EventHandler(this.UCMAddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCStartHour;
        private System.Windows.Forms.DateTimePicker dtpCFinishHour;
        private System.Windows.Forms.DateTimePicker dtpCDateStart;
        private System.Windows.Forms.TextBox txtMaxAmount;
        private System.Windows.Forms.TextBox txtTilAge;
        private System.Windows.Forms.TextBox txtCmeetingNumber;
        private System.Windows.Forms.TextBox txtNowAmount;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.TextBox txtCprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnokCourse;
        private System.Windows.Forms.ComboBox cbMTeacher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
    }
}
