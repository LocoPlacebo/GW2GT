namespace GoldTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TimerButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.titlelabel1 = new System.Windows.Forms.Label();
            this.TimerButton1 = new System.Windows.Forms.Button();
            this.APILinkLabel = new System.Windows.Forms.LinkLabel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.APITextBox = new System.Windows.Forms.TextBox();
            this.APIKeyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartingGoldLabel = new System.Windows.Forms.Label();
            this.CurrentGoldLabel = new System.Windows.Forms.Label();
            this.ChangeGoldLabel = new System.Windows.Forms.Label();
            this.StartingSilverLabel = new System.Windows.Forms.Label();
            this.CurrentSilverLabel = new System.Windows.Forms.Label();
            this.ChangeSilverLabel = new System.Windows.Forms.Label();
            this.CurrentBronzeLabel = new System.Windows.Forms.Label();
            this.StartingBronzeLabel = new System.Windows.Forms.Label();
            this.ChangeBronzeLabel = new System.Windows.Forms.Label();
            this.UpdateTitleLabel = new System.Windows.Forms.Label();
            this.APIErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToggleTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(193, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(336, 50);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "GW2 Gold Tracker";
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(0, 0);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(75, 23);
            this.TimerButton.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(253, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(128, 50);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // titlelabel1
            // 
            this.titlelabel1.AutoSize = true;
            this.titlelabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titlelabel1.Location = new System.Drawing.Point(102, 9);
            this.titlelabel1.Name = "titlelabel1";
            this.titlelabel1.Size = new System.Drawing.Size(336, 50);
            this.titlelabel1.TabIndex = 0;
            this.titlelabel1.Text = "GW2 Gold Tracker";
            // 
            // TimerButton1
            // 
            this.TimerButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimerButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerButton1.Location = new System.Drawing.Point(173, 293);
            this.TimerButton1.Name = "TimerButton1";
            this.TimerButton1.Size = new System.Drawing.Size(191, 40);
            this.TimerButton1.TabIndex = 1;
            this.TimerButton1.Text = "Start Timer";
            this.TimerButton1.UseVisualStyleBackColor = false;
            this.TimerButton1.Click += new System.EventHandler(this.TimerButton1_Click);
            // 
            // APILinkLabel
            // 
            this.APILinkLabel.AutoSize = true;
            this.APILinkLabel.Location = new System.Drawing.Point(445, 73);
            this.APILinkLabel.Name = "APILinkLabel";
            this.APILinkLabel.Size = new System.Drawing.Size(50, 15);
            this.APILinkLabel.TabIndex = 2;
            this.APILinkLabel.TabStop = true;
            this.APILinkLabel.Text = " API Key";
            this.APILinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.APILinkLabel_LinkClicked);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(173, 336);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(189, 21);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "0s";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // APITextBox
            // 
            this.APITextBox.Location = new System.Drawing.Point(27, 92);
            this.APITextBox.Name = "APITextBox";
            this.APITextBox.PlaceholderText = "Requires \'Wallet\' Permission";
            this.APITextBox.Size = new System.Drawing.Size(468, 23);
            this.APITextBox.TabIndex = 4;
            this.APITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.APITextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // APIKeyLabel
            // 
            this.APIKeyLabel.AutoSize = true;
            this.APIKeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIKeyLabel.Location = new System.Drawing.Point(215, 68);
            this.APIKeyLabel.Name = "APIKeyLabel";
            this.APIKeyLabel.Size = new System.Drawing.Size(102, 21);
            this.APIKeyLabel.TabIndex = 5;
            this.APIKeyLabel.Text = "Enter API Key";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 16);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(280, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 16);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(334, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 16);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(334, 197);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 16);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(334, 243);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 16);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(384, 152);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(17, 16);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(384, 197);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(17, 16);
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(384, 243);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 16);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Starting Wallet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current Wallet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(141, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Change:";
            // 
            // StartingGoldLabel
            // 
            this.StartingGoldLabel.AutoSize = true;
            this.StartingGoldLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartingGoldLabel.Location = new System.Drawing.Point(237, 147);
            this.StartingGoldLabel.Name = "StartingGoldLabel";
            this.StartingGoldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartingGoldLabel.Size = new System.Drawing.Size(46, 21);
            this.StartingGoldLabel.TabIndex = 18;
            this.StartingGoldLabel.Text = "0000";
            this.StartingGoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartingGoldLabel.Click += new System.EventHandler(this.StartingGoldLabel_Click);
            // 
            // CurrentGoldLabel
            // 
            this.CurrentGoldLabel.AutoSize = true;
            this.CurrentGoldLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentGoldLabel.Location = new System.Drawing.Point(237, 192);
            this.CurrentGoldLabel.Name = "CurrentGoldLabel";
            this.CurrentGoldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentGoldLabel.Size = new System.Drawing.Size(46, 21);
            this.CurrentGoldLabel.TabIndex = 19;
            this.CurrentGoldLabel.Text = "0000";
            this.CurrentGoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChangeGoldLabel
            // 
            this.ChangeGoldLabel.AutoSize = true;
            this.ChangeGoldLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeGoldLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ChangeGoldLabel.Location = new System.Drawing.Point(237, 238);
            this.ChangeGoldLabel.Name = "ChangeGoldLabel";
            this.ChangeGoldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChangeGoldLabel.Size = new System.Drawing.Size(46, 21);
            this.ChangeGoldLabel.TabIndex = 20;
            this.ChangeGoldLabel.Text = "0000";
            this.ChangeGoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartingSilverLabel
            // 
            this.StartingSilverLabel.AutoSize = true;
            this.StartingSilverLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartingSilverLabel.Location = new System.Drawing.Point(303, 147);
            this.StartingSilverLabel.Name = "StartingSilverLabel";
            this.StartingSilverLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartingSilverLabel.Size = new System.Drawing.Size(28, 21);
            this.StartingSilverLabel.TabIndex = 21;
            this.StartingSilverLabel.Text = "00";
            this.StartingSilverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentSilverLabel
            // 
            this.CurrentSilverLabel.AutoSize = true;
            this.CurrentSilverLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentSilverLabel.Location = new System.Drawing.Point(303, 192);
            this.CurrentSilverLabel.Name = "CurrentSilverLabel";
            this.CurrentSilverLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentSilverLabel.Size = new System.Drawing.Size(28, 21);
            this.CurrentSilverLabel.TabIndex = 22;
            this.CurrentSilverLabel.Text = "00";
            this.CurrentSilverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChangeSilverLabel
            // 
            this.ChangeSilverLabel.AutoSize = true;
            this.ChangeSilverLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeSilverLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ChangeSilverLabel.Location = new System.Drawing.Point(303, 238);
            this.ChangeSilverLabel.Name = "ChangeSilverLabel";
            this.ChangeSilverLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChangeSilverLabel.Size = new System.Drawing.Size(28, 21);
            this.ChangeSilverLabel.TabIndex = 23;
            this.ChangeSilverLabel.Text = "00";
            this.ChangeSilverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentBronzeLabel
            // 
            this.CurrentBronzeLabel.AutoSize = true;
            this.CurrentBronzeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentBronzeLabel.Location = new System.Drawing.Point(357, 192);
            this.CurrentBronzeLabel.Name = "CurrentBronzeLabel";
            this.CurrentBronzeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentBronzeLabel.Size = new System.Drawing.Size(28, 21);
            this.CurrentBronzeLabel.TabIndex = 24;
            this.CurrentBronzeLabel.Text = "00";
            this.CurrentBronzeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartingBronzeLabel
            // 
            this.StartingBronzeLabel.AutoSize = true;
            this.StartingBronzeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartingBronzeLabel.Location = new System.Drawing.Point(357, 147);
            this.StartingBronzeLabel.Name = "StartingBronzeLabel";
            this.StartingBronzeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartingBronzeLabel.Size = new System.Drawing.Size(28, 21);
            this.StartingBronzeLabel.TabIndex = 25;
            this.StartingBronzeLabel.Text = "00";
            this.StartingBronzeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChangeBronzeLabel
            // 
            this.ChangeBronzeLabel.AutoSize = true;
            this.ChangeBronzeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeBronzeLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ChangeBronzeLabel.Location = new System.Drawing.Point(357, 238);
            this.ChangeBronzeLabel.Name = "ChangeBronzeLabel";
            this.ChangeBronzeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChangeBronzeLabel.Size = new System.Drawing.Size(28, 21);
            this.ChangeBronzeLabel.TabIndex = 26;
            this.ChangeBronzeLabel.Text = "00";
            this.ChangeBronzeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateTitleLabel
            // 
            this.UpdateTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateTitleLabel.Location = new System.Drawing.Point(173, 275);
            this.UpdateTitleLabel.Name = "UpdateTitleLabel";
            this.UpdateTitleLabel.Size = new System.Drawing.Size(189, 15);
            this.UpdateTitleLabel.TabIndex = 27;
            this.UpdateTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateTitleLabel.Click += new System.EventHandler(this.UpdateTitleLabel_Click);
            // 
            // APIErrorLabel
            // 
            this.APIErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.APIErrorLabel.Location = new System.Drawing.Point(27, 118);
            this.APIErrorLabel.Name = "APIErrorLabel";
            this.APIErrorLabel.Size = new System.Drawing.Size(468, 23);
            this.APIErrorLabel.TabIndex = 28;
            this.APIErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(494, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "v1.1";
            // 
            // ToggleTheme
            // 
            this.ToggleTheme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToggleTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToggleTheme.Location = new System.Drawing.Point(12, 331);
            this.ToggleTheme.Name = "ToggleTheme";
            this.ToggleTheme.Size = new System.Drawing.Size(107, 29);
            this.ToggleTheme.TabIndex = 30;
            this.ToggleTheme.Text = "Toggle Theme";
            this.ToggleTheme.UseVisualStyleBackColor = false;
            this.ToggleTheme.Click += new System.EventHandler(this.ToggleTheme_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 367);
            this.Controls.Add(this.ToggleTheme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.APIErrorLabel);
            this.Controls.Add(this.titlelabel1);
            this.Controls.Add(this.UpdateTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.APIKeyLabel);
            this.Controls.Add(this.APITextBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.APILinkLabel);
            this.Controls.Add(this.TimerButton1);
            this.Controls.Add(this.ChangeSilverLabel);
            this.Controls.Add(this.CurrentSilverLabel);
            this.Controls.Add(this.StartingSilverLabel);
            this.Controls.Add(this.ChangeGoldLabel);
            this.Controls.Add(this.CurrentGoldLabel);
            this.Controls.Add(this.StartingGoldLabel);
            this.Controls.Add(this.ChangeBronzeLabel);
            this.Controls.Add(this.StartingBronzeLabel);
            this.Controls.Add(this.CurrentBronzeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Button TimerButton;
        private Label title;
        private Label titlelabel1;
        private Button TimerButton1;
        private LinkLabel APILinkLabel;
        private Label TimeLabel;
        private System.Windows.Forms.Timer timer;
        private TextBox APITextBox;
        private Label APIKeyLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label StartingGoldLabel;
        private Label CurrentGoldLabel;
        private Label ChangeGoldLabel;
        private Label StartingSilverLabel;
        private Label CurrentSilverLabel;
        private Label ChangeSilverLabel;
        private Label CurrentBronzeLabel;
        private Label StartingBronzeLabel;
        private Label ChangeBronzeLabel;
        private Label UpdateTitleLabel;
        private Label APIErrorLabel;
        private Label label4;
        private Button ToggleTheme;
    }
}