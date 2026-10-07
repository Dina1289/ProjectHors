namespace פרויקט_שלי.GUI
{
    partial class UCShowBookingGr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNeBook = new System.Windows.Forms.Button();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(263, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(717, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddNeBook
            // 
            this.btnAddNeBook.BackColor = System.Drawing.Color.Peru;
            this.btnAddNeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddNeBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNeBook.Location = new System.Drawing.Point(243, 589);
            this.btnAddNeBook.Name = "btnAddNeBook";
            this.btnAddNeBook.Size = new System.Drawing.Size(240, 60);
            this.btnAddNeBook.TabIndex = 1;
            this.btnAddNeBook.Text = "הזמנה חדשה";
            this.btnAddNeBook.UseVisualStyleBackColor = false;
            this.btnAddNeBook.Click += new System.EventHandler(this.btnAddNeBook_Click);
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.BackColor = System.Drawing.Color.Peru;
            this.btnUpdateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateBooking.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBooking.Location = new System.Drawing.Point(509, 589);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(240, 60);
            this.btnUpdateBooking.TabIndex = 2;
            this.btnUpdateBooking.Text = "עדכון";
            this.btnUpdateBooking.UseVisualStyleBackColor = false;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(771, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "מחק";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UCShowBookingGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.btnAddNeBook);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCShowBookingGr";
            this.Size = new System.Drawing.Size(1370, 727);
            this.Load += new System.EventHandler(this.UCShowBookingGr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNeBook;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button button3;
    }
}
