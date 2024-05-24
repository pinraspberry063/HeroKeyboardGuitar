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
            ModeDropDown.Location = new System.Drawing.Point(279, 285);
            ModeDropDown.Name = "ModeDropDown";
            ModeDropDown.Size = new System.Drawing.Size(225, 23);
            ModeDropDown.TabIndex = 1;
            // 
            // btnplay
            // 
            btnplay.Location = new System.Drawing.Point(585, 363);
            btnplay.Name = "btnplay";
            btnplay.Size = new System.Drawing.Size(156, 38);
            btnplay.TabIndex = 2;
            btnplay.Text = "Play";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(236, 53);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(305, 72);
            button1.TabIndex = 3;
            button1.Text = "Upload Song";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddSong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(351, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Difficulty:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DifficultyBox
            // 
            DifficultyBox.FormattingEnabled = true;
            DifficultyBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            DifficultyBox.Location = new System.Drawing.Point(279, 190);
            DifficultyBox.Margin = new Padding(2);
            DifficultyBox.Name = "DifficultyBox";
            DifficultyBox.Size = new System.Drawing.Size(225, 23);
            DifficultyBox.TabIndex = 5;
            DifficultyBox.SelectionChangeCommitted += changeDifficulty;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(799, 450);
            Controls.Add(DifficultyBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnplay);
            Controls.Add(ModeDropDown);
            Name = "FrmMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
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