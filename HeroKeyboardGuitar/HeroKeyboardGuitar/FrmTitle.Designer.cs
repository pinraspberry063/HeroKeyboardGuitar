namespace HeroKeyboardGuitar {
    partial class FrmTitle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new System.Windows.Forms.Button();
            DifficultyBox = new System.Windows.Forms.ComboBox();
            Difficulty = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnStart.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnStart.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStart.ForeColor = System.Drawing.Color.Black;
            btnStart.Location = new System.Drawing.Point(669, 793);
            btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(484, 150);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // DifficultyBox
            // 
            DifficultyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            DifficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DifficultyBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            DifficultyBox.FormattingEnabled = true;
            DifficultyBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            DifficultyBox.Location = new System.Drawing.Point(1550, 857);
            DifficultyBox.Name = "DifficultyBox";
            DifficultyBox.Size = new System.Drawing.Size(182, 33);
            DifficultyBox.TabIndex = 1;
            // 
            // Difficulty
            // 
            Difficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            Difficulty.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            Difficulty.Location = new System.Drawing.Point(1550, 823);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new System.Drawing.Size(182, 33);
            Difficulty.TabIndex = 2;
            Difficulty.Text = "Difficulty:";
            Difficulty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmTitle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.title;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1756, 1107);
            Controls.Add(Difficulty);
            Controls.Add(DifficultyBox);
            Controls.Add(btnStart);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmTitle";
            Text = "Hero Keyboard Guitar";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmTitle_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox DifficultyBox;
        private System.Windows.Forms.Label Difficulty;
    }
}