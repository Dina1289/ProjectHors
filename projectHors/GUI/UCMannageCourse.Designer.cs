namespace פרויקט_שלי.GUI
{
    partial class UCMannageCourse
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
            this.btnAddMgCourse = new System.Windows.Forms.Button();
            this.bnCourseShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMgCourse
            // 
            this.btnAddMgCourse.Location = new System.Drawing.Point(344, 41);
            this.btnAddMgCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMgCourse.Name = "btnAddMgCourse";
            this.btnAddMgCourse.Size = new System.Drawing.Size(186, 35);
            this.btnAddMgCourse.TabIndex = 3;
            this.btnAddMgCourse.Text = "הוספת קורסים";
            this.btnAddMgCourse.UseVisualStyleBackColor = true;
            // 
            // bnCourseShow
            // 
            this.bnCourseShow.Location = new System.Drawing.Point(52, 41);
            this.bnCourseShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnCourseShow.Name = "bnCourseShow";
            this.bnCourseShow.Size = new System.Drawing.Size(186, 35);
            this.bnCourseShow.TabIndex = 2;
            this.bnCourseShow.Text = "תצוגת קורסים";
            this.bnCourseShow.UseVisualStyleBackColor = true;
            // 
            // UCMannageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddMgCourse);
            this.Controls.Add(this.bnCourseShow);
            this.Name = "UCMannageCourse";
            this.Size = new System.Drawing.Size(585, 438);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMgCourse;
        private System.Windows.Forms.Button bnCourseShow;
    }
}
