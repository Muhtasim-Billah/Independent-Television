namespace Count_Down
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
            this.cmbBxEngineSelect = new System.Windows.Forms.ComboBox();
            this.btnStart4Min = new System.Windows.Forms.Button();
            this.btnCleanUp = new System.Windows.Forms.Button();
            this.grpBxControl = new System.Windows.Forms.GroupBox();
            this.btnSecMinus = new System.Windows.Forms.Button();
            this.btnSecPlus = new System.Windows.Forms.Button();
            this.rbNextPrevDur = new System.Windows.Forms.RadioButton();
            this.rbFiveMin = new System.Windows.Forms.RadioButton();
            this.rbFourMin = new System.Windows.Forms.RadioButton();
            this.rbPresetDuration = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnMainStart = new System.Windows.Forms.Button();
            this.btnMinMinus = new System.Windows.Forms.Button();
            this.btnMinPlus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPresetDuration = new System.Windows.Forms.Label();
            this.chkBxOldScene = new System.Windows.Forms.CheckBox();
            this.btnStart5Min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBxControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBxEngineSelect
            // 
            this.cmbBxEngineSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxEngineSelect.FormattingEnabled = true;
            this.cmbBxEngineSelect.Items.AddRange(new object[] {
            "VIZARTISTFULL",
            "VIZARTISTLITE",
            "VIZ-SUPERS-RE",
            "VIZ-BIZFF-RE",
            "VIZ-NEWSFF-RE"});
            this.cmbBxEngineSelect.Location = new System.Drawing.Point(117, 22);
            this.cmbBxEngineSelect.Name = "cmbBxEngineSelect";
            this.cmbBxEngineSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbBxEngineSelect.TabIndex = 1;
            this.cmbBxEngineSelect.SelectedIndexChanged += new System.EventHandler(this.cmbBxEngineSelect_SelectedIndexChanged);
            // 
            // btnStart4Min
            // 
            this.btnStart4Min.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart4Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart4Min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart4Min.Location = new System.Drawing.Point(15, 91);
            this.btnStart4Min.Name = "btnStart4Min";
            this.btnStart4Min.Size = new System.Drawing.Size(140, 41);
            this.btnStart4Min.TabIndex = 2;
            this.btnStart4Min.Text = "4 MINUTE Start";
            this.btnStart4Min.UseVisualStyleBackColor = false;
            this.btnStart4Min.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCleanUp
            // 
            this.btnCleanUp.BackColor = System.Drawing.Color.LightCoral;
            this.btnCleanUp.Enabled = false;
            this.btnCleanUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanUp.Location = new System.Drawing.Point(862, 22);
            this.btnCleanUp.Name = "btnCleanUp";
            this.btnCleanUp.Size = new System.Drawing.Size(89, 36);
            this.btnCleanUp.TabIndex = 3;
            this.btnCleanUp.Text = "Clean up";
            this.btnCleanUp.UseVisualStyleBackColor = false;
            this.btnCleanUp.Click += new System.EventHandler(this.btnCleanUp_Click);
            // 
            // grpBxControl
            // 
            this.grpBxControl.BackColor = System.Drawing.SystemColors.Control;
            this.grpBxControl.Controls.Add(this.btnSecMinus);
            this.grpBxControl.Controls.Add(this.btnSecPlus);
            this.grpBxControl.Controls.Add(this.rbNextPrevDur);
            this.grpBxControl.Controls.Add(this.rbFiveMin);
            this.grpBxControl.Controls.Add(this.rbFourMin);
            this.grpBxControl.Controls.Add(this.rbPresetDuration);
            this.grpBxControl.Controls.Add(this.panel3);
            this.grpBxControl.Controls.Add(this.btnBackward);
            this.grpBxControl.Controls.Add(this.btnForward);
            this.grpBxControl.Controls.Add(this.btnMainStart);
            this.grpBxControl.Controls.Add(this.btnMinMinus);
            this.grpBxControl.Controls.Add(this.btnMinPlus);
            this.grpBxControl.Controls.Add(this.panel2);
            this.grpBxControl.Controls.Add(this.chkBxOldScene);
            this.grpBxControl.Controls.Add(this.btnStart5Min);
            this.grpBxControl.Controls.Add(this.panel1);
            this.grpBxControl.Controls.Add(this.btnStop);
            this.grpBxControl.Controls.Add(this.btnStart4Min);
            this.grpBxControl.Enabled = false;
            this.grpBxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxControl.Location = new System.Drawing.Point(36, 58);
            this.grpBxControl.Name = "grpBxControl";
            this.grpBxControl.Size = new System.Drawing.Size(1187, 380);
            this.grpBxControl.TabIndex = 4;
            this.grpBxControl.TabStop = false;
            this.grpBxControl.Text = "Control";
            // 
            // btnSecMinus
            // 
            this.btnSecMinus.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSecMinus.Location = new System.Drawing.Point(850, 108);
            this.btnSecMinus.Name = "btnSecMinus";
            this.btnSecMinus.Size = new System.Drawing.Size(75, 35);
            this.btnSecMinus.TabIndex = 23;
            this.btnSecMinus.Text = "Sec-";
            this.btnSecMinus.UseVisualStyleBackColor = false;
            // 
            // btnSecPlus
            // 
            this.btnSecPlus.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSecPlus.Location = new System.Drawing.Point(852, 56);
            this.btnSecPlus.Name = "btnSecPlus";
            this.btnSecPlus.Size = new System.Drawing.Size(75, 35);
            this.btnSecPlus.TabIndex = 22;
            this.btnSecPlus.Text = "Sec+";
            this.btnSecPlus.UseVisualStyleBackColor = false;
            // 
            // rbNextPrevDur
            // 
            this.rbNextPrevDur.AutoSize = true;
            this.rbNextPrevDur.Location = new System.Drawing.Point(220, 279);
            this.rbNextPrevDur.Name = "rbNextPrevDur";
            this.rbNextPrevDur.Size = new System.Drawing.Size(235, 24);
            this.rbNextPrevDur.TabIndex = 21;
            this.rbNextPrevDur.TabStop = true;
            this.rbNextPrevDur.Text = "Use next/prev preset duration";
            this.rbNextPrevDur.UseVisualStyleBackColor = true;
            // 
            // rbFiveMin
            // 
            this.rbFiveMin.AutoSize = true;
            this.rbFiveMin.Location = new System.Drawing.Point(220, 210);
            this.rbFiveMin.Name = "rbFiveMin";
            this.rbFiveMin.Size = new System.Drawing.Size(183, 24);
            this.rbFiveMin.TabIndex = 20;
            this.rbFiveMin.TabStop = true;
            this.rbFiveMin.Text = "Use 5 Minute duration";
            this.rbFiveMin.UseVisualStyleBackColor = true;
            this.rbFiveMin.CheckedChanged += new System.EventHandler(this.rbFiveMin_CheckedChanged);
            // 
            // rbFourMin
            // 
            this.rbFourMin.AutoSize = true;
            this.rbFourMin.Location = new System.Drawing.Point(220, 176);
            this.rbFourMin.Name = "rbFourMin";
            this.rbFourMin.Size = new System.Drawing.Size(183, 24);
            this.rbFourMin.TabIndex = 19;
            this.rbFourMin.TabStop = true;
            this.rbFourMin.Text = "Use 4 Minute duration";
            this.rbFourMin.UseVisualStyleBackColor = true;
            this.rbFourMin.CheckedChanged += new System.EventHandler(this.rbFourMin_CheckedChanged);
            // 
            // rbPresetDuration
            // 
            this.rbPresetDuration.AutoSize = true;
            this.rbPresetDuration.Location = new System.Drawing.Point(219, 61);
            this.rbPresetDuration.Name = "rbPresetDuration";
            this.rbPresetDuration.Size = new System.Drawing.Size(167, 24);
            this.rbPresetDuration.TabIndex = 18;
            this.rbPresetDuration.TabStop = true;
            this.rbPresetDuration.Text = "Use preset duration";
            this.rbPresetDuration.UseVisualStyleBackColor = true;
            this.rbPresetDuration.CheckedChanged += new System.EventHandler(this.rbPresetDuration_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(483, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 44);
            this.panel3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "-- : -- : --";
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackward.Location = new System.Drawing.Point(572, 320);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(88, 31);
            this.btnBackward.TabIndex = 15;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Goldenrod;
            this.btnForward.Location = new System.Drawing.Point(483, 320);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(81, 31);
            this.btnForward.TabIndex = 14;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // btnMainStart
            // 
            this.btnMainStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMainStart.Location = new System.Drawing.Point(980, 108);
            this.btnMainStart.Name = "btnMainStart";
            this.btnMainStart.Size = new System.Drawing.Size(178, 56);
            this.btnMainStart.TabIndex = 13;
            this.btnMainStart.Text = "Start";
            this.btnMainStart.UseVisualStyleBackColor = false;
            this.btnMainStart.Click += new System.EventHandler(this.btnMainStart_Click);
            // 
            // btnMinMinus
            // 
            this.btnMinMinus.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMinMinus.Location = new System.Drawing.Point(764, 108);
            this.btnMinMinus.Name = "btnMinMinus";
            this.btnMinMinus.Size = new System.Drawing.Size(75, 35);
            this.btnMinMinus.TabIndex = 12;
            this.btnMinMinus.Text = "Min-";
            this.btnMinMinus.UseVisualStyleBackColor = false;
            // 
            // btnMinPlus
            // 
            this.btnMinPlus.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMinPlus.Location = new System.Drawing.Point(766, 56);
            this.btnMinPlus.Name = "btnMinPlus";
            this.btnMinPlus.Size = new System.Drawing.Size(75, 35);
            this.btnMinPlus.TabIndex = 11;
            this.btnMinPlus.Text = "Min+";
            this.btnMinPlus.UseVisualStyleBackColor = false;
            
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbPresetDuration);
            this.panel2.Location = new System.Drawing.Point(483, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 130);
            this.panel2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Next Break Preset Duration:";
            // 
            // lbPresetDuration
            // 
            this.lbPresetDuration.AutoSize = true;
            this.lbPresetDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresetDuration.Location = new System.Drawing.Point(14, 47);
            this.lbPresetDuration.Name = "lbPresetDuration";
            this.lbPresetDuration.Size = new System.Drawing.Size(260, 69);
            this.lbPresetDuration.TabIndex = 0;
            this.lbPresetDuration.Text = "-- : -- : --";
            // 
            // chkBxOldScene
            // 
            this.chkBxOldScene.AutoSize = true;
            this.chkBxOldScene.Location = new System.Drawing.Point(991, 39);
            this.chkBxOldScene.Name = "chkBxOldScene";
            this.chkBxOldScene.Size = new System.Drawing.Size(167, 24);
            this.chkBxOldScene.TabIndex = 8;
            this.chkBxOldScene.Text = "Use Sponsor (Xpel)";
            this.chkBxOldScene.UseVisualStyleBackColor = true;
            // 
            // btnStart5Min
            // 
            this.btnStart5Min.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart5Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart5Min.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart5Min.Location = new System.Drawing.Point(15, 150);
            this.btnStart5Min.Name = "btnStart5Min";
            this.btnStart5Min.Size = new System.Drawing.Size(140, 41);
            this.btnStart5Min.TabIndex = 7;
            this.btnStart5Min.Text = "5 MINUTE Start";
            this.btnStart5Min.UseVisualStyleBackColor = false;
            this.btnStart5Min.Click += new System.EventHandler(this.btnStart5Min_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Location = new System.Drawing.Point(939, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 59);
            this.panel1.TabIndex = 6;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(17, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(185, 40);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "--:--:--";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(991, 339);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(163, 41);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ENGINE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instructions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1. Select Engine first, Press LOAD and START, Timer will start and fade away auto" +
                "matically when finished";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "2. Press the STOP button when you want to forcefully end the timer.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "3. Clean the engine only when necessary or in case of emergency. Be careful about" +
                " which engine is selected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "4. For help, call 30555 (IT) of 01755515290 (Developer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 515);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBxControl);
            this.Controls.Add(this.btnCleanUp);
            this.Controls.Add(this.cmbBxEngineSelect);
            this.Name = "Form1";
            this.Text = "Count Down";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxControl.ResumeLayout(false);
            this.grpBxControl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxEngineSelect;
        private System.Windows.Forms.Button btnStart4Min;
        private System.Windows.Forms.Button btnCleanUp;
        private System.Windows.Forms.GroupBox grpBxControl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart5Min;
        private System.Windows.Forms.CheckBox chkBxOldScene;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnMainStart;
        private System.Windows.Forms.Button btnMinMinus;
        private System.Windows.Forms.Button btnMinPlus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPresetDuration;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbPresetDuration;
        private System.Windows.Forms.RadioButton rbFiveMin;
        private System.Windows.Forms.RadioButton rbFourMin;
        private System.Windows.Forms.Button btnSecMinus;
        private System.Windows.Forms.Button btnSecPlus;
        private System.Windows.Forms.RadioButton rbNextPrevDur;
    }
}

