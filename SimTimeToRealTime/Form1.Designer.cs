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
         this.ux_label0 = new System.Windows.Forms.Label();
         this.ux_label1 = new System.Windows.Forms.Label();
         this.ux_label6 = new System.Windows.Forms.Label();
         this.ux_systemTime = new System.Windows.Forms.Label();
         this.ux_label5 = new System.Windows.Forms.Label();
         this.ux_UTC = new System.Windows.Forms.Label();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.ux_label7 = new System.Windows.Forms.Label();
         this.ux_simUTC = new System.Windows.Forms.Label();
         this.ux_label8 = new System.Windows.Forms.Label();
         this.ux_simLocal = new System.Windows.Forms.Label();
         this.ux_ev1RWUTC = new System.Windows.Forms.Label();
         this.ux_ev1SystemTime = new System.Windows.Forms.Label();
         this.ux_ev1SimUTC = new System.Windows.Forms.Label();
         this.ux_ev1SimLocalTime = new System.Windows.Forms.Label();
         this.ux_ev1TR = new System.Windows.Forms.Label();
         this.ux_simTimePicker = new System.Windows.Forms.DateTimePicker();
         this.ux_simTimeOffset = new System.Windows.Forms.NumericUpDown();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.ux_label10 = new System.Windows.Forms.Label();
         this.ux_label11 = new System.Windows.Forms.Label();
         this.ux_label12 = new System.Windows.Forms.Label();
         this.ux_label13 = new System.Windows.Forms.Label();
         this.ux_ev2TR = new System.Windows.Forms.Label();
         this.ux_ev4TR = new System.Windows.Forms.Label();
         this.ux_ev3TR = new System.Windows.Forms.Label();
         this.ux_ev2RWUTC = new System.Windows.Forms.Label();
         this.ux_ev4RWUTC = new System.Windows.Forms.Label();
         this.ux_ev3RWUTC = new System.Windows.Forms.Label();
         this.ux_ev5SimLocalTime = new System.Windows.Forms.Label();
         this.ux_ev2SystemTime = new System.Windows.Forms.Label();
         this.ux_ev4SystemTime = new System.Windows.Forms.Label();
         this.ux_ev3SystemTime = new System.Windows.Forms.Label();
         this.ux_ev2SimLocalTime = new System.Windows.Forms.Label();
         this.ux_ev3SimUTC = new System.Windows.Forms.Label();
         this.ux_ev5SystemTime = new System.Windows.Forms.Label();
         this.ux_ev2SimUTC = new System.Windows.Forms.Label();
         this.ux_ev5SimUTC = new System.Windows.Forms.Label();
         this.ux_ev4SimUTC = new System.Windows.Forms.Label();
         this.ux_ev4SimLocalTime = new System.Windows.Forms.Label();
         this.ux_ev3SimLocalTime = new System.Windows.Forms.Label();
         this.ux_ev5RWUTC = new System.Windows.Forms.Label();
         this.ux_ev5TR = new System.Windows.Forms.Label();
         this.ux_label9 = new System.Windows.Forms.Label();
         this.ux_ev1TimePicker = new System.Windows.Forms.DateTimePicker();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.ux_label3 = new System.Windows.Forms.Label();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.textBox5 = new System.Windows.Forms.TextBox();
         this.ux_ev2TimePicker = new System.Windows.Forms.DateTimePicker();
         this.ux_ev3TimePicker = new System.Windows.Forms.DateTimePicker();
         this.ux_ev4TimePicker = new System.Windows.Forms.DateTimePicker();
         this.ux_ev5TimePicker = new System.Windows.Forms.DateTimePicker();
         this.ux_label4 = new System.Windows.Forms.Label();
         this.ux_dateFormat = new System.Windows.Forms.ComboBox();
         this.ux_label2 = new System.Windows.Forms.Label();
         this.ux_language = new System.Windows.Forms.ComboBox();
         this.button2 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.ux_simTimeOffset)).BeginInit();
         this.tableLayoutPanel1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // ux_label0
         // 
         this.ux_label0.AutoSize = true;
         this.ux_label0.Location = new System.Drawing.Point(16, 17);
         this.ux_label0.Name = "ux_label0";
         this.ux_label0.Size = new System.Drawing.Size(149, 20);
         this.ux_label0.TabIndex = 2;
         this.ux_label0.Text = "Set Sim Time (UTC)";
         // 
         // ux_label1
         // 
         this.ux_label1.AutoSize = true;
         this.ux_label1.Location = new System.Drawing.Point(16, 52);
         this.ux_label1.Name = "ux_label1";
         this.ux_label1.Size = new System.Drawing.Size(164, 20);
         this.ux_label1.TabIndex = 4;
         this.ux_label1.Text = "Sim Local Time Offset";
         // 
         // ux_label6
         // 
         this.ux_label6.AutoSize = true;
         this.ux_label6.Location = new System.Drawing.Point(217, 1);
         this.ux_label6.Name = "ux_label6";
         this.ux_label6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label6.Size = new System.Drawing.Size(108, 30);
         this.ux_label6.TabIndex = 7;
         this.ux_label6.Text = "System Time";
         // 
         // ux_systemTime
         // 
         this.ux_systemTime.AutoSize = true;
         this.ux_systemTime.Location = new System.Drawing.Point(217, 33);
         this.ux_systemTime.Name = "ux_systemTime";
         this.ux_systemTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_systemTime.Size = new System.Drawing.Size(59, 30);
         this.ux_systemTime.TabIndex = 8;
         this.ux_systemTime.Text = "label5";
         // 
         // ux_label5
         // 
         this.ux_label5.AutoSize = true;
         this.ux_label5.Location = new System.Drawing.Point(4, 1);
         this.ux_label5.Name = "ux_label5";
         this.ux_label5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label5.Size = new System.Drawing.Size(131, 30);
         this.ux_label5.TabIndex = 11;
         this.ux_label5.Text = "Real World UTC";
         // 
         // ux_UTC
         // 
         this.ux_UTC.AutoSize = true;
         this.ux_UTC.Location = new System.Drawing.Point(4, 33);
         this.ux_UTC.Name = "ux_UTC";
         this.ux_UTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_UTC.Size = new System.Drawing.Size(55, 30);
         this.ux_UTC.TabIndex = 12;
         this.ux_UTC.Text = "rwutc";
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // ux_label7
         // 
         this.ux_label7.AutoSize = true;
         this.ux_label7.Location = new System.Drawing.Point(430, 1);
         this.ux_label7.Name = "ux_label7";
         this.ux_label7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label7.Size = new System.Drawing.Size(80, 30);
         this.ux_label7.TabIndex = 14;
         this.ux_label7.Text = "Sim UTC";
         // 
         // ux_simUTC
         // 
         this.ux_simUTC.AutoSize = true;
         this.ux_simUTC.Location = new System.Drawing.Point(430, 33);
         this.ux_simUTC.Name = "ux_simUTC";
         this.ux_simUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_simUTC.Size = new System.Drawing.Size(59, 30);
         this.ux_simUTC.TabIndex = 15;
         this.ux_simUTC.Text = "label8";
         // 
         // ux_label8
         // 
         this.ux_label8.AutoSize = true;
         this.ux_label8.Location = new System.Drawing.Point(643, 1);
         this.ux_label8.Name = "ux_label8";
         this.ux_label8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label8.Size = new System.Drawing.Size(86, 30);
         this.ux_label8.TabIndex = 16;
         this.ux_label8.Text = "Sim Local";
         // 
         // ux_simLocal
         // 
         this.ux_simLocal.AutoSize = true;
         this.ux_simLocal.Location = new System.Drawing.Point(643, 33);
         this.ux_simLocal.Name = "ux_simLocal";
         this.ux_simLocal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_simLocal.Size = new System.Drawing.Size(59, 30);
         this.ux_simLocal.TabIndex = 17;
         this.ux_simLocal.Text = "label9";
         // 
         // ux_ev1RWUTC
         // 
         this.ux_ev1RWUTC.AutoSize = true;
         this.ux_ev1RWUTC.Location = new System.Drawing.Point(149, 45);
         this.ux_ev1RWUTC.Name = "ux_ev1RWUTC";
         this.ux_ev1RWUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev1RWUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev1RWUTC.TabIndex = 21;
         // 
         // ux_ev1SystemTime
         // 
         this.ux_ev1SystemTime.AutoSize = true;
         this.ux_ev1SystemTime.Location = new System.Drawing.Point(362, 45);
         this.ux_ev1SystemTime.Name = "ux_ev1SystemTime";
         this.ux_ev1SystemTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev1SystemTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev1SystemTime.TabIndex = 22;
         // 
         // ux_ev1SimUTC
         // 
         this.ux_ev1SimUTC.AutoSize = true;
         this.ux_ev1SimUTC.Location = new System.Drawing.Point(575, 45);
         this.ux_ev1SimUTC.Name = "ux_ev1SimUTC";
         this.ux_ev1SimUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev1SimUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev1SimUTC.TabIndex = 23;
         // 
         // ux_ev1SimLocalTime
         // 
         this.ux_ev1SimLocalTime.AutoSize = true;
         this.ux_ev1SimLocalTime.Location = new System.Drawing.Point(788, 45);
         this.ux_ev1SimLocalTime.Name = "ux_ev1SimLocalTime";
         this.ux_ev1SimLocalTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev1SimLocalTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev1SimLocalTime.TabIndex = 24;
         // 
         // ux_ev1TR
         // 
         this.ux_ev1TR.AutoSize = true;
         this.ux_ev1TR.Location = new System.Drawing.Point(4, 45);
         this.ux_ev1TR.Name = "ux_ev1TR";
         this.ux_ev1TR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev1TR.Size = new System.Drawing.Size(8, 30);
         this.ux_ev1TR.TabIndex = 25;
         // 
         // ux_simTimePicker
         // 
         this.ux_simTimePicker.CustomFormat = "M/dd/yy HH:mm";
         this.ux_simTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.ux_simTimePicker.Location = new System.Drawing.Point(237, 9);
         this.ux_simTimePicker.Name = "ux_simTimePicker";
         this.ux_simTimePicker.ShowUpDown = true;
         this.ux_simTimePicker.Size = new System.Drawing.Size(164, 26);
         this.ux_simTimePicker.TabIndex = 26;
         this.ux_simTimePicker.ValueChanged += new System.EventHandler(this.ux_simTimePicker_ValueChanged);
         // 
         // ux_simTimeOffset
         // 
         this.ux_simTimeOffset.Location = new System.Drawing.Point(317, 48);
         this.ux_simTimeOffset.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
         this.ux_simTimeOffset.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
         this.ux_simTimeOffset.Name = "ux_simTimeOffset";
         this.ux_simTimeOffset.Size = new System.Drawing.Size(84, 26);
         this.ux_simTimeOffset.TabIndex = 27;
         this.ux_simTimeOffset.ValueChanged += new System.EventHandler(this.ux_simTimeOffset_ValueChanged);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel1.Controls.Add(this.ux_label6, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.ux_label7, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.ux_label8, 3, 0);
         this.tableLayoutPanel1.Controls.Add(this.ux_UTC, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.ux_systemTime, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.ux_simUTC, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.ux_simLocal, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.ux_label5, 0, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(574, 17);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 66);
         this.tableLayoutPanel1.TabIndex = 28;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         this.tableLayoutPanel2.ColumnCount = 5;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.56311F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.35922F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.35922F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.35922F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.35922F));
         this.tableLayoutPanel2.Controls.Add(this.ux_label10, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.ux_label11, 2, 0);
         this.tableLayoutPanel2.Controls.Add(this.ux_label12, 3, 0);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev1TR, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.ux_label13, 4, 0);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev1RWUTC, 1, 1);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev2TR, 0, 2);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev4TR, 0, 4);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev3TR, 0, 3);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev2RWUTC, 1, 2);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev4RWUTC, 1, 4);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev3RWUTC, 1, 3);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev5SimLocalTime, 4, 5);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev2SystemTime, 2, 2);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev4SystemTime, 2, 4);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev3SystemTime, 2, 3);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev1SimUTC, 3, 1);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev2SimLocalTime, 4, 2);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev3SimUTC, 3, 3);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev5SystemTime, 2, 5);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev2SimUTC, 3, 2);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev5SimUTC, 3, 5);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev1SimLocalTime, 4, 1);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev4SimUTC, 3, 4);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev4SimLocalTime, 4, 4);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev3SimLocalTime, 4, 3);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev5RWUTC, 1, 5);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev1SystemTime, 2, 1);
         this.tableLayoutPanel2.Controls.Add(this.ux_ev5TR, 0, 5);
         this.tableLayoutPanel2.Controls.Add(this.ux_label9, 0, 0);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(430, 118);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 6;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(999, 269);
         this.tableLayoutPanel2.TabIndex = 29;
         // 
         // ux_label10
         // 
         this.ux_label10.AutoSize = true;
         this.ux_label10.Location = new System.Drawing.Point(149, 1);
         this.ux_label10.Name = "ux_label10";
         this.ux_label10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label10.Size = new System.Drawing.Size(80, 30);
         this.ux_label10.TabIndex = 1;
         this.ux_label10.Text = "RW UTC";
         // 
         // ux_label11
         // 
         this.ux_label11.AutoSize = true;
         this.ux_label11.Location = new System.Drawing.Point(362, 1);
         this.ux_label11.Name = "ux_label11";
         this.ux_label11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label11.Size = new System.Drawing.Size(108, 30);
         this.ux_label11.TabIndex = 2;
         this.ux_label11.Text = "System Time";
         // 
         // ux_label12
         // 
         this.ux_label12.AutoSize = true;
         this.ux_label12.Location = new System.Drawing.Point(575, 1);
         this.ux_label12.Name = "ux_label12";
         this.ux_label12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label12.Size = new System.Drawing.Size(80, 30);
         this.ux_label12.TabIndex = 3;
         this.ux_label12.Text = "Sim UTC";
         // 
         // ux_label13
         // 
         this.ux_label13.AutoSize = true;
         this.ux_label13.Location = new System.Drawing.Point(788, 1);
         this.ux_label13.Name = "ux_label13";
         this.ux_label13.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label13.Size = new System.Drawing.Size(86, 30);
         this.ux_label13.TabIndex = 4;
         this.ux_label13.Text = "Sim Local";
         // 
         // ux_ev2TR
         // 
         this.ux_ev2TR.AutoSize = true;
         this.ux_ev2TR.Location = new System.Drawing.Point(4, 89);
         this.ux_ev2TR.Name = "ux_ev2TR";
         this.ux_ev2TR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev2TR.Size = new System.Drawing.Size(8, 30);
         this.ux_ev2TR.TabIndex = 26;
         // 
         // ux_ev4TR
         // 
         this.ux_ev4TR.AutoSize = true;
         this.ux_ev4TR.Location = new System.Drawing.Point(4, 177);
         this.ux_ev4TR.Name = "ux_ev4TR";
         this.ux_ev4TR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev4TR.Size = new System.Drawing.Size(8, 30);
         this.ux_ev4TR.TabIndex = 28;
         // 
         // ux_ev3TR
         // 
         this.ux_ev3TR.AutoSize = true;
         this.ux_ev3TR.Location = new System.Drawing.Point(4, 133);
         this.ux_ev3TR.Name = "ux_ev3TR";
         this.ux_ev3TR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev3TR.Size = new System.Drawing.Size(8, 30);
         this.ux_ev3TR.TabIndex = 29;
         // 
         // ux_ev2RWUTC
         // 
         this.ux_ev2RWUTC.AutoSize = true;
         this.ux_ev2RWUTC.Location = new System.Drawing.Point(149, 89);
         this.ux_ev2RWUTC.Name = "ux_ev2RWUTC";
         this.ux_ev2RWUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev2RWUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev2RWUTC.TabIndex = 30;
         // 
         // ux_ev4RWUTC
         // 
         this.ux_ev4RWUTC.AutoSize = true;
         this.ux_ev4RWUTC.Location = new System.Drawing.Point(149, 177);
         this.ux_ev4RWUTC.Name = "ux_ev4RWUTC";
         this.ux_ev4RWUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev4RWUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev4RWUTC.TabIndex = 31;
         // 
         // ux_ev3RWUTC
         // 
         this.ux_ev3RWUTC.AutoSize = true;
         this.ux_ev3RWUTC.Location = new System.Drawing.Point(149, 133);
         this.ux_ev3RWUTC.Name = "ux_ev3RWUTC";
         this.ux_ev3RWUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev3RWUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev3RWUTC.TabIndex = 32;
         // 
         // ux_ev5SimLocalTime
         // 
         this.ux_ev5SimLocalTime.AutoSize = true;
         this.ux_ev5SimLocalTime.Location = new System.Drawing.Point(788, 221);
         this.ux_ev5SimLocalTime.Name = "ux_ev5SimLocalTime";
         this.ux_ev5SimLocalTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev5SimLocalTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev5SimLocalTime.TabIndex = 34;
         // 
         // ux_ev2SystemTime
         // 
         this.ux_ev2SystemTime.AutoSize = true;
         this.ux_ev2SystemTime.Location = new System.Drawing.Point(362, 89);
         this.ux_ev2SystemTime.Name = "ux_ev2SystemTime";
         this.ux_ev2SystemTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev2SystemTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev2SystemTime.TabIndex = 33;
         // 
         // ux_ev4SystemTime
         // 
         this.ux_ev4SystemTime.AutoSize = true;
         this.ux_ev4SystemTime.Location = new System.Drawing.Point(362, 177);
         this.ux_ev4SystemTime.Name = "ux_ev4SystemTime";
         this.ux_ev4SystemTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev4SystemTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev4SystemTime.TabIndex = 36;
         // 
         // ux_ev3SystemTime
         // 
         this.ux_ev3SystemTime.AutoSize = true;
         this.ux_ev3SystemTime.Location = new System.Drawing.Point(362, 133);
         this.ux_ev3SystemTime.Name = "ux_ev3SystemTime";
         this.ux_ev3SystemTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev3SystemTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev3SystemTime.TabIndex = 37;
         // 
         // ux_ev2SimLocalTime
         // 
         this.ux_ev2SimLocalTime.AutoSize = true;
         this.ux_ev2SimLocalTime.Location = new System.Drawing.Point(788, 89);
         this.ux_ev2SimLocalTime.Name = "ux_ev2SimLocalTime";
         this.ux_ev2SimLocalTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev2SimLocalTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev2SimLocalTime.TabIndex = 39;
         // 
         // ux_ev3SimUTC
         // 
         this.ux_ev3SimUTC.AutoSize = true;
         this.ux_ev3SimUTC.Location = new System.Drawing.Point(575, 133);
         this.ux_ev3SimUTC.Name = "ux_ev3SimUTC";
         this.ux_ev3SimUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev3SimUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev3SimUTC.TabIndex = 38;
         // 
         // ux_ev5SystemTime
         // 
         this.ux_ev5SystemTime.AutoSize = true;
         this.ux_ev5SystemTime.Location = new System.Drawing.Point(362, 221);
         this.ux_ev5SystemTime.Name = "ux_ev5SystemTime";
         this.ux_ev5SystemTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev5SystemTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev5SystemTime.TabIndex = 40;
         // 
         // ux_ev2SimUTC
         // 
         this.ux_ev2SimUTC.AutoSize = true;
         this.ux_ev2SimUTC.Location = new System.Drawing.Point(575, 89);
         this.ux_ev2SimUTC.Name = "ux_ev2SimUTC";
         this.ux_ev2SimUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev2SimUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev2SimUTC.TabIndex = 35;
         // 
         // ux_ev5SimUTC
         // 
         this.ux_ev5SimUTC.AutoSize = true;
         this.ux_ev5SimUTC.Location = new System.Drawing.Point(575, 221);
         this.ux_ev5SimUTC.Name = "ux_ev5SimUTC";
         this.ux_ev5SimUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev5SimUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev5SimUTC.TabIndex = 41;
         // 
         // ux_ev4SimUTC
         // 
         this.ux_ev4SimUTC.AutoSize = true;
         this.ux_ev4SimUTC.Location = new System.Drawing.Point(575, 177);
         this.ux_ev4SimUTC.Name = "ux_ev4SimUTC";
         this.ux_ev4SimUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev4SimUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev4SimUTC.TabIndex = 42;
         // 
         // ux_ev4SimLocalTime
         // 
         this.ux_ev4SimLocalTime.AutoSize = true;
         this.ux_ev4SimLocalTime.Location = new System.Drawing.Point(788, 177);
         this.ux_ev4SimLocalTime.Name = "ux_ev4SimLocalTime";
         this.ux_ev4SimLocalTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev4SimLocalTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev4SimLocalTime.TabIndex = 43;
         // 
         // ux_ev3SimLocalTime
         // 
         this.ux_ev3SimLocalTime.AutoSize = true;
         this.ux_ev3SimLocalTime.Location = new System.Drawing.Point(788, 133);
         this.ux_ev3SimLocalTime.Name = "ux_ev3SimLocalTime";
         this.ux_ev3SimLocalTime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev3SimLocalTime.Size = new System.Drawing.Size(8, 30);
         this.ux_ev3SimLocalTime.TabIndex = 44;
         // 
         // ux_ev5RWUTC
         // 
         this.ux_ev5RWUTC.AutoSize = true;
         this.ux_ev5RWUTC.Location = new System.Drawing.Point(149, 221);
         this.ux_ev5RWUTC.Name = "ux_ev5RWUTC";
         this.ux_ev5RWUTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev5RWUTC.Size = new System.Drawing.Size(8, 30);
         this.ux_ev5RWUTC.TabIndex = 45;
         // 
         // ux_ev5TR
         // 
         this.ux_ev5TR.AutoSize = true;
         this.ux_ev5TR.Location = new System.Drawing.Point(4, 221);
         this.ux_ev5TR.Name = "ux_ev5TR";
         this.ux_ev5TR.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_ev5TR.Size = new System.Drawing.Size(8, 30);
         this.ux_ev5TR.TabIndex = 27;
         // 
         // ux_label9
         // 
         this.ux_label9.AutoSize = true;
         this.ux_label9.Location = new System.Drawing.Point(4, 1);
         this.ux_label9.Name = "ux_label9";
         this.ux_label9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.ux_label9.Size = new System.Drawing.Size(89, 30);
         this.ux_label9.TabIndex = 0;
         this.ux_label9.Text = "Time Rem";
         // 
         // ux_ev1TimePicker
         // 
         this.ux_ev1TimePicker.CustomFormat = "M/dd/yy HH:mm";
         this.ux_ev1TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.ux_ev1TimePicker.Location = new System.Drawing.Point(188, 166);
         this.ux_ev1TimePicker.Name = "ux_ev1TimePicker";
         this.ux_ev1TimePicker.ShowUpDown = true;
         this.ux_ev1TimePicker.Size = new System.Drawing.Size(187, 26);
         this.ux_ev1TimePicker.TabIndex = 30;
         this.ux_ev1TimePicker.ValueChanged += new System.EventHandler(this.ux_time1Picker_ValueChanged);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(14, 166);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(166, 26);
         this.textBox1.TabIndex = 31;
         // 
         // ux_label3
         // 
         this.ux_label3.AutoSize = true;
         this.ux_label3.Location = new System.Drawing.Point(16, 140);
         this.ux_label3.Name = "ux_label3";
         this.ux_label3.Size = new System.Drawing.Size(51, 20);
         this.ux_label3.TabIndex = 32;
         this.ux_label3.Text = "Name";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(14, 211);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(166, 26);
         this.textBox2.TabIndex = 33;
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(14, 255);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(166, 26);
         this.textBox3.TabIndex = 34;
         // 
         // textBox4
         // 
         this.textBox4.Location = new System.Drawing.Point(14, 303);
         this.textBox4.Name = "textBox4";
         this.textBox4.Size = new System.Drawing.Size(166, 26);
         this.textBox4.TabIndex = 35;
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(14, 349);
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(166, 26);
         this.textBox5.TabIndex = 36;
         // 
         // ux_ev2TimePicker
         // 
         this.ux_ev2TimePicker.CustomFormat = "M/dd/yy HH:mm";
         this.ux_ev2TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.ux_ev2TimePicker.Location = new System.Drawing.Point(188, 211);
         this.ux_ev2TimePicker.Name = "ux_ev2TimePicker";
         this.ux_ev2TimePicker.ShowUpDown = true;
         this.ux_ev2TimePicker.Size = new System.Drawing.Size(187, 26);
         this.ux_ev2TimePicker.TabIndex = 37;
         this.ux_ev2TimePicker.ValueChanged += new System.EventHandler(this.ux_ev2TimePicker_ValueChanged);
         // 
         // ux_ev3TimePicker
         // 
         this.ux_ev3TimePicker.CustomFormat = "M/dd/yy HH:mm";
         this.ux_ev3TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.ux_ev3TimePicker.Location = new System.Drawing.Point(188, 255);
         this.ux_ev3TimePicker.Name = "ux_ev3TimePicker";
         this.ux_ev3TimePicker.ShowUpDown = true;
         this.ux_ev3TimePicker.Size = new System.Drawing.Size(187, 26);
         this.ux_ev3TimePicker.TabIndex = 38;
         this.ux_ev3TimePicker.ValueChanged += new System.EventHandler(this.ux_ev3TimePicker_ValueChanged);
         // 
         // ux_ev4TimePicker
         // 
         this.ux_ev4TimePicker.CustomFormat = "M/dd/yy HH:mm";
         this.ux_ev4TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.ux_ev4TimePicker.Location = new System.Drawing.Point(188, 303);
         this.ux_ev4TimePicker.Name = "ux_ev4TimePicker";
         this.ux_ev4TimePicker.ShowUpDown = true;
         this.ux_ev4TimePicker.Size = new System.Drawing.Size(187, 26);
         this.ux_ev4TimePicker.TabIndex = 39;
         this.ux_ev4TimePicker.ValueChanged += new System.EventHandler(this.ux_ev4TimePicker_ValueChanged);
         // 
         // ux_ev5TimePicker
         // 
         this.ux_ev5TimePicker.CustomFormat = "M/dd/yy HH:mm";
         this.ux_ev5TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.ux_ev5TimePicker.Location = new System.Drawing.Point(188, 349);
         this.ux_ev5TimePicker.Name = "ux_ev5TimePicker";
         this.ux_ev5TimePicker.ShowUpDown = true;
         this.ux_ev5TimePicker.Size = new System.Drawing.Size(187, 26);
         this.ux_ev5TimePicker.TabIndex = 40;
         this.ux_ev5TimePicker.ValueChanged += new System.EventHandler(this.ux_ev5TimePicker_ValueChanged);
         // 
         // ux_label4
         // 
         this.ux_label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ux_label4.AutoSize = true;
         this.ux_label4.Location = new System.Drawing.Point(187, 140);
         this.ux_label4.Name = "ux_label4";
         this.ux_label4.Size = new System.Drawing.Size(127, 20);
         this.ux_label4.TabIndex = 41;
         this.ux_label4.Text = "Event (Sim UTC)";
         this.ux_label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // ux_dateFormat
         // 
         this.ux_dateFormat.FormattingEnabled = true;
         this.ux_dateFormat.Items.AddRange(new object[] {
            "MM/DD/YY",
            "DD/MM/YY"});
         this.ux_dateFormat.Location = new System.Drawing.Point(279, 86);
         this.ux_dateFormat.Name = "ux_dateFormat";
         this.ux_dateFormat.Size = new System.Drawing.Size(122, 28);
         this.ux_dateFormat.TabIndex = 42;
         this.ux_dateFormat.Text = "MM/DD/YY";
         this.ux_dateFormat.SelectedIndexChanged += new System.EventHandler(this.dateFormat_SelectedIndexChanged);
         // 
         // ux_label2
         // 
         this.ux_label2.AutoSize = true;
         this.ux_label2.Location = new System.Drawing.Point(16, 91);
         this.ux_label2.Name = "ux_label2";
         this.ux_label2.Size = new System.Drawing.Size(99, 20);
         this.ux_label2.TabIndex = 43;
         this.ux_label2.Text = "Date Format";
         // 
         // ux_language
         // 
         this.ux_language.FormattingEnabled = true;
         this.ux_language.Items.AddRange(new object[] {
            "English",
            "Español"});
         this.ux_language.Location = new System.Drawing.Point(1306, 403);
         this.ux_language.Name = "ux_language";
         this.ux_language.Size = new System.Drawing.Size(121, 28);
         this.ux_language.TabIndex = 44;
         this.ux_language.Text = "English";
         this.ux_language.SelectedIndexChanged += new System.EventHandler(this.ux_language_SelectedIndexChanged);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(418, 7);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(146, 30);
         this.button2.TabIndex = 46;
         this.button2.Text = "Get Sim Time";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1437, 440);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.ux_language);
         this.Controls.Add(this.ux_label2);
         this.Controls.Add(this.ux_dateFormat);
         this.Controls.Add(this.ux_label4);
         this.Controls.Add(this.ux_ev5TimePicker);
         this.Controls.Add(this.ux_ev4TimePicker);
         this.Controls.Add(this.ux_ev3TimePicker);
         this.Controls.Add(this.ux_ev2TimePicker);
         this.Controls.Add(this.textBox5);
         this.Controls.Add(this.textBox4);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.ux_label3);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.ux_ev1TimePicker);
         this.Controls.Add(this.tableLayoutPanel2);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Controls.Add(this.ux_simTimeOffset);
         this.Controls.Add(this.ux_simTimePicker);
         this.Controls.Add(this.ux_label1);
         this.Controls.Add(this.ux_label0);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "Form1";
         this.Text = "SimTime2RW";
         ((System.ComponentModel.ISupportInitialize)(this.ux_simTimeOffset)).EndInit();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label ux_label0;
      private System.Windows.Forms.Label ux_label1;
      private System.Windows.Forms.Label ux_label6;
      private System.Windows.Forms.Label ux_systemTime;
      private System.Windows.Forms.Label ux_label5;
      private System.Windows.Forms.Label ux_UTC;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Label ux_label7;
      private System.Windows.Forms.Label ux_simUTC;
      private System.Windows.Forms.Label ux_label8;
      private System.Windows.Forms.Label ux_simLocal;
      private System.Windows.Forms.Label ux_ev1RWUTC;
      private System.Windows.Forms.Label ux_ev1SystemTime;
      private System.Windows.Forms.Label ux_ev1SimUTC;
      private System.Windows.Forms.Label ux_ev1SimLocalTime;
      private System.Windows.Forms.Label ux_ev1TR;
      private System.Windows.Forms.DateTimePicker ux_simTimePicker;
      
      private System.Windows.Forms.NumericUpDown ux_simTimeOffset;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Label ux_label9;
      private System.Windows.Forms.Label ux_label10;
      private System.Windows.Forms.Label ux_label11;
      private System.Windows.Forms.Label ux_label12;
      private System.Windows.Forms.Label ux_label13;
      private System.Windows.Forms.DateTimePicker ux_ev1TimePicker;
      private System.Windows.Forms.Label ux_ev5TR;
      private System.Windows.Forms.Label ux_ev2TR;
      private System.Windows.Forms.Label ux_ev4TR;
      private System.Windows.Forms.Label ux_ev3TR;
      private System.Windows.Forms.Label ux_ev2RWUTC;
      private System.Windows.Forms.Label ux_ev4RWUTC;
      private System.Windows.Forms.Label ux_ev3RWUTC;
      private System.Windows.Forms.Label ux_ev5SimLocalTime;
      private System.Windows.Forms.Label ux_ev2SystemTime;
      private System.Windows.Forms.Label ux_ev4SystemTime;
      private System.Windows.Forms.Label ux_ev3SystemTime;
      private System.Windows.Forms.Label ux_ev2SimUTC;
      private System.Windows.Forms.Label ux_ev2SimLocalTime;
      private System.Windows.Forms.Label ux_ev3SimUTC;
      private System.Windows.Forms.Label ux_ev5SystemTime;
      private System.Windows.Forms.Label ux_ev5SimUTC;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label ux_label3;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.TextBox textBox4;
      private System.Windows.Forms.TextBox textBox5;
      private System.Windows.Forms.DateTimePicker ux_ev2TimePicker;
      private System.Windows.Forms.DateTimePicker ux_ev3TimePicker;
      private System.Windows.Forms.DateTimePicker ux_ev4TimePicker;
      private System.Windows.Forms.DateTimePicker ux_ev5TimePicker;
      private System.Windows.Forms.Label ux_ev4SimUTC;
      private System.Windows.Forms.Label ux_ev4SimLocalTime;
      private System.Windows.Forms.Label ux_ev3SimLocalTime;
      private System.Windows.Forms.Label ux_ev5RWUTC;
      private System.Windows.Forms.Label ux_label4;
      private System.Windows.Forms.ComboBox ux_dateFormat;
      private System.Windows.Forms.Label ux_label2;
      private System.Windows.Forms.ComboBox ux_language;
      private System.Windows.Forms.Button button2;
   }
}

