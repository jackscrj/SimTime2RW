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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.systemtimelabel = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.rwgmt = new System.Windows.Forms.Label();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.label7 = new System.Windows.Forms.Label();
         this.simgmt = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.simlocal = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.ev1_systemtime = new System.Windows.Forms.Label();
         this.ev1_rwgmt = new System.Windows.Forms.Label();
         this.ev1_simgmt = new System.Windows.Forms.Label();
         this.ev1_simlt = new System.Windows.Forms.Label();
         this.ev1_TR = new System.Windows.Forms.Label();
         this.SimTimePicker = new System.Windows.Forms.DateTimePicker();
         this.SimTimeOffset = new System.Windows.Forms.NumericUpDown();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.label3 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.Time1Picker = new System.Windows.Forms.DateTimePicker();
         ((System.ComponentModel.ISupportInitialize)(this.SimTimeOffset)).BeginInit();
         this.tableLayoutPanel1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 17);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(152, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Set Sim Time (GMT)";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 55);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(164, 20);
         this.label2.TabIndex = 4;
         this.label2.Text = "Sim Local Time Offset";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(223, 1);
         this.label4.Name = "label4";
         this.label4.Padding = new System.Windows.Forms.Padding(5);
         this.label4.Size = new System.Drawing.Size(106, 30);
         this.label4.TabIndex = 7;
         this.label4.Text = "SystemTime";
         // 
         // systemtimelabel
         // 
         this.systemtimelabel.AutoSize = true;
         this.systemtimelabel.Location = new System.Drawing.Point(223, 33);
         this.systemtimelabel.Name = "systemtimelabel";
         this.systemtimelabel.Padding = new System.Windows.Forms.Padding(5);
         this.systemtimelabel.Size = new System.Drawing.Size(61, 30);
         this.systemtimelabel.TabIndex = 8;
         this.systemtimelabel.Text = "label5";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(4, 1);
         this.label6.Name = "label6";
         this.label6.Padding = new System.Windows.Forms.Padding(5);
         this.label6.Size = new System.Drawing.Size(136, 30);
         this.label6.TabIndex = 11;
         this.label6.Text = "Real World GMT";
         // 
         // rwgmt
         // 
         this.rwgmt.AutoSize = true;
         this.rwgmt.Location = new System.Drawing.Point(4, 33);
         this.rwgmt.Name = "rwgmt";
         this.rwgmt.Padding = new System.Windows.Forms.Padding(5);
         this.rwgmt.Size = new System.Drawing.Size(95, 30);
         this.rwgmt.TabIndex = 12;
         this.rwgmt.Text = "rwgmtlabel";
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(442, 1);
         this.label7.Name = "label7";
         this.label7.Padding = new System.Windows.Forms.Padding(5);
         this.label7.Size = new System.Drawing.Size(85, 30);
         this.label7.TabIndex = 14;
         this.label7.Text = "Sim GMT";
         // 
         // simgmt
         // 
         this.simgmt.AutoSize = true;
         this.simgmt.Location = new System.Drawing.Point(442, 33);
         this.simgmt.Name = "simgmt";
         this.simgmt.Padding = new System.Windows.Forms.Padding(5);
         this.simgmt.Size = new System.Drawing.Size(61, 30);
         this.simgmt.TabIndex = 15;
         this.simgmt.Text = "label8";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(661, 1);
         this.label8.Name = "label8";
         this.label8.Padding = new System.Windows.Forms.Padding(5);
         this.label8.Size = new System.Drawing.Size(88, 30);
         this.label8.TabIndex = 16;
         this.label8.Text = "Sim Local";
         // 
         // simlocal
         // 
         this.simlocal.AutoSize = true;
         this.simlocal.Location = new System.Drawing.Point(661, 33);
         this.simlocal.Name = "simlocal";
         this.simlocal.Padding = new System.Windows.Forms.Padding(5);
         this.simlocal.Size = new System.Drawing.Size(61, 30);
         this.simlocal.TabIndex = 17;
         this.simlocal.Text = "label9";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(3, 164);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(52, 20);
         this.label5.TabIndex = 18;
         this.label5.Text = "Time1";
         // 
         // ev1_systemtime
         // 
         this.ev1_systemtime.AutoSize = true;
         this.ev1_systemtime.Location = new System.Drawing.Point(124, 50);
         this.ev1_systemtime.Name = "ev1_systemtime";
         this.ev1_systemtime.Padding = new System.Windows.Forms.Padding(5);
         this.ev1_systemtime.Size = new System.Drawing.Size(10, 30);
         this.ev1_systemtime.TabIndex = 21;
         // 
         // ev1_rwgmt
         // 
         this.ev1_rwgmt.AutoSize = true;
         this.ev1_rwgmt.Location = new System.Drawing.Point(343, 50);
         this.ev1_rwgmt.Name = "ev1_rwgmt";
         this.ev1_rwgmt.Padding = new System.Windows.Forms.Padding(5);
         this.ev1_rwgmt.Size = new System.Drawing.Size(10, 30);
         this.ev1_rwgmt.TabIndex = 22;
         // 
         // ev1_simgmt
         // 
         this.ev1_simgmt.AutoSize = true;
         this.ev1_simgmt.Location = new System.Drawing.Point(562, 50);
         this.ev1_simgmt.Name = "ev1_simgmt";
         this.ev1_simgmt.Padding = new System.Windows.Forms.Padding(5);
         this.ev1_simgmt.Size = new System.Drawing.Size(10, 30);
         this.ev1_simgmt.TabIndex = 23;
         // 
         // ev1_simlt
         // 
         this.ev1_simlt.AutoSize = true;
         this.ev1_simlt.Location = new System.Drawing.Point(781, 50);
         this.ev1_simlt.Name = "ev1_simlt";
         this.ev1_simlt.Padding = new System.Windows.Forms.Padding(5);
         this.ev1_simlt.Size = new System.Drawing.Size(10, 30);
         this.ev1_simlt.TabIndex = 24;
         // 
         // ev1_TR
         // 
         this.ev1_TR.AutoSize = true;
         this.ev1_TR.Location = new System.Drawing.Point(4, 50);
         this.ev1_TR.Name = "ev1_TR";
         this.ev1_TR.Padding = new System.Windows.Forms.Padding(5);
         this.ev1_TR.Size = new System.Drawing.Size(10, 30);
         this.ev1_TR.TabIndex = 25;
         // 
         // SimTimePicker
         // 
         this.SimTimePicker.CustomFormat = "M/d/yy H:mm";
         this.SimTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.SimTimePicker.Location = new System.Drawing.Point(176, 14);
         this.SimTimePicker.Name = "SimTimePicker";
         this.SimTimePicker.ShowUpDown = true;
         this.SimTimePicker.Size = new System.Drawing.Size(168, 26);
         this.SimTimePicker.TabIndex = 26;
         this.SimTimePicker.ValueChanged += new System.EventHandler(this.SimTimePicker_ValueChanged);
         // 
         // SimTimeOffset
         // 
         this.SimTimeOffset.Location = new System.Drawing.Point(260, 52);
         this.SimTimeOffset.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
         this.SimTimeOffset.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
         this.SimTimeOffset.Name = "SimTimeOffset";
         this.SimTimeOffset.Size = new System.Drawing.Size(84, 26);
         this.SimTimeOffset.TabIndex = 27;
         this.SimTimeOffset.ValueChanged += new System.EventHandler(this.SimTimeOffset_ValueChanged);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
         this.tableLayoutPanel1.Controls.Add(this.rwgmt, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.systemtimelabel, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.simgmt, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.simlocal, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(371, 9);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 66);
         this.tableLayoutPanel1.TabIndex = 28;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         this.tableLayoutPanel2.ColumnCount = 5;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
         this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
         this.tableLayoutPanel2.Controls.Add(this.label11, 3, 0);
         this.tableLayoutPanel2.Controls.Add(this.ev1_simlt, 4, 1);
         this.tableLayoutPanel2.Controls.Add(this.ev1_TR, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.ev1_simgmt, 3, 1);
         this.tableLayoutPanel2.Controls.Add(this.label12, 4, 0);
         this.tableLayoutPanel2.Controls.Add(this.ev1_rwgmt, 2, 1);
         this.tableLayoutPanel2.Controls.Add(this.ev1_systemtime, 1, 1);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(252, 106);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 2;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(999, 100);
         this.tableLayoutPanel2.TabIndex = 29;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(4, 1);
         this.label3.Name = "label3";
         this.label3.Padding = new System.Windows.Forms.Padding(5);
         this.label3.Size = new System.Drawing.Size(91, 30);
         this.label3.TabIndex = 0;
         this.label3.Text = "Time Rem";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(124, 1);
         this.label9.Name = "label9";
         this.label9.Padding = new System.Windows.Forms.Padding(5);
         this.label9.Size = new System.Drawing.Size(85, 30);
         this.label9.TabIndex = 1;
         this.label9.Text = "RW GMT";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(343, 1);
         this.label10.Name = "label10";
         this.label10.Padding = new System.Windows.Forms.Padding(5);
         this.label10.Size = new System.Drawing.Size(110, 30);
         this.label10.TabIndex = 2;
         this.label10.Text = "System Time";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(562, 1);
         this.label11.Name = "label11";
         this.label11.Padding = new System.Windows.Forms.Padding(5);
         this.label11.Size = new System.Drawing.Size(85, 30);
         this.label11.TabIndex = 3;
         this.label11.Text = "Sim GMT";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(781, 1);
         this.label12.Name = "label12";
         this.label12.Padding = new System.Windows.Forms.Padding(5);
         this.label12.Size = new System.Drawing.Size(88, 30);
         this.label12.TabIndex = 4;
         this.label12.Text = "Sim Local";
         // 
         // Time1Picker
         // 
         this.Time1Picker.CustomFormat = "M/d/yy H:mm";
         this.Time1Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.Time1Picker.Location = new System.Drawing.Point(61, 161);
         this.Time1Picker.Name = "Time1Picker";
         this.Time1Picker.ShowUpDown = true;
         this.Time1Picker.Size = new System.Drawing.Size(184, 26);
         this.Time1Picker.TabIndex = 30;
         this.Time1Picker.ValueChanged += new System.EventHandler(this.Time1Picker_ValueChanged);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1258, 787);
         this.Controls.Add(this.Time1Picker);
         this.Controls.Add(this.tableLayoutPanel2);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Controls.Add(this.SimTimeOffset);
         this.Controls.Add(this.SimTimePicker);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.SimTimeOffset)).EndInit();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label systemtimelabel;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label rwgmt;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label simgmt;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label simlocal;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label ev1_systemtime;
      private System.Windows.Forms.Label ev1_rwgmt;
      private System.Windows.Forms.Label ev1_simgmt;
      private System.Windows.Forms.Label ev1_simlt;
      private System.Windows.Forms.Label ev1_TR;
      private System.Windows.Forms.DateTimePicker SimTimePicker;
      
      private System.Windows.Forms.NumericUpDown SimTimeOffset;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.DateTimePicker Time1Picker;
   }
}

