﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimTimeToRealTime
{
   public partial class Form1 : Form
   {
      DateTime dt_systemTime;
      DateTime dt_rwUTC;
      DateTime dt_simTime = DateTime.UtcNow;
      DateTime dt_simLocalTime = DateTime.UtcNow;

      Boolean ev1_isactive = false,
              ev2_isactive = false,
              ev3_isactive = false,
              ev4_isactive = false,
              ev5_isactive = false;

      String dateFormatstring = "M/d/yy";
      String[] englishLabels = { "Set Sim Time (UTC)", "Sim Local Time Offset", "Date Format", "Time",
         "Event (Sim UTC)", "Real World UTC", "System Time", "Sim UTC", "Sim Local", "Time Rem", "RW UTC",
         "System Time", "Sim UTC", "Sim Local" };
      String[] spanishLabels = { "Hora del simulador (UTC)", "Diferencia hora local y UTC (simulador)", "Formato de la fecha",
         "Nombre", "Evento del simulador (UTC)", "Hora UTC Real", "Hora en Windows", "Hora del simulador (UTC)", "Hora local del simulador",
         "Tiempo restante", "Hora UTC Real", "Hora en Windows", "Hora del simulador (UTC)", "Hola local del simulador" };

      public Form1()
      {
         InitializeComponent();
         write_simtimes();
         ux_systemTime.Text = write_dateTime(dt_systemTime);
         ux_UTC.Text = write_dateTime(dt_rwUTC);
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         if(DateTime.Now.Minute != dt_systemTime.Minute)
         {
            get_time_update();
            update_simtimes();
            update_remtime();
         }
      }

      private void get_time_update()
      {
         dt_systemTime = DateTime.Now;
         dt_rwUTC = DateTime.UtcNow;
         ux_systemTime.Text = write_dateTime(dt_systemTime); 
         ux_UTC.Text = write_dateTime(dt_rwUTC); 
      }

      private void update_simtimes()
      {
         dt_simLocalTime = dt_simLocalTime.Add(new TimeSpan(0, 1, 0));
         dt_simTime = dt_simTime.Add(new TimeSpan(0, 1, 0));
         ux_simTimePicker.Value = dt_simTime;
         write_simtimes();
      }

      private void write_simtimes()
      {
         ux_simUTC.Text = write_dateTime(dt_simTime);
         ux_simLocal.Text = write_dateTime(dt_simLocalTime); 
      }

      private void update_remtime()
      {
         if (ev1_isactive)
         {
            DateTime ev1time = ux_ev1TimePicker.Value;
            TimeSpan ev1diff = ev1time - dt_simTime;
            ux_ev1TR.Text = write_timeSpan(ev1diff);
         }
         if (ev2_isactive)
         {
            DateTime ev2time = ux_ev2TimePicker.Value;
            TimeSpan ev2diff = ev2time - dt_simTime;
            ux_ev2TR.Text = write_timeSpan(ev2diff);
         }
         if (ev3_isactive)
         {
            DateTime ev3time = ux_ev3TimePicker.Value;
            TimeSpan ev3diff = ev3time - dt_simTime;
            ux_ev3TR.Text = write_timeSpan(ev3diff);
         }
         if (ev4_isactive)
         {
            DateTime ev4time = ux_ev4TimePicker.Value;
            TimeSpan ev4diff = ev4time - dt_simTime;
            ux_ev4TR.Text = write_timeSpan(ev4diff);
         }
         if (ev5_isactive)
         {
            DateTime ev5time = ux_ev5TimePicker.Value;
            TimeSpan ev5diff = ev5time - dt_simTime;
            ux_ev5TR.Text = write_timeSpan(ev5diff);
         }
      }

      private void recalculate_eventTimes()
      {
         if (ev1_isactive)
            calculate_event1times();
         if (ev2_isactive)
            calculate_event2times();
         if (ev3_isactive)
            calculate_event3times();
         if (ev4_isactive)
            calculate_event4times();
         if (ev5_isactive)
            calculate_event5times();
      }

      private void ux_simTimePicker_ValueChanged(object sender, EventArgs e)
      {
         dt_simTime = ux_simTimePicker.Value;
         dt_simLocalTime = dt_simTime.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         write_simtimes();
         recalculate_eventTimes();
      }

      private void ux_simTimeOffset_ValueChanged(object sender, EventArgs e)
      {
         dt_simLocalTime = dt_simTime.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         write_simtimes();
         recalculate_eventTimes();
      }

      private void ux_time1Picker_ValueChanged(object sender, EventArgs e)
      {
         ev1_isactive = true;
         calculate_event1times(); 
      }

      private void ux_ev2TimePicker_ValueChanged(object sender, EventArgs e)
      {
         ev2_isactive = true;
         calculate_event2times();
      }

      private void ux_ev3TimePicker_ValueChanged(object sender, EventArgs e)
      {
         ev3_isactive = true;
         calculate_event3times(); 
      }

      private void ux_ev4TimePicker_ValueChanged(object sender, EventArgs e)
      {
         ev4_isactive = true;
         calculate_event4times();
      }

      private void ux_ev5TimePicker_ValueChanged(object sender, EventArgs e)
      {
         ev5_isactive = true;
         calculate_event5times();
      }

      private void calculate_event1times()
      {
         DateTime ev1time = ux_ev1TimePicker.Value, ev1simt, ev1simlt, ev1rwt, ev1st;

         TimeSpan ev1diff = ev1time - dt_simTime;
         //for now just assume its given in gmt
         ev1simt = ev1time;
         ev1simlt = ev1time.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         ev1rwt = dt_rwUTC.Add(ev1diff);
         ev1st = dt_systemTime.Add(ev1diff);

         ux_ev1TR.Text = write_timeSpan(ev1diff);
         ux_ev1SimUTC.Text = write_dateTime(ev1simt);
         ux_ev1SimLocalTime.Text = write_dateTime(ev1simlt);
         ux_ev1SystemTime.Text = write_dateTime(ev1st);
         ux_ev1RWUTC.Text = write_dateTime(ev1rwt);
      }

      private void calculate_event2times()
      {
         DateTime ev2time = ux_ev2TimePicker.Value, ev2simt, ev2simlt, ev2rwt, ev2st;

         TimeSpan ev2diff = ev2time - dt_simTime;
         //for now just assume its given in gmt
         ev2simt = ev2time;
         ev2simlt = ev2time.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         ev2rwt = dt_rwUTC.Add(ev2diff);
         ev2st = dt_systemTime.Add(ev2diff);

         ux_ev2TR.Text = write_timeSpan(ev2diff);
         ux_ev2SimUTC.Text = write_dateTime(ev2simt);
         ux_ev2SimLocalTime.Text = write_dateTime(ev2simlt);
         ux_ev2SystemTime.Text = write_dateTime(ev2st);
         ux_ev2RWUTC.Text = write_dateTime(ev2rwt);
      }

      private void calculate_event3times()
      {
         DateTime ev3time = ux_ev3TimePicker.Value, ev3simt, ev3simlt, ev3rwt, ev3st;

         TimeSpan ev3diff = ev3time - dt_simTime;
         //for now just assume its given in gmt
         ev3simt = ev3time;
         ev3simlt = ev3time.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         ev3rwt = dt_rwUTC.Add(ev3diff);
         ev3st = dt_systemTime.Add(ev3diff);

         ux_ev3TR.Text = write_timeSpan(ev3diff);
         ux_ev3SimUTC.Text = write_dateTime(ev3simt);
         ux_ev3SimLocalTime.Text = write_dateTime(ev3simlt);
         ux_ev3SystemTime.Text = write_dateTime(ev3st);
         ux_ev3RWUTC.Text = write_dateTime(ev3rwt);
      }

     

      private void calculate_event4times()
      {
         DateTime ev4time = ux_ev4TimePicker.Value, ev4simt, ev4simlt, ev4rwt, ev4st;

         TimeSpan ev4diff = ev4time - dt_simTime;
         //for now just assume its given in gmt
         ev4simt = ev4time;
         ev4simlt = ev4time.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         ev4rwt = dt_rwUTC.Add(ev4diff);
         ev4st = dt_systemTime.Add(ev4diff);

         ux_ev4TR.Text = write_timeSpan(ev4diff);
         ux_ev4SimUTC.Text = write_dateTime(ev4simt);
         ux_ev4SimLocalTime.Text = write_dateTime(ev4simlt);
         ux_ev4SystemTime.Text = write_dateTime(ev4st);
         ux_ev4RWUTC.Text = write_dateTime(ev4rwt);
      }

      private void ux_language_SelectedIndexChanged(object sender, EventArgs e)
      {
         if ((string)ux_language.SelectedItem == "English" )
         {
            set_labels(englishLabels);
         } else if ((string)ux_language.SelectedItem == "Español")
         {
            set_labels(spanishLabels);
         }
      }

      private void set_labels(String[] txt)
      {
         ux_label0.Text = txt[0];
         ux_label1.Text = txt[1];
         ux_label2.Text = txt[2];
         ux_label3.Text = txt[3];
         ux_label4.Text = txt[4];
         ux_label5.Text = txt[5];
         ux_label6.Text = txt[6];
         ux_label7.Text = txt[7];
         ux_label8.Text = txt[8];
         ux_label9.Text = txt[9];
         ux_label10.Text = txt[10];
         ux_label11.Text = txt[11];
         ux_label12.Text = txt[12];
         ux_label13.Text = txt[13];
      }

      private void calculate_event5times()
      {
         DateTime ev5time = ux_ev5TimePicker.Value, ev5simt, ev5simlt, ev5rwt, ev5st;

         TimeSpan ev5diff = ev5time - dt_simTime;
         //for now just assume its given in gmt
         ev5simt = ev5time;
         ev5simlt = ev5time.Add(new TimeSpan((int)ux_simTimeOffset.Value, 0, 0));
         ev5rwt = dt_rwUTC.Add(ev5diff);
         ev5st = dt_systemTime.Add(ev5diff);

         ux_ev5TR.Text = write_timeSpan(ev5diff);
         ux_ev5SimUTC.Text = write_dateTime(ev5simt);
         ux_ev5SimLocalTime.Text = write_dateTime(ev5simlt);
         ux_ev5SystemTime.Text = write_dateTime(ev5st);
         ux_ev5RWUTC.Text = write_dateTime(ev5rwt);
      }

      private void dateFormat_SelectedIndexChanged(object sender, EventArgs e)
      {
         if ((string)ux_dateFormat.SelectedItem == "MM/DD/YY")
         {
            dateFormatstring = "M/d/yy";
            ux_ev1TimePicker.CustomFormat = "M/d/yy HH:mm";
            ux_ev2TimePicker.CustomFormat = "M/d/yy HH:mm";
            ux_ev3TimePicker.CustomFormat = "M/d/yy HH:mm";
            ux_ev4TimePicker.CustomFormat = "M/d/yy HH:mm";
            ux_ev5TimePicker.CustomFormat = "M/d/yy HH:mm";
            ux_simTimePicker.CustomFormat = "M/d/yy HH:mm";
         }
         else if ((string)ux_dateFormat.SelectedItem == "DD/MM/YY")
         {
            dateFormatstring = "d/M/yy";
            ux_ev1TimePicker.CustomFormat = "d/M/yy HH:mm";
            ux_ev2TimePicker.CustomFormat = "d/M/yy HH:mm";
            ux_ev3TimePicker.CustomFormat = "d/M/yy HH:mm";
            ux_ev4TimePicker.CustomFormat = "d/M/yy HH:mm";
            ux_ev5TimePicker.CustomFormat = "d/M/yy HH:mm";
            ux_simTimePicker.CustomFormat = "d/M/yy HH:mm";
         }

         get_time_update();
         write_simtimes();
         recalculate_eventTimes();

         
      }

      private String write_dateTime(DateTime dt)
      {
         return dt.ToString(dateFormatstring + " HH:mm"); 
      }

      private String write_timeSpan(TimeSpan ts)
      {
         String rtn = "";
         if (ts.TotalSeconds < 0)
            rtn += "-";
         if (ts.Days != 0)
            rtn += ts.ToString("%d") + " days ";
         rtn += ts.ToString(@"hh\:mm");
         return rtn;
      }
   }
}
