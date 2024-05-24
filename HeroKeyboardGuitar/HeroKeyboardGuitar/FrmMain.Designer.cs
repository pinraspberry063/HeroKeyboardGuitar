using ScottPlot.Colormaps;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HeroKeyboardGuitar {
    partial class FrmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrPlay = new System.Windows.Forms.Timer(components);
            lblScore = new System.Windows.Forms.Label();
            pictargets = new();
            tmrScoreShrink = new System.Windows.Forms.Timer(components);
            panBg = new System.Windows.Forms.Panel();
            foreach (KeyValuePair<string, PictureBox> picTarget in pictargets)
                ((System.ComponentModel.ISupportInitialize)picTarget.Value).BeginInit();
            panBg.SuspendLayout();
            SuspendLayout();
            // 
            // tmrPlay
            // 
            tmrPlay.Interval = 50;
            tmrPlay.Tick += tmrPlay_Tick;
            // 
            // picTargetgreen
            // 
            var picTargetG = new System.Windows.Forms.PictureBox();
            picTargetG.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            picTargetG.BackgroundImage = Properties.Resources._default;
            picTargetG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTargetG.Location = new System.Drawing.Point(372, 498);
            picTargetG.Name = "picTargetG";
            picTargetG.Size = new System.Drawing.Size(120, 120);
            picTargetG.TabIndex = 3;
            picTargetG.TabStop = false;
            pictargets["green"] = picTargetG;
            pictargets["default"] = picTargetG;
            // 
            // picTargetred
            // 
            var picTargetR = new System.Windows.Forms.PictureBox();
            picTargetR.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            picTargetR.BackgroundImage = Properties.Resources.default_red;
            picTargetR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTargetR.Location = new System.Drawing.Point(picTargetG.Left + 200, 498);
            picTargetR.Name = "picTargetR";
            picTargetR.Size = new System.Drawing.Size(120, 120);
            picTargetR.TabIndex = 3;
            picTargetR.TabStop = false;
            pictargets["red"] = picTargetR;
            // 
            // picTargetblue
            // 
            var picTargetB = new System.Windows.Forms.PictureBox();
            picTargetB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            picTargetB.BackgroundImage = Properties.Resources.default_blue;
            picTargetB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTargetB.Location = new System.Drawing.Point(picTargetR.Left + 200, 498);
            picTargetB.Name = "picTargetB";
            picTargetB.Size = new System.Drawing.Size(120, 120);
            picTargetB.TabIndex = 3;
            picTargetB.TabStop = false;
            pictargets["blue"] = picTargetB;
            // 
            // lblScore
            // 
            lblScore.BackColor = System.Drawing.Color.Transparent;
            lblScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblScore.ForeColor = System.Drawing.Color.White;
            lblScore.Location = new System.Drawing.Point(0, 50);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(1237, 89);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrScoreShrink
            // 
            tmrScoreShrink.Enabled = true;
            tmrScoreShrink.Tick += tmrScoreShrink_Tick;
            // 
            // panBg
            // 
            panBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panBg.Controls.Add(streakBar);
            panBg.Controls.Add(lblStreak);
            panBg.Controls.Add(lblScore);
            panBg.Dock = System.Windows.Forms.DockStyle.Top;
            panBg.Location = new System.Drawing.Point(0, 0);
            panBg.Name = "panBg";
            panBg.Size = new System.Drawing.Size(1237, 480);
            panBg.SendToBack();
            panBg.TabIndex = 6;
            // 
            // streakBar
            // 
            streakBar.Location = new System.Drawing.Point(155, 219);
            streakBar.MarqueeAnimationSpeed = 1;
            streakBar.Maximum = 5;
            streakBar.Name = "streakBar";
            streakBar.Size = new System.Drawing.Size(277, 18);
            streakBar.Step = 1;
            streakBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            streakBar.TabIndex = 7;
            // 
            // lblStreak
            // 
            lblStreak.BackColor = System.Drawing.Color.Transparent;
            lblStreak.Dock = System.Windows.Forms.DockStyle.Top;
            lblStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblStreak.ForeColor = System.Drawing.Color.White;
            lblStreak.Location = new System.Drawing.Point(0, 0);
            lblStreak.Name = "lblStreak";
            lblStreak.Size = new System.Drawing.Size(1237, 391);
            lblStreak.TabIndex = 6;
            lblStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1237, 644);
            Controls.Add(panBg);
            foreach (KeyValuePair< string, PictureBox> picTarget in pictargets)
                Controls.Add(picTarget.Value);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Play Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            KeyDown += FrmMain_KeyDown;
            KeyPress += FrmMain_KeyPress;
            KeyUp += FrmMain_KeyUp;
            foreach (KeyValuePair<string, PictureBox> picTarget in pictargets)
                ((System.ComponentModel.ISupportInitialize)picTarget.Value).EndInit();
            panBg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrPlay;
        public static Dictionary<string, PictureBox> pictargets;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrScoreShrink;
        private System.Windows.Forms.Panel panBg;
        private System.Windows.Forms.Label lblStreak;
        private System.Windows.Forms.ProgressBar streakBar;
    }
}
