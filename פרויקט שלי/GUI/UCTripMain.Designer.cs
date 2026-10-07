namespace פרויקט_שלי.GUI
{
    partial class UCTripMain
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
            this.bnPrivate = new System.Windows.Forms.Button();
            this.bnGroup = new System.Windows.Forms.Button();
            this.txtEntergroup = new System.Windows.Forms.TextBox();
            this.txtEnterPrivate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterG = new System.Windows.Forms.Button();
            this.btnEnterP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnPrivate
            // 
            this.bnPrivate.BackColor = System.Drawing.Color.Peru;
            this.bnPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bnPrivate.ForeColor = System.Drawing.Color.White;
            this.bnPrivate.Location = new System.Drawing.Point(281, 177);
            this.bnPrivate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnPrivate.Name = "bnPrivate";
            this.bnPrivate.Size = new System.Drawing.Size(260, 60);
            this.bnPrivate.TabIndex = 0;
            this.bnPrivate.Text = "פרטי";
            this.bnPrivate.UseVisualStyleBackColor = false;
            this.bnPrivate.Click += new System.EventHandler(this.bnPrivate_Click);
            // 
            // bnGroup
            // 
            this.bnGroup.BackColor = System.Drawing.Color.Peru;
            this.bnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bnGroup.ForeColor = System.Drawing.Color.White;
            this.bnGroup.Location = new System.Drawing.Point(716, 177);
            this.bnGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnGroup.Name = "bnGroup";
            this.bnGroup.Size = new System.Drawing.Size(260, 60);
            this.bnGroup.TabIndex = 0;
            this.bnGroup.Text = "קבוצה";
            this.bnGroup.UseVisualStyleBackColor = false;
            this.bnGroup.Click += new System.EventHandler(this.bnGroup_Click);
            // 
            // txtEntergroup
            // 
            this.txtEntergroup.Location = new System.Drawing.Point(735, 272);
            this.txtEntergroup.Name = "txtEntergroup";
            this.txtEntergroup.Size = new System.Drawing.Size(216, 26);
            this.txtEntergroup.TabIndex = 1;
            this.txtEntergroup.Visible = false;
            this.txtEntergroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntergroup_KeyPress);
            // 
            // txtEnterPrivate
            // 
            this.txtEnterPrivate.Location = new System.Drawing.Point(300, 278);
            this.txtEnterPrivate.Name = "txtEnterPrivate";
            this.txtEnterPrivate.Size = new System.Drawing.Size(222, 26);
            this.txtEnterPrivate.TabIndex = 2;
            this.txtEnterPrivate.Visible = false;
            this.txtEnterPrivate.TextChanged += new System.EventHandler(this.txtEnterPrivate_TextChanged);
            this.txtEnterPrivate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterPrivate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(977, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "הכנס מספר טלפון";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "הכנס מספר טלפון";
            this.label2.Visible = false;
            // 
            // btnEnterG
            // 
            this.btnEnterG.BackColor = System.Drawing.Color.Peru;
            this.btnEnterG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnterG.ForeColor = System.Drawing.Color.White;
            this.btnEnterG.Location = new System.Drawing.Point(765, 319);
            this.btnEnterG.Name = "btnEnterG";
            this.btnEnterG.Size = new System.Drawing.Size(160, 50);
            this.btnEnterG.TabIndex = 5;
            this.btnEnterG.Text = "כניסה";
            this.btnEnterG.UseVisualStyleBackColor = false;
            this.btnEnterG.Visible = false;
            this.btnEnterG.Click += new System.EventHandler(this.btnEnterG_Click);
            // 
            // btnEnterP
            // 
            this.btnEnterP.BackColor = System.Drawing.Color.Peru;
            this.btnEnterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnterP.ForeColor = System.Drawing.Color.White;
            this.btnEnterP.Location = new System.Drawing.Point(331, 319);
            this.btnEnterP.Name = "btnEnterP";
            this.btnEnterP.Size = new System.Drawing.Size(160, 50);
            this.btnEnterP.TabIndex = 6;
            this.btnEnterP.Text = "כניסה";
            this.btnEnterP.UseVisualStyleBackColor = false;
            this.btnEnterP.Visible = false;
            this.btnEnterP.Click += new System.EventHandler(this.btnEnterP_Click);
            // 
            // UCTripMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnterP);
            this.Controls.Add(this.btnEnterG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterPrivate);
            this.Controls.Add(this.txtEntergroup);
            this.Controls.Add(this.bnGroup);
            this.Controls.Add(this.bnPrivate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCTripMain";
            this.Size = new System.Drawing.Size(1280, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnPrivate;
        private System.Windows.Forms.Button bnGroup;
        private System.Windows.Forms.TextBox txtEntergroup;
        private System.Windows.Forms.TextBox txtEnterPrivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterG;
        private System.Windows.Forms.Button btnEnterP;
    }
}
