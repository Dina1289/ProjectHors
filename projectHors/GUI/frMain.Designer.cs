namespace פרויקט_שלי.GUI
{
    partial class frMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.lblmannagerCode = new System.Windows.Forms.Label();
            this.lblteacherId = new System.Windows.Forms.Label();
            this.lblstudentId = new System.Windows.Forms.Label();
            this.txtmannagerCode = new System.Windows.Forms.TextBox();
            this.txtteacherId = new System.Windows.Forms.TextBox();
            this.txtstudentId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmannagerCode
            // 
            this.lblmannagerCode.AutoSize = true;
            this.lblmannagerCode.Location = new System.Drawing.Point(1487, 96);
            this.lblmannagerCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmannagerCode.Name = "lblmannagerCode";
            this.lblmannagerCode.Size = new System.Drawing.Size(52, 20);
            this.lblmannagerCode.TabIndex = 12;
            this.lblmannagerCode.Text = "סיסמא";
            this.lblmannagerCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblmannagerCode.Visible = false;
            // 
            // lblteacherId
            // 
            this.lblteacherId.AutoSize = true;
            this.lblteacherId.Location = new System.Drawing.Point(1172, 91);
            this.lblteacherId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblteacherId.Name = "lblteacherId";
            this.lblteacherId.Size = new System.Drawing.Size(65, 20);
            this.lblteacherId.TabIndex = 13;
            this.lblteacherId.Text = "הכנס ת.ז";
            this.lblteacherId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblteacherId.Visible = false;
            // 
            // lblstudentId
            // 
            this.lblstudentId.AutoSize = true;
            this.lblstudentId.Location = new System.Drawing.Point(825, 89);
            this.lblstudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentId.Name = "lblstudentId";
            this.lblstudentId.Size = new System.Drawing.Size(65, 20);
            this.lblstudentId.TabIndex = 14;
            this.lblstudentId.Text = "הכנס ת.ז";
            this.lblstudentId.Visible = false;
            // 
            // txtmannagerCode
            // 
            this.txtmannagerCode.Location = new System.Drawing.Point(1295, 89);
            this.txtmannagerCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 20);
            this.txtmannagerCode.MaxLength = 4;
            this.txtmannagerCode.Name = "txtmannagerCode";
            this.txtmannagerCode.Size = new System.Drawing.Size(181, 26);
            this.txtmannagerCode.TabIndex = 9;
            this.txtmannagerCode.UseSystemPasswordChar = true;
            this.txtmannagerCode.Visible = false;
            // 
            // txtteacherId
            // 
            this.txtteacherId.Location = new System.Drawing.Point(993, 88);
            this.txtteacherId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtteacherId.MaxLength = 9;
            this.txtteacherId.Name = "txtteacherId";
            this.txtteacherId.Size = new System.Drawing.Size(170, 26);
            this.txtteacherId.TabIndex = 10;
            this.txtteacherId.Visible = false;
            this.txtteacherId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtteacherId_KeyPress);
            // 
            // txtstudentId
            // 
            this.txtstudentId.Location = new System.Drawing.Point(639, 88);
            this.txtstudentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstudentId.MaxLength = 9;
            this.txtstudentId.Name = "txtstudentId";
            this.txtstudentId.Size = new System.Drawing.Size(170, 26);
            this.txtstudentId.TabIndex = 11;
            this.txtstudentId.Visible = false;
            this.txtstudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentId_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(39, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 745);
            this.panel1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(639, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(294, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "תלמיד";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(963, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "מורה";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Peru;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1289, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "מנהל";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(319, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "הזמנת סיור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Peru;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(633, 129);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "ok";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Peru;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(987, 126);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 35);
            this.button6.TabIndex = 0;
            this.button6.Text = "ok";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Peru;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1289, 126);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 35);
            this.button7.TabIndex = 0;
            this.button7.Text = "ok";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::פרויקט_שלי.Properties.Resources.logo_2_01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::פרויקט_שלי.Properties.Resources.תמונה12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1653, 925);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtstudentId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblstudentId);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblmannagerCode);
            this.Controls.Add(this.lblteacherId);
            this.Controls.Add(this.txtmannagerCode);
            this.Controls.Add(this.txtteacherId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frMain";
            this.Text = "frMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmannagerCode;
        private System.Windows.Forms.Label lblteacherId;
        private System.Windows.Forms.Label lblstudentId;
        private System.Windows.Forms.TextBox txtmannagerCode;
        private System.Windows.Forms.TextBox txtteacherId;
        private System.Windows.Forms.TextBox txtstudentId;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}