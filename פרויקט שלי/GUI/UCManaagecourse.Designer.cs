namespace פרויקט_שלי.GUI
{
    partial class UCManaagecourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddMgCourse = new System.Windows.Forms.Button();
            this.bnMUpdateCou = new System.Windows.Forms.Button();
            this.btnEraseCour = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMgCourse
            // 
            this.btnAddMgCourse.BackColor = System.Drawing.Color.Peru;
            this.btnAddMgCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddMgCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddMgCourse.Location = new System.Drawing.Point(526, 612);
            this.btnAddMgCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMgCourse.Name = "btnAddMgCourse";
            this.btnAddMgCourse.Size = new System.Drawing.Size(260, 60);
            this.btnAddMgCourse.TabIndex = 3;
            this.btnAddMgCourse.Text = "הוספת קורס";
            this.btnAddMgCourse.UseVisualStyleBackColor = false;
            this.btnAddMgCourse.Click += new System.EventHandler(this.btnAddMgCourse_Click);
            // 
            // bnMUpdateCou
            // 
            this.bnMUpdateCou.BackColor = System.Drawing.Color.Peru;
            this.bnMUpdateCou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bnMUpdateCou.ForeColor = System.Drawing.Color.White;
            this.bnMUpdateCou.Location = new System.Drawing.Point(838, 612);
            this.bnMUpdateCou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnMUpdateCou.Name = "bnMUpdateCou";
            this.bnMUpdateCou.Size = new System.Drawing.Size(260, 60);
            this.bnMUpdateCou.TabIndex = 2;
            this.bnMUpdateCou.Text = "עדכון קורס";
            this.bnMUpdateCou.UseVisualStyleBackColor = false;
            this.bnMUpdateCou.Click += new System.EventHandler(this.bnMUpdateCou_Click);
            // 
            // btnEraseCour
            // 
            this.btnEraseCour.BackColor = System.Drawing.Color.Peru;
            this.btnEraseCour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEraseCour.ForeColor = System.Drawing.Color.White;
            this.btnEraseCour.Location = new System.Drawing.Point(218, 612);
            this.btnEraseCour.Name = "btnEraseCour";
            this.btnEraseCour.Size = new System.Drawing.Size(260, 60);
            this.btnEraseCour.TabIndex = 4;
            this.btnEraseCour.Text = "מחיקת קורס";
            this.btnEraseCour.UseVisualStyleBackColor = false;
            this.btnEraseCour.Click += new System.EventHandler(this.btnEraseCour_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(230, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(868, 365);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::פרויקט_שלי.Properties.Resources.תמונה8;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(970, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCManaagecourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEraseCour);
            this.Controls.Add(this.btnAddMgCourse);
            this.Controls.Add(this.bnMUpdateCou);
            this.Name = "UCManaagecourse";
            this.Size = new System.Drawing.Size(1189, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMgCourse;
        private System.Windows.Forms.Button bnMUpdateCou;
        private System.Windows.Forms.Button btnEraseCour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
