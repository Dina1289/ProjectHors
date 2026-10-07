namespace פרויקט_שלי.GUI
{
    partial class UCStudent_sCourse
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
            this.btnAddNote = new System.Windows.Forms.Button();
            this.gbNote = new System.Windows.Forms.GroupBox();
            this.btnOkNote = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnViewNote = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(688, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.Peru;
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.Location = new System.Drawing.Point(699, 542);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(200, 60);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "הוספת הערה";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // gbNote
            // 
            this.gbNote.Controls.Add(this.btnOkNote);
            this.gbNote.Controls.Add(this.richTextBox1);
            this.gbNote.Location = new System.Drawing.Point(88, 212);
            this.gbNote.Name = "gbNote";
            this.gbNote.Size = new System.Drawing.Size(306, 377);
            this.gbNote.TabIndex = 2;
            this.gbNote.TabStop = false;
            this.gbNote.Text = "מילוי הערה";
            this.gbNote.Visible = false;
            // 
            // btnOkNote
            // 
            this.btnOkNote.BackColor = System.Drawing.Color.Peru;
            this.btnOkNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOkNote.ForeColor = System.Drawing.Color.White;
            this.btnOkNote.Location = new System.Drawing.Point(30, 302);
            this.btnOkNote.Name = "btnOkNote";
            this.btnOkNote.Size = new System.Drawing.Size(99, 42);
            this.btnOkNote.TabIndex = 6;
            this.btnOkNote.Text = "אישור";
            this.btnOkNote.UseVisualStyleBackColor = false;
            this.btnOkNote.Click += new System.EventHandler(this.btnOkNote_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 164);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // btnViewNote
            // 
            this.btnViewNote.BackColor = System.Drawing.Color.Peru;
            this.btnViewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnViewNote.ForeColor = System.Drawing.Color.White;
            this.btnViewNote.Location = new System.Drawing.Point(925, 542);
            this.btnViewNote.Name = "btnViewNote";
            this.btnViewNote.Size = new System.Drawing.Size(200, 60);
            this.btnViewNote.TabIndex = 3;
            this.btnViewNote.Text = "צפיית הערה";
            this.btnViewNote.UseVisualStyleBackColor = false;
            this.btnViewNote.Click += new System.EventHandler(this.btnViewNote_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.Peru;
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowList.ForeColor = System.Drawing.Color.White;
            this.btnShowList.Location = new System.Drawing.Point(452, 543);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(224, 60);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "תצוגת דוח הערות";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // UCStudent_sCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnViewNote);
            this.Controls.Add(this.gbNote);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCStudent_sCourse";
            this.Size = new System.Drawing.Size(1395, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.GroupBox gbNote;
        private System.Windows.Forms.Button btnOkNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnViewNote;
        private System.Windows.Forms.Button btnShowList;
    }
}
