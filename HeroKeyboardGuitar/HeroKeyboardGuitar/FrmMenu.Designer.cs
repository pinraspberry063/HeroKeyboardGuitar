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
            SuspendLayout();
            // 
            // ModeDropDown
            // 
            ModeDropDown.FormattingEnabled = true;
            ModeDropDown.Items.AddRange(new object[] { "Default", "Color Blind Mode" });
            ModeDropDown.Location = new System.Drawing.Point(539, 235);
            ModeDropDown.Name = "ModeDropDown";
            ModeDropDown.Size = new System.Drawing.Size(200, 23);
            ModeDropDown.TabIndex = 1;
            // 
            // btnplay
            // 
            btnplay.Location = new System.Drawing.Point(555, 364);
            btnplay.Name = "btnplay";
            btnplay.Size = new System.Drawing.Size(130, 32);
            btnplay.TabIndex = 2;
            btnplay.Text = "Play";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnplay);
            Controls.Add(ModeDropDown);
            Name = "FrmMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }




        #endregion

        private System.Windows.Forms.ComboBox ModeDropDown;
        private Button btnplay;
    }
}