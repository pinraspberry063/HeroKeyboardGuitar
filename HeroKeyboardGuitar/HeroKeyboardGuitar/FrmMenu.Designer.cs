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
            btnAddSong = new Button();
            label1 = new Label();
            DifficultyBox = new ComboBox();
            SuspendLayout();
            // 
            // ModeDropDown
            // 
            ModeDropDown.FormattingEnabled = true;
            ModeDropDown.Items.AddRange(new object[] { "Default", "Color Blind Mode" });
            ModeDropDown.Location = new System.Drawing.Point(616, 313);
            ModeDropDown.Margin = new Padding(3, 4, 3, 4);
            ModeDropDown.Name = "ModeDropDown";
            ModeDropDown.Size = new System.Drawing.Size(228, 28);
            ModeDropDown.TabIndex = 1;
            // 
            // btnplay
            // 
            btnplay.Location = new System.Drawing.Point(634, 485);
            btnplay.Margin = new Padding(3, 4, 3, 4);
            btnplay.Name = "btnplay";
            btnplay.Size = new System.Drawing.Size(149, 43);
            btnplay.TabIndex = 2;
            btnplay.Text = "Play";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new System.Drawing.Point(172, 312);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new System.Drawing.Size(94, 29);
            btnAddSong.TabIndex = 3;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(185, 411);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "Difficulty:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DifficultyBox
            // 
            DifficultyBox.FormattingEnabled = true;
            DifficultyBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            DifficultyBox.Location = new System.Drawing.Point(153, 434);
            DifficultyBox.Margin = new Padding(2, 2, 2, 2);
            DifficultyBox.Name = "DifficultyBox";
            DifficultyBox.Size = new System.Drawing.Size(146, 28);
            DifficultyBox.TabIndex = 5;
            DifficultyBox.SelectionChangeCommitted += changeDifficulty;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(DifficultyBox);
            Controls.Add(label1);
            Controls.Add(btnAddSong);
            Controls.Add(btnplay);
            Controls.Add(ModeDropDown);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private System.Windows.Forms.ComboBox ModeDropDown;
        private Button btnplay;
        private Button btnAddSong;
        private Label label1;
        public ComboBox DifficultyBox;
    }
}