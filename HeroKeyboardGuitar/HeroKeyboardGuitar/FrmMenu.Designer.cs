using System;
using System.Windows.Forms;

namespace HeroKeyboardGuitar
{
    partial class FrmMenu
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
            ModeDropDown = new ComboBox();
            btnplay = new Button();
            button1 = new Button();
            label1 = new Label();
            DifficultyBox = new ComboBox();
            SuspendLayout();
            // 
            // ModeDropDown
            // 
            ModeDropDown.FormattingEnabled = true;
            ModeDropDown.Items.AddRange(new object[] { "Default", "Color Blind Mode" });
            ModeDropDown.Location = new System.Drawing.Point(770, 391);
            ModeDropDown.Margin = new Padding(4, 5, 4, 5);
            ModeDropDown.Name = "ModeDropDown";
            ModeDropDown.Size = new System.Drawing.Size(284, 33);
            ModeDropDown.TabIndex = 1;
            // 
            // btnplay
            // 
            btnplay.Location = new System.Drawing.Point(792, 606);
            btnplay.Margin = new Padding(4, 5, 4, 5);
            btnplay.Name = "btnplay";
            btnplay.Size = new System.Drawing.Size(186, 54);
            btnplay.TabIndex = 2;
            btnplay.Text = "Play";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(215, 390);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 36);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddSong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(231, 514);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 25);
            label1.TabIndex = 4;
            label1.Text = "Difficulty:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DifficultyBox
            // 
            DifficultyBox.FormattingEnabled = true;
            DifficultyBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            DifficultyBox.Location = new System.Drawing.Point(191, 542);
            DifficultyBox.Name = "DifficultyBox";
            DifficultyBox.Size = new System.Drawing.Size(182, 33);
            DifficultyBox.TabIndex = 5;
            DifficultyBox.SelectionChangeCommitted += changeDifficulty;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(1142, 750);
            Controls.Add(DifficultyBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnplay);
            Controls.Add(ModeDropDown);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private System.Windows.Forms.ComboBox ModeDropDown;
        private Button btnplay;
        private Button button1;
        private Label label1;
        public ComboBox DifficultyBox;
    }
}