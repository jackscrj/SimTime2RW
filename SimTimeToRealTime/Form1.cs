using System;
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
      DateTime dt_latestTick = DateTime.Now;
      DateTime dt_latestTickRWgmt = DateTime.UtcNow;
      DateTime dt_simTime = DateTime.UtcNow;
      DateTime dt_simLocalTime = DateTime.UtcNow;

      Boolean event1_isactive = false;


      int[] ev1_timerem = { 0, 0 };

      
     


      public Form1()
      {
         InitializeComponent();
         write_simtimes();
         systemtimelabel.Text = dt_latestTick.ToShortDateString() + " " + dt_latestTick.ToShortTimeString();
         rwgmt.Text = dt_latestTickRWgmt.ToShortDateString() + " " + dt_latestTickRWgmt.ToShortTimeString();
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         if(DateTime.Now.Minute != dt_latestTick.Minute)
         {
            get_time_update_gmt();
            update_simtimes();
            update_remtime();
         }
         

      }



      private void get_time_update_gmt()
      {
         dt_latestTick = DateTime.Now;
         dt_latestTickRWgmt = DateTime.UtcNow;
         systemtimelabel.Text = dt_latestTick.ToShortDateString() + " " + dt_latestTick.ToShortTimeString();
         rwgmt.Text = dt_latestTickRWgmt.ToShortDateString() + " " + dt_latestTickRWgmt.ToShortTimeString();
      }

      private void update_simtimes()
      {
         dt_simLocalTime = dt_simLocalTime.Add(new TimeSpan(0, 1, 0));
         dt_simTime = dt_simTime.Add(new TimeSpan(0, 1, 0));
         write_simtimes();
      }

      private void write_simtimes()
      {
         simgmt.Text = dt_simTime.ToShortDateString() + " " + dt_simTime.ToShortTimeString();
         simlocal.Text = dt_simLocalTime.ToShortDateString() + " " + dt_simLocalTime.ToShortTimeString();
      }


      /*

    

      

     private void write_eventtimes()
     {
        ev1_TR.Text = "TR: " + ev1_timerem[0].ToString() + ":" + ev1_timerem[1].ToString();
     }






     private void calc_Event1_Click(object sender, EventArgs e)
     {

        String[] eventtimearr = ev1_timebox.Text.Split(':');
        int[] evta = { int.Parse(eventtimearr[0]), int.Parse(eventtimearr[1]) };
        TimeSpan eventdiff = new TimeSpan(evta[0] - dt_simTime.Hour, evta[1] - dt_simTime.Minute, 0 );


        ev1_simgmt.Text = new TimeSpan(evta[0], evta[1], 0).ToString();
        ev1_simlt.Text = new TimeSpan(evta[0] + (int)SimTimeOffset.Value, evta[1], 0).ToString();

        ev1_systemtime.Text = dt_latestTick.Add(eventdiff).ToShortTimeString();
        ev1_rwgmt.Text = dt_latestTickRWgmt.Add(eventdiff).ToShortTimeString();

        ev1_timerem[0] = evta[0] - dt_simTime.Hour;
        ev1_timerem[1] = evta[1] - dt_simTime.Minute;

        if(ev1_timerem[1] < 0)
        {
           if(ev1_timerem[0] > 0)
           {
              ev1_timerem[0] -= 1;
              ev1_timerem[1] = 60 + ev1_timerem[1];
           }
           else
           {
              ev1_timerem = new int[] { 0,0};
           }
        } else if(ev1_timerem[0] < 0)
        {
           ev1_timerem = new int[] { 0,0 };
        }

        write_eventtimes();

     }*/

      private void update_remtime()
      {
         DateTime ev1time = Time1Picker.Value;
         TimeSpan ev1diff = ev1time - dt_simTime;
         ev1_TR.Text = ev1diff.ToString();
      }

      private void recalculate_eventTimes()
      {
         if (event1_isactive)
            calculate_event1times();
      }

      private void SimTimePicker_ValueChanged(object sender, EventArgs e)
      {
         dt_simTime = SimTimePicker.Value;
         dt_simLocalTime = dt_simTime.Add(new TimeSpan((int)SimTimeOffset.Value, 0, 0));
         write_simtimes();
         recalculate_eventTimes();
      }

    

      private void SimTimeOffset_ValueChanged(object sender, EventArgs e)
      {
         dt_simLocalTime = dt_simTime.Add(new TimeSpan((int)SimTimeOffset.Value, 0, 0));
         write_simtimes();
         recalculate_eventTimes();
         //test
      }

      private void Time1Picker_ValueChanged(object sender, EventArgs e)
      {
         event1_isactive = true;
         calculate_event1times(); 
      }

      private void calculate_event1times()
      {
         DateTime ev1time = Time1Picker.Value, ev1simt, ev1simlt, ev1rwt, ev1st;

         TimeSpan ev1diff = ev1time - dt_simTime;
         //for now just assume its given in gmt
         ev1simt = ev1time;
         ev1simlt = ev1time.Add(new TimeSpan((int)SimTimeOffset.Value, 0, 0));
         ev1rwt = dt_latestTickRWgmt.Add(ev1diff);
         ev1st = dt_latestTick.Add(ev1diff);

         ev1_TR.Text = ev1diff.ToString();
         ev1_simgmt.Text = write_dateTime(ev1simt);
         ev1_simlt.Text = write_dateTime(ev1simlt);
         ev1_rwgmt.Text = write_dateTime(ev1rwt);
         ev1_systemtime.Text = write_dateTime(ev1st);
      }

    

      private String write_dateTime(DateTime dt)
      {
         return dt.ToShortDateString() + " " + dt.ToShortTimeString();
      }
   }
}
