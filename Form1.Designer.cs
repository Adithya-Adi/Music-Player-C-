namespace MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playbtn = new System.Windows.Forms.Button();
            this.pausebtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.resumebtn = new System.Windows.Forms.Button();
            this.fastforwardbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.endbtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.Ltb_Musics = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label3 = new System.Windows.Forms.Label();
            this.nextbtn = new System.Windows.Forms.Button();
            this.TimerTick = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(93, 166);
            this.playbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(112, 35);
            this.playbtn.TabIndex = 1;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pausebtn
            // 
            this.pausebtn.Location = new System.Drawing.Point(255, 166);
            this.pausebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(112, 35);
            this.pausebtn.TabIndex = 2;
            this.pausebtn.Text = "Pause";
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(411, 166);
            this.stopbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(112, 35);
            this.stopbtn.TabIndex = 3;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // resumebtn
            // 
            this.resumebtn.Location = new System.Drawing.Point(158, 271);
            this.resumebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(112, 35);
            this.resumebtn.TabIndex = 4;
            this.resumebtn.Text = "Resume";
            this.resumebtn.UseVisualStyleBackColor = true;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // fastforwardbtn
            // 
            this.fastforwardbtn.Location = new System.Drawing.Point(351, 271);
            this.fastforwardbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fastforwardbtn.Name = "fastforwardbtn";
            this.fastforwardbtn.Size = new System.Drawing.Size(112, 35);
            this.fastforwardbtn.TabIndex = 5;
            this.fastforwardbtn.Text = "FastForward";
            this.fastforwardbtn.UseVisualStyleBackColor = true;
            this.fastforwardbtn.Click += new System.EventHandler(this.fastforwardbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(13, 431);
            this.startbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(112, 35);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "<<";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.Location = new System.Drawing.Point(138, 431);
            this.previousbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(112, 35);
            this.previousbtn.TabIndex = 7;
            this.previousbtn.Text = "<";
            this.previousbtn.UseVisualStyleBackColor = true;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // endbtn
            // 
            this.endbtn.Location = new System.Drawing.Point(420, 431);
            this.endbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(112, 35);
            this.endbtn.TabIndex = 9;
            this.endbtn.Text = ">>";
            this.endbtn.UseVisualStyleBackColor = true;
            this.endbtn.Click += new System.EventHandler(this.endbtn_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(42, 489);
            this.Timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(43, 20);
            this.Timer.TabIndex = 10;
            this.Timer.Text = "Time";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(103, 489);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(49, 20);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "00:00";
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(200, 489);
            this.lbl_duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(70, 20);
            this.lbl_duration.TabIndex = 12;
            this.lbl_duration.Text = "Duration";
            this.lbl_duration.Click += new System.EventHandler(this.lbl_duration_Click);
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Location = new System.Drawing.Point(278, 489);
            this.lblduration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(49, 20);
            this.lblduration.TabIndex = 13;
            this.lblduration.Text = "00:00";
            this.lblduration.Click += new System.EventHandler(this.lblduration_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(689, 513);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(112, 35);
            this.addbtn.TabIndex = 19;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Ltb_Musics
            // 
            this.Ltb_Musics.FormattingEnabled = true;
            this.Ltb_Musics.ItemHeight = 20;
            this.Ltb_Musics.Location = new System.Drawing.Point(600, 152);
            this.Ltb_Musics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ltb_Musics.Name = "Ltb_Musics";
            this.Ltb_Musics.Size = new System.Drawing.Size(549, 324);
            this.Ltb_Musics.TabIndex = 20;
            this.Ltb_Musics.SelectedIndexChanged += new System.EventHandler(this.Ltb_Musics_SelectedIndexChanged_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(371, 96);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(518, 26);
            this.searchtxt.TabIndex = 27;
            this.searchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(13, 216);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(356, 45);
            this.Player.TabIndex = 0;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(472, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 46);
            this.label3.TabIndex = 28;
            this.label3.Text = "Music Player";
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(276, 431);
            this.nextbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(112, 35);
            this.nextbtn.TabIndex = 8;
            this.nextbtn.Text = ">";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // TimerTick
            // 
            this.TimerTick.AutoSize = true;
            this.TimerTick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimerTick.Location = new System.Drawing.Point(663, 420);
            this.TimerTick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimerTick.Name = "TimerTick";
            this.TimerTick.Size = new System.Drawing.Size(86, 24);
            this.TimerTick.TabIndex = 14;
            this.TimerTick.Text = "Shuffle";
            this.TimerTick.UseVisualStyleBackColor = true;
            this.TimerTick.Visible = false;
            this.TimerTick.CheckedChanged += new System.EventHandler(this.Timer_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(883, 513);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ltb_Musics);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.TimerTick);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.fastforwardbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.Player);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button fastforwardbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox Ltb_Musics;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.CheckBox TimerTick;
        private System.Windows.Forms.Button button2;
    }
}

