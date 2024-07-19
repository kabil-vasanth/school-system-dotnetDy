namespace Schoolsystemdy.UI.Student
{
    partial class FrmStudentMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.smbtnexit = new System.Windows.Forms.Button();
            this.smbtnedit = new System.Windows.Forms.Button();
            this.smbtnadd = new System.Windows.Forms.Button();
            this.smbtndelete = new System.Windows.Forms.Button();
            this.smbtnrefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "StudentMaster";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.smbtnexit);
            this.groupBox3.Controls.Add(this.smbtnedit);
            this.groupBox3.Controls.Add(this.smbtnadd);
            this.groupBox3.Controls.Add(this.smbtndelete);
            this.groupBox3.Controls.Add(this.smbtnrefresh);
            this.groupBox3.Location = new System.Drawing.Point(4, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 57);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // smbtnexit
            // 
            this.smbtnexit.Location = new System.Drawing.Point(630, 9);
            this.smbtnexit.Name = "smbtnexit";
            this.smbtnexit.Size = new System.Drawing.Size(65, 43);
            this.smbtnexit.TabIndex = 0;
            this.smbtnexit.Text = "Exit";
            this.smbtnexit.UseVisualStyleBackColor = true;
            // 
            // smbtnedit
            // 
            this.smbtnedit.Location = new System.Drawing.Point(561, 9);
            this.smbtnedit.Name = "smbtnedit";
            this.smbtnedit.Size = new System.Drawing.Size(63, 43);
            this.smbtnedit.TabIndex = 0;
            this.smbtnedit.Text = "Edit";
            this.smbtnedit.UseVisualStyleBackColor = true;
            // 
            // smbtnadd
            // 
            this.smbtnadd.Location = new System.Drawing.Point(491, 9);
            this.smbtnadd.Name = "smbtnadd";
            this.smbtnadd.Size = new System.Drawing.Size(64, 43);
            this.smbtnadd.TabIndex = 0;
            this.smbtnadd.Text = "Add";
            this.smbtnadd.UseVisualStyleBackColor = true;
            // 
            // smbtndelete
            // 
            this.smbtndelete.Location = new System.Drawing.Point(425, 9);
            this.smbtndelete.Name = "smbtndelete";
            this.smbtndelete.Size = new System.Drawing.Size(60, 43);
            this.smbtndelete.TabIndex = 0;
            this.smbtndelete.Text = "Delete";
            this.smbtndelete.UseVisualStyleBackColor = true;
            // 
            // smbtnrefresh
            // 
            this.smbtnrefresh.Location = new System.Drawing.Point(359, 9);
            this.smbtnrefresh.Name = "smbtnrefresh";
            this.smbtnrefresh.Size = new System.Drawing.Size(60, 43);
            this.smbtnrefresh.TabIndex = 0;
            this.smbtnrefresh.Text = "Refresh";
            this.smbtnrefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 280);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmStudentMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudentMaster";
            this.Text = "FrmStudentMaster";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button smbtnexit;
        private System.Windows.Forms.Button smbtnedit;
        private System.Windows.Forms.Button smbtnadd;
        private System.Windows.Forms.Button smbtndelete;
        private System.Windows.Forms.Button smbtnrefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}