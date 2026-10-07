namespace פרויקט_שלי.GUI
{
    partial class UCShowBookingPr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnotherBooking = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Peru;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(296, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(715, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAnotherBooking
            // 
            this.btnAnotherBooking.BackColor = System.Drawing.Color.Peru;
            this.btnAnotherBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAnotherBooking.ForeColor = System.Drawing.Color.White;
            this.btnAnotherBooking.Location = new System.Drawing.Point(259, 549);
            this.btnAnotherBooking.Name = "btnAnotherBooking";
            this.btnAnotherBooking.Size = new System.Drawing.Size(260, 60);
            this.btnAnotherBooking.TabIndex = 1;
            this.btnAnotherBooking.Text = "הזמנה  חדשה";
            this.btnAnotherBooking.UseVisualStyleBackColor = false;
            this.btnAnotherBooking.Click += new System.EventHandler(this.btnAnotherBooking_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Peru;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(537, 549);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(260, 60);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.Color.Peru;
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnErase.ForeColor = System.Drawing.Color.White;
            this.btnErase.Location = new System.Drawing.Point(812, 550);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(260, 60);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "מחיקה";
            this.btnErase.UseVisualStyleBackColor = false;
            // 
            // UCShowBookingPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnotherBooking);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCShowBookingPr";
            this.Size = new System.Drawing.Size(1195, 675);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnotherBooking;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnErase;
    }
}
