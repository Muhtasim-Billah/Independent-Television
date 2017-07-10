using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Count_Down.Properties;

namespace Count_Down
{
    public partial class Form1 : Form
    {
        private vizCommunication vc; //Here I used library which is removed from here
        private string scene1;
        private string sceneOld;
        private TimeSpan ts;
        private DateTime stopTime;
        Timer Clock,AutoClock;
        public int durTotalSec; //global var for storing the total duration value from form_load so that we can use it for min+,min-,sec+,sec-......
        public int nextSeq;
        private static string currentEngine = "";

        private Entities db;
        public Form1()
        {
            InitializeComponent();
            this.db = new Entities( Utility.getConnection());
            vc = new vizCommunication(); //I customized it using library which is removed from here
            //sceneOld was used before and is kept just to maintain backward compatibility. It is not used normally.
            this.sceneOld = "Scene Name";
            //scene1 is the actual scene that is loaded. Edit this scene name if necessary.
            this.scene1 = "Scene Name";
            Clock = new Timer();
            Clock.Interval = 1000;
            Clock.Tick += new EventHandler(Timer_Tick);
            ts = new TimeSpan();
        }
        public TimeSpan GetTime()  
        {
            ts = stopTime - DateTime.Now;
            return ts;
            /*string TimeInString="";  
            int hour=DateTime.Now.Hour;  
            int min=DateTime.Now.Minute;  
            int sec=DateTime.Now.Second;  
 
            TimeInString=(hour < 10)?"0" + hour.ToString() :hour.ToString();  
            TimeInString+=":" + ((min<10)?"0" + min.ToString() :min.ToString());  
            TimeInString+=":" + ((sec<10)?"0" + sec.ToString() :sec.ToString());  
            return TimeInString;  */
        }

