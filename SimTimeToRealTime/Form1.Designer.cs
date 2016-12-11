namespace SimTimeToRealTime
{
   partial class Form1
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
         this.components = new System.ComponentModel.Container();
         this.Simtimebox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.ltobox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.systemtimelabel = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.rwgmt = new System.Windows.Forms.Label();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.setall = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.simgmt = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.simlocal = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.ev1_timebox = new System.Windows.Forms.TextBox();
         this.calc_Event1 = new System.Windows.Forms.Button();
         this.ev1systemtime = new System.Windows.Forms.Label();
         this.ev1_rwgmt = new System.Windows.Forms.Label();
         this.ev1_simgmt = new System.Windows.Forms.Label();
         this.ev1_simlt = new System.Windows.Forms.Label();
         this.ev1_TR = new System.Windows.Forms.Label();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.SuspendLayout();
         // 
         // Simtimebox
         // 
         this.Simtimebox.Location = new System.Drawing.Point(16, 35);
         this.Simtimebox.Name = "Simtimebox";
         this.Simtimebox.Size = new System.Drawing.Size(148, 26);
         this.Simtimebox.TabIndex = 1;
         this.Simtimebox.TextChanged += new System.EventHandler(this.Simtimebox_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(152, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Set Sim Time (GMT)";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 94);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(164, 20);
         this.label2.TabIndex = 4;
         this.label2.Text = "Local Time Offset Sim";
         // 
         // ltobox
         // 
         this.ltobox.Location = new System.Drawing.Point(16, 67);
         this.ltobox.Name = "ltobox";
         this.ltobox.Size = new System.Drawing.Size(100, 26);
         this.ltobox.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(122, 73);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(31, 20);
         this.label3.TabIndex = 6;
         this.label3.Text = "hrs";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(922, 38);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(96, 20);
         this.label4.TabIndex = 7;
         this.label4.Text = "SystemTime";
         // 
         // systemtimelabel
         // 
         this.systemtimelabel.AutoSize = true;
         this.systemtimelabel.Location = new System.Drawing.Point(1058, 38);
         this.systemtimelabel.Name = "systemtimelabel";
         this.systemtimelabel.Size = new System.Drawing.Size(51, 20);
         this.systemtimelabel.TabIndex = 8;
         this.systemtimelabel.Text = "label5";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(922, 9);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(126, 20);
         this.label6.TabIndex = 11;
         this.label6.Text = "Real World GMT";
         // 
         // rwgmt
         // 
         this.rwgmt.AutoSize = true;
         this.rwgmt.Location = new System.Drawing.Point(1058, 9);
         this.rwgmt.Name = "rwgmt";
         this.rwgmt.Size = new System.Drawing.Size(85, 20);
         this.rwgmt.TabIndex = 12;
         this.rwgmt.Text = "rwgmtlabel";
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // setall
         // 
         this.setall.Location = new System.Drawing.Point(159, 70);
         this.setall.Name = "setall";
         this.setall.Size = new System.Drawing.Size(58, 27);
         this.setall.TabIndex = 13;
         this.setall.Text = "Set";
         this.setall.UseVisualStyleBackColor = true;
         this.setall.Click += new System.EventHandler(this.setrwoffset_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(922, 67);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(75, 20);
         this.label7.TabIndex = 14;
         this.label7.Text = "Sim GMT";
         // 
         // simgmt
         // 
         this.simgmt.AutoSize = true;
         this.simgmt.Location = new System.Drawing.Point(1058, 67);
         this.simgmt.Name = "simgmt";
         this.simgmt.Size = new System.Drawing.Size(51, 20);
         this.simgmt.TabIndex = 15;
         this.simgmt.Text = "label8";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(922, 94);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(78, 20);
         this.label8.TabIndex = 16;
         this.label8.Text = "Sim Local";
         // 
         // simlocal
         // 
         this.simlocal.AutoSize = true;
         this.simlocal.Location = new System.Drawing.Point(1058, 94);
         this.simlocal.Name = "simlocal";
         this.simlocal.Size = new System.Drawing.Size(51, 20);
         this.simlocal.TabIndex = 17;
         this.simlocal.Text = "label9";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(94, 195);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(59, 20);
         this.label5.TabIndex = 18;
         this.label5.Text = "Event1";
         // 
         // ev1_timebox
         // 
         this.ev1_timebox.Location = new System.Drawing.Point(159, 189);
         this.ev1_timebox.Name = "ev1_timebox";
         this.ev1_timebox.Size = new System.Drawing.Size(100, 26);
         this.ev1_timebox.TabIndex = 19;
         // 
         // calc_Event1
         // 
         this.calc_Event1.Location = new System.Drawing.Point(279, 186);
         this.calc_Event1.Name = "calc_Event1";
         this.calc_Event1.Size = new System.Drawing.Size(75, 33);
         this.calc_Event1.TabIndex = 20;
         this.calc_Event1.Text = "calc";
         this.calc_Event1.UseVisualStyleBackColor = true;
         this.calc_Event1.Click += new System.EventHandler(this.calc_Event1_Click);
         // 
         // ev1systemtime
         // 
         this.ev1systemtime.AutoSize = true;
         this.ev1systemtime.Location = new System.Drawing.Point(435, 95);
         this.ev1systemtime.Name = "ev1systemtime";
         this.ev1systemtime.Size = new System.Drawing.Size(51, 20);
         this.ev1systemtime.TabIndex = 21;
         this.ev1systemtime.Text = "label9";
         // 
         // ev1_rwgmt
         // 
         this.ev1_rwgmt.AutoSize = true;
         this.ev1_rwgmt.Location = new System.Drawing.Point(545, 95);
         this.ev1_rwgmt.Name = "ev1_rwgmt";
         this.ev1_rwgmt.Size = new System.Drawing.Size(51, 20);
         this.ev1_rwgmt.TabIndex = 22;
         this.ev1_rwgmt.Text = "label9";
         // 
         // ev1_simgmt
         // 
         this.ev1_simgmt.AutoSize = true;
         this.ev1_simgmt.Location = new System.Drawing.Point(689, 95);
         this.ev1_simgmt.Name = "ev1_simgmt";
         this.ev1_simgmt.Size = new System.Drawing.Size(51, 20);
         this.ev1_simgmt.TabIndex = 23;
         this.ev1_simgmt.Text = "label9";
         // 
         // ev1_simlt
         // 
         this.ev1_simlt.AutoSize = true;
         this.ev1_simlt.Location = new System.Drawing.Point(797, 95);
         this.ev1_simlt.Name = "ev1_simlt";
         this.ev1_simlt.Size = new System.Drawing.Size(51, 20);
         this.ev1_simlt.TabIndex = 24;
         this.ev1_simlt.Text = "label9";
         // 
         // ev1_TR
         // 
         this.ev1_TR.AutoSize = true;
         this.ev1_TR.Location = new System.Drawing.Point(324, 95);
         this.ev1_TR.Name = "ev1_TR";
         this.ev1_TR.Size = new System.Drawing.Size(51, 20);
         this.ev1_TR.TabIndex = 25;
         this.ev1_TR.Text = "label9";
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.CustomFormat = "M/d/yy H:mm";
         this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dateTimePicker1.Location = new System.Drawing.Point(109, 430);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.ShowUpDown = true;
         this.dateTimePicker1.Size = new System.Drawing.Size(168, 26);
         this.dateTimePicker1.TabIndex = 26;
         this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1587, 787);
         this.Controls.Add(this.dateTimePicker1);
         this.Controls.Add(this.ev1_TR);
         this.Controls.Add(this.ev1_simlt);
         this.Controls.Add(this.ev1_simgmt);
         this.Controls.Add(this.ev1_rwgmt);
         this.Controls.Add(this.ev1systemtime);
         this.Controls.Add(this.calc_Event1);
         this.Controls.Add(this.ev1_timebox);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.simlocal);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.simgmt);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.setall);
         this.Controls.Add(this.rwgmt);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.systemtimelabel);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.ltobox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.Simtimebox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox Simtimebox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox ltobox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label systemtimelabel;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label rwgmt;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Button setall;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label simgmt;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label simlocal;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox ev1_timebox;
      private System.Windows.Forms.Button calc_Event1;
      private System.Windows.Forms.Label ev1systemtime;
      private System.Windows.Forms.Label ev1_rwgmt;
      private System.Windows.Forms.Label ev1_simgmt;
      private System.Windows.Forms.Label ev1_simlt;
      private System.Windows.Forms.Label ev1_TR;
      private System.Windows.Forms.DateTimePicker dateTimePicker1;
   }
}

