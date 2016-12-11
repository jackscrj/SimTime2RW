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
      
      TimeSpan ts_simLocalTime = new TimeSpan();


      int[] ev1_timerem = { 0, 0 };

      int rwoffset = 0;
      int simoffset = 0;


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
            update_eventtimes();
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
         ts_simLocalTime = ts_simLocalTime.Add(new TimeSpan(0, 1, 0));
         dt_simTime = dt_simTime.Add(new TimeSpan(0, 1, 0));
         write_simtimes();
      }

      private void write_simtimes()
      {
         simgmt.Text = dt_simTime.ToShortDateString() + " " + dt_simTime.ToShortTimeString();
         simlocal.Text = ts_simLocalTime.ToString();
      }

      private void update_eventtimes()
      {
         if(ev1_timerem[1] == 0)
         {
            if(ev1_timerem[0] != 0)
            {
               ev1_timerem[0] -= 1;
               ev1_timerem[1] = 59;
            }
         }
         else
         {
            ev1_timerem[1] -= 1;
         }
         write_eventtimes();
      }
      
      private void write_eventtimes()
      {
         ev1_TR.Text = "TR: " + ev1_timerem[0].ToString() + ":" + ev1_timerem[1].ToString();
      }
      

      private void setrwoffset_Click(object sender, EventArgs e)
      {
         String[] simtimearr = Simtimebox.Text.Split(':');
         simoffset = int.Parse(ltobox.Text);

         
         ts_simLocalTime = new TimeSpan(int.Parse(simtimearr[0]) + simoffset, int.Parse(simtimearr[1]), 0);
         write_simtimes();
            
      }

      private void Simtimebox_TextChanged(object sender, EventArgs e)
      {
         
      }

      private void calc_Event1_Click(object sender, EventArgs e)
      {

         String[] eventtimearr = ev1_timebox.Text.Split(':');
         int[] evta = { int.Parse(eventtimearr[0]), int.Parse(eventtimearr[1]) };
         TimeSpan eventdiff = new TimeSpan(evta[0] - dt_simTime.Hour, evta[1] - dt_simTime.Minute, 0 );
         

         ev1_simgmt.Text = new TimeSpan(evta[0], evta[1], 0).ToString();
         ev1_simlt.Text = new TimeSpan(evta[0] + simoffset, evta[1], 0).ToString();

         ev1systemtime.Text = dt_latestTick.Add(eventdiff).ToShortTimeString();
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

      }

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
      {
         dt_simTime = dateTimePicker1.Value;
         write_simtimes();
         write_eventtimes();
      }
   }
}