          public void Timer_Tick(object sender, EventArgs eArgs)
          {
              if (sender == Clock)
              {
                  //lblTimer.Text = GetTime().ToString();
                  TimeSpan tmsn = GetTime();
                  lblTimer.Text = "00:" + tmsn.Minutes.ToString("D2") + ":" + tmsn.Seconds.ToString("D2");
                  if ((int)tmsn.TotalSeconds <= 0)//timer up automatically, stop timer, disable stop button
                  {
                      Clock.Stop();

                      this.sendVizCommand("0 RENDERER*STAGE*DIRECTOR*Xpel START");
                      //More Command to write


                  //    this.btnStop.Enabled = !this.btnStop.Enabled;//disables
                   //   this.btnStart4Min.Enabled = !this.btnStart4Min.Enabled;//enables
                      
                  }
              }
          }
  
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBxEngineSelect.Text))
            {
                MessageBox.Show("Select an engine first");
                return;
            }
            vc.hostname = cmbBxEngineSelect.Text;
            this.enableOrDisable4_5Buttons(false);
            
            vc.singleCommandSendNoBufferUseDefaults("0 RENDERER SET_OBJECT " + this.getCurrentScene() + " LOAD");
            //More Command to write
            vc.singleCommandSendNoBufferUseDefaults("0 RENDERER*TREE*@txt2*GEOM*TEXT SET 1");
            stopTime = DateTime.Now.AddMinutes(4.0);
            Clock.Start();
            this.enableOrDisable4_5Buttons(true);
           // this.btnStop.Enabled = !this.btnStop.Enabled;
        }
        private String getCurrentScene()
        {
            if (this.chkBxOldScene.Checked)
                return this.sceneOld;
            else
                return scene1;
        }
        private void btnStart5Min_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBxEngineSelect.Text))
            {
                MessageBox.Show("Select an engine first");
                return;
            }
            vc.hostname = cmbBxEngineSelect.Text;
            this.enableOrDisable4_5Buttons(false);
            this.sendVizCommand("0 RENDERER SET_OBJECT " + this.getCurrentScene() + " LOAD");
            //More Command to write
            this.sendVizCommand("0 RENDERER*TREE*@txt2*GEOM*TEXT SET 5");
            stopTime = DateTime.Now.AddMinutes(5.0);
            Clock.Start();
            this.enableOrDisable4_5Buttons(true);
         //   this.btnStop.Enabled = !this.btnStop.Enabled;
        }
        private void enableOrDisable4_5Buttons(bool isEnable)
        {
            this.btnStart4Min.Enabled = isEnable;
            this.btnStart5Min.Enabled = isEnable;
        }
        private void sendVizCommand(String command)
        {
            this.vc.singleCommandSendNoBufferUseDefaults(command);
        }
        private void btnCleanUp_Click(object sender, EventArgs e)
        {
         

            if (string.IsNullOrEmpty(cmbBxEngineSelect.Text))
            {
                MessageBox.Show("Select an engine first");
                return;
            }
            vc.hostname = cmbBxEngineSelect.Text;
            this.sendVizCommand("0 RENDERER*FRONT_LAYER SET_OBJECT");
            //More Command to write
            this.sendVizCommand("0 SCENE CLEANUP");
            this.sendVizCommand("0 GEOM CLEANUP");
            this.sendVizCommand("0 IMAGE CLEANUP");
            this.sendVizCommand("0 FONT CLEANUP");
            this.sendVizCommand("0 MATERIAL CLEANUP");
            this.sendVizCommand("0 MAPS CACHE CLEANUP");

            Clock.Stop();
            lblTimer.Text = "--:--:--";
          //  this.btnStart4Min.Enabled = true;
           // this.btnStop.Enabled = false;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBxEngineSelect.Text))
            {
                MessageBox.Show("Select an engine first");
                return;
            }
            vc.hostname = cmbBxEngineSelect.Text; 
            vc.singleCommandSendNoBufferUseDefaults("0 RENDERER*TREE*@txt2*GEOM*TEXT SET 3");
            Clock.Stop();
            //this.btnStart4Min.Enabled = !this.btnStart4Min.Enabled;
            //this.btnStop.Enabled = !this.btnStop.Enabled;
            lblTimer.Text = "--:--:--";
        }

        private void cmbBxEngineSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentEngine))//first time change
            {
                currentEngine = cmbBxEngineSelect.Text;
                btnCleanUp.Enabled = true;
                grpBxControl.Enabled = true;
            }
            else if (cmbBxEngineSelect.Text == currentEngine)//same engine selected again
            {
                btnCleanUp.Enabled = true;
                grpBxControl.Enabled = true;
            }
            else
            {
                DialogResult dr = MessageBox.Show("You are trying to change current engine, make sure current engine is cleaned up properly. Are you sure you want to change the engine?", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    currentEngine = cmbBxEngineSelect.Text;
                    btnCleanUp.Enabled = true;
                    grpBxControl.Enabled = true;
                }
                else
                {
                    cmbBxEngineSelect.Text = currentEngine;
                    return;
                }
                //MessageBox.Show("You are trying to change current engine, make sure current engine is cleaned up properly. Are you sure you want to change the engine?", 
            }
        }




        public void AutoTimer_Tick(object sender, EventArgs eArgs)
        {
            if (sender == AutoClock)
            {
                string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToUpper();
                int h = DateTime.Now.Hour;
                int m =DateTime.Now.Minute;
                if ((m < 20) && (m >= 5))
                {
                    if (nextSeq == 4)
                    {
                        db.getDuration(day, h, 1);
                    }
                }

                else if ((m < 35) && (m >= 20))
                {
                    if (nextSeq == 1)
                    {
                        db.getDuration(day, h, 2);
                    }
                }

                else if ((m < 50) && (m >= 35))
                {
                    if (nextSeq == 2)
                    {
                        db.getDuration(day, h, 3);
                    }
                     }

                else if ((m < 5) && (m >= 50))
                {
                    if (nextSeq == 3)
                    {

                        db.getDuration(day, h, 4);
                    }
                   

                }
                
                
            }
        }

        
        
        
        
        
        
        
        //*************************form_load function 
        private void Form1_Load(object sender, EventArgs e)
        {

            
            
            
            
            DateTime date = Convert.ToDateTime(System.DateTime.Today.ToShortDateString());

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToUpper();

            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;

            

            string t = "";

            

            if ((m < 11) && (m >= 0))
            {
                if (db.getDuration(day, h, 1) != -1)
                {

                    t = getTimeFormat(db.getDuration(day, h, 1)); //database theke total duration only sec e paisi...so otake amar create kora getTime
                                                                    //Format method die call kore time format hisebe t string e rakhbo jeta pore level e use hobe
                    
                    nextSeq = 1;
                }
                else
                {
                    MessageBox.Show("Next Break file isn't existed in the database");
                }
            }

            else if ((m < 25) && (m >= 11))
            {

                if (db.getDuration(day, h, 2) != -1)
                {
                    t = getTimeFormat(db.getDuration(day, h, 2));
                    nextSeq = 2;
                }
                else
                {
                    MessageBox.Show("Next Break File isn't existed in the database");
                }
            }

            else if ((m < 41) && (m >= 25))
            {
                if (db.getDuration(day, h, 3) != -1)
                {
                    int n=db.getDuration(day, h, 3);
                    t = t + getTimeFormat(n);
                    nextSeq = 3;
                }
                else
                {
                    MessageBox.Show("Next Break file isn't existed in the database");
                }
            }

            else if ((m < 55) && (m >= 41))
            {
                if (db.getDuration(day, h, 4) != -1)
                {
                    t = getTimeFormat(db.getDuration(day, h, 4));
                    nextSeq = 4;
                }
                else
                {
                    MessageBox.Show("Next Break file isn't existed in the database");
                }

            }

           

            AutoClock = new Timer();
            AutoClock.Interval = 5000;
            AutoClock.Tick += new EventHandler(AutoTimer_Tick);

            lbPresetDuration.Text = t.ToString();

        }

        //** convert second into minute
        private int getTimeFormatMinute(int sec)
        {
            int min = sec / 60;
            return min;
        }

        //**convert total second into second (after xtracting second used for minute)
        private string getTimeFormat(int sec)
        {
            TimeSpan t = TimeSpan.FromSeconds(sec);

            string answer = string.Format("{0:D2}:{1:D2}",
                            
                            t.Minutes,
                            t.Seconds
                            );

            return answer;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int btnMinPlus_Click(int sec)
        {
            int min = sec / 60;
            min = min + 1;
            return min;

        }

        
      
        
        
        
        //*****radio check button for preset duration...which set the timing to main counter listview from the preset list view
        private void rbPresetDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPresetDuration.Checked == true)
            {
                lblTimer.Text = lbPresetDuration.Text;
            }
        }


        private void rbFourMin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFourMin.Checked == true)
            {
                lblTimer.Text = "00:04:00";
            }
        }

        private void rbFiveMin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiveMin.Checked == true)
            {
                lblTimer.Text = "00:05:00";
            }
        }


       
        
       
        
        
        
        //*****this is the action listener for main start button...
        private void btnMainStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBxEngineSelect.Text))
            {
                MessageBox.Show("Select an engine first");
                return;
            }
            vc.hostname = cmbBxEngineSelect.Text;
            if (rbPresetDuration.Checked == true)
            {
                lblTimer.Text = lbPresetDuration.Text;
                stopTime = DateTime.Now.AddMinutes(Double.Parse(lblTimer.Text));
            }
            else if (rbFourMin.Checked == true)
            {
                lblTimer.Text = "00:04:00";
                stopTime = DateTime.Now.AddMinutes(4.0);
            }

            else if (rbFiveMin.Checked == true)
            {
                lblTimer.Text = "00:05:00";
                stopTime = DateTime.Now.AddMinutes(5.0);
            }

            else
            {
                MessageBox.Show("Please select any radio button to start the timer");
            }


         
            Clock.Start();
           
        }

     

        



        
    }
}
