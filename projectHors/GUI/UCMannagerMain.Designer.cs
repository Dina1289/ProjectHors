namespace פרויקט_שלי.GUI
{
    partial class UCMannagerMain
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
            this.btnMTrips = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMannageCou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMTrips
            // 
            this.btnMTrips.BackColor = System.Drawing.Color.Peru;
            this.btnMTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMTrips.ForeColor = System.Drawing.Color.White;
            this.btnMTrips.Location = new System.Drawing.Point(752, 309);
            this.btnMTrips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMTrips.Name = "btnMTrips";
            this.btnMTrips.Size = new System.Drawing.Size(260, 60);
            this.btnMTrips.TabIndex = 1;
            this.btnMTrips.Text = "ניהול סיורים";
            this.btnMTrips.UseVisualStyleBackColor = false;
            this.btnMTrips.Click += new System.EventHandler(this.btnMTrips_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(127, 309);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "ניהול מורים";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMannageCou
            // 
            this.btnMannageCou.BackColor = System.Drawing.Color.Peru;
            this.btnMannageCou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMannageCou.ForeColor = System.Drawing.Color.White;
            this.btnMannageCou.Location = new System.Drawing.Point(433, 309);
            this.btnMannageCou.Name = "btnMannageCou";
            this.btnMannageCou.Size = new System.Drawing.Size(260, 60);
            this.btnMannageCou.TabIndex = 2;
            this.btnMannageCou.Text = "ניהול קורסים";
            this.btnMannageCou.UseVisualStyleBackColor = false;
            this.btnMannageCou.Click += new System.EventHandler(this.btnMannageCou_Click);
            // 
            // UCMannagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMannageCou);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMTrips);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCMannagerMain";
            this.Size = new System.Drawing.Size(1056, 752);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMTrips;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMannageCou;
    }
}
