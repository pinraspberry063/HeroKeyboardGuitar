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
            // button1
            // 
            button1.Location = new System.Drawing.Point(172, 312);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(button1);
            Controls.Add(btnplay);
            Controls.Add(ModeDropDown);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }




        #endregion

        private System.Windows.Forms.ComboBox ModeDropDown;
        private Button btnplay;
        private Button button1;
    }
}