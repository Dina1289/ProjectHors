namespace פרויקט_שלי.GUI
{
    partial class UCBooking
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
            this.txtmaxtripper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphonebooking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamebooking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbookingok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmaxtripper
            // 
            this.txtmaxtripper.Location = new System.Drawing.Point(491, 301);
            this.txtmaxtripper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaxtripper.Name = "txtmaxtripper";
            this.txtmaxtripper.Size = new System.Drawing.Size(148, 26);
            this.txtmaxtripper.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "מספר טייילים";
            // 
            // txtphonebooking
            // 
            this.txtphonebooking.Location = new System.Drawing.Point(491, 229);
            this.txtphonebooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphonebooking.Name = "txtphonebooking";
            this.txtphonebooking.Size = new System.Drawing.Size(148, 26);
            this.txtphonebooking.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "טלפון";
            // 
            // txtnamebooking
            // 
            this.txtnamebooking.Location = new System.Drawing.Point(491, 154);
            this.txtnamebooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamebooking.Name = "txtnamebooking";
            this.txtnamebooking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnamebooking.Size = new System.Drawing.Size(148, 26);
            this.txtnamebooking.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(403, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "הזמנת סיור";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "שם";
            // 
            // btnbookingok
            // 
            this.btnbookingok.BackColor = System.Drawing.Color.Peru;
            this.btnbookingok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnbookingok.ForeColor = System.Drawing.Color.White;
            this.btnbookingok.Location = new System.Drawing.Point(328, 371);
            this.btnbookingok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbookingok.Name = "btnbookingok";
            this.btnbookingok.Size = new System.Drawing.Size(123, 46);
            this.btnbookingok.TabIndex = 9;
            this.btnbookingok.Text = "אישור";
            this.btnbookingok.UseVisualStyleBackColor = false;
            this.btnbookingok.Click += new System.EventHandler(this.btnbookingok_Click);
            // 
            // UCBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnbookingok);
            this.Controls.Add(this.txtmaxtripper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtphonebooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnamebooking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UCBooking";
            this.Size = new System.Drawing.Size(969, 676);
            this.Load += new System.EventHandler(this.UCBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaxtripper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphonebooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnamebooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbookingok;
    }
}
