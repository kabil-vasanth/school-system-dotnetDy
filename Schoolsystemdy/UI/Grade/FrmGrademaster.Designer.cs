﻿namespace Schoolsystemdy.UI.Grade
{
    partial class FrmGrademaster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gmorder = new System.Windows.Forms.TextBox();
            this.gmgroup = new System.Windows.Forms.TextBox();
            this.gmname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gmbtnexit = new System.Windows.Forms.Button();
            this.gmbtncancel = new System.Windows.Forms.Button();
            this.gmbtnsave = new System.Windows.Forms.Button();
            this.gmbtnedit = new System.Windows.Forms.Button();
            this.gmbtnadd = new System.Windows.Forms.Button();
            this.gmbtndelete = new System.Windows.Forms.Button();
            this.gmbtnrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gmorder);
            this.groupBox2.Controls.Add(this.gmgroup);
            this.groupBox2.Controls.Add(this.gmname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(488, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gmorder
            // 
            this.gmorder.Location = new System.Drawing.Point(68, 90);
            this.gmorder.Name = "gmorder";
            this.gmorder.Size = new System.Drawing.Size(146, 20);
            this.gmorder.TabIndex = 1;
            // 
            // gmgroup
            // 
            this.gmgroup.Location = new System.Drawing.Point(68, 64);
            this.gmgroup.Name = "gmgroup";
            this.gmgroup.Size = new System.Drawing.Size(146, 20);
            this.gmgroup.TabIndex = 1;
            // 
            // gmname
            // 
            this.gmname.Location = new System.Drawing.Point(68, 38);
            this.gmname.Name = "gmname";
            this.gmname.Size = new System.Drawing.Size(146, 20);
            this.gmname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gmbtnexit);
            this.groupBox3.Controls.Add(this.gmbtncancel);
            this.groupBox3.Controls.Add(this.gmbtnsave);
            this.groupBox3.Controls.Add(this.gmbtnedit);
            this.groupBox3.Controls.Add(this.gmbtnadd);
            this.groupBox3.Controls.Add(this.gmbtndelete);
            this.groupBox3.Controls.Add(this.gmbtnrefresh);
            this.groupBox3.Location = new System.Drawing.Point(5, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // gmbtnexit
            // 
            this.gmbtnexit.Location = new System.Drawing.Point(630, 9);
            this.gmbtnexit.Name = "gmbtnexit";
            this.gmbtnexit.Size = new System.Drawing.Size(65, 43);
            this.gmbtnexit.TabIndex = 0;
            this.gmbtnexit.Text = "Exit";
            this.gmbtnexit.UseVisualStyleBackColor = true;
            // 
            // gmbtncancel
            // 
            this.gmbtncancel.Location = new System.Drawing.Point(563, 9);
            this.gmbtncancel.Name = "gmbtncancel";
            this.gmbtncancel.Size = new System.Drawing.Size(61, 43);
            this.gmbtncancel.TabIndex = 0;
            this.gmbtncancel.Text = "Cancel";
            this.gmbtncancel.UseVisualStyleBackColor = true;
            this.gmbtncancel.Click += new System.EventHandler(this.gmbtncancel_Click);
            // 
            // gmbtnsave
            // 
            this.gmbtnsave.Location = new System.Drawing.Point(493, 9);
            this.gmbtnsave.Name = "gmbtnsave";
            this.gmbtnsave.Size = new System.Drawing.Size(64, 43);
            this.gmbtnsave.TabIndex = 0;
            this.gmbtnsave.Text = "Save";
            this.gmbtnsave.UseVisualStyleBackColor = true;
            // 
            // gmbtnedit
            // 
            this.gmbtnedit.Location = new System.Drawing.Point(424, 9);
            this.gmbtnedit.Name = "gmbtnedit";
            this.gmbtnedit.Size = new System.Drawing.Size(63, 43);
            this.gmbtnedit.TabIndex = 0;
            this.gmbtnedit.Text = "Edit";
            this.gmbtnedit.UseVisualStyleBackColor = true;
            // 
            // gmbtnadd
            // 
            this.gmbtnadd.Location = new System.Drawing.Point(354, 9);
            this.gmbtnadd.Name = "gmbtnadd";
            this.gmbtnadd.Size = new System.Drawing.Size(64, 43);
            this.gmbtnadd.TabIndex = 0;
            this.gmbtnadd.Text = "Add";
            this.gmbtnadd.UseVisualStyleBackColor = true;
            this.gmbtnadd.Click += new System.EventHandler(this.gmbtnadd_Click);
            // 
            // gmbtndelete
            // 
            this.gmbtndelete.Location = new System.Drawing.Point(288, 9);
            this.gmbtndelete.Name = "gmbtndelete";
            this.gmbtndelete.Size = new System.Drawing.Size(60, 43);
            this.gmbtndelete.TabIndex = 0;
            this.gmbtndelete.Text = "Delete";
            this.gmbtndelete.UseVisualStyleBackColor = true;
            // 
            // gmbtnrefresh
            // 
            this.gmbtnrefresh.Location = new System.Drawing.Point(222, 9);
            this.gmbtnrefresh.Name = "gmbtnrefresh";
            this.gmbtnrefresh.Size = new System.Drawing.Size(60, 43);
            this.gmbtnrefresh.TabIndex = 0;
            this.gmbtnrefresh.Text = "Refresh";
            this.gmbtnrefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "GradeMaster";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGrademaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrademaster";
            this.Text = "FrmGrademaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button gmbtnrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gmbtnexit;
        private System.Windows.Forms.Button gmbtncancel;
        private System.Windows.Forms.Button gmbtnsave;
        private System.Windows.Forms.Button gmbtnedit;
        private System.Windows.Forms.Button gmbtnadd;
        private System.Windows.Forms.Button gmbtndelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gmorder;
        private System.Windows.Forms.TextBox gmgroup;
        private System.Windows.Forms.TextBox gmname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}