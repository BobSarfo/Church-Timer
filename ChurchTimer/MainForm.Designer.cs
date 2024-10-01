namespace ChurchTimer
{
    partial class MainForm
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
            hoursInput = new NumericUpDown();
            minutesInput = new NumericUpDown();
            secondsInput = new NumericUpDown();
            hourslb = new Label();
            minuteslb = new Label();
            secondslb = new Label();
            messagelb = new Label();
            startBtn = new Button();
            resetBtn = new Button();
            currentTimeGrpBox = new GroupBox();
            currentTimelb = new Label();
            remainingTimeLb = new Label();
            groupBox1 = new GroupBox();
            messageTxtbox = new TextBox();
            messageBtn = new Button();
            showClockBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)hoursInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutesInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondsInput).BeginInit();
            currentTimeGrpBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // hoursInput
            // 
            hoursInput.Location = new Point(65, 121);
            hoursInput.Name = "hoursInput";
            hoursInput.Size = new Size(110, 27);
            hoursInput.TabIndex = 0;
            // 
            // minutesInput
            // 
            minutesInput.Location = new Point(199, 121);
            minutesInput.Name = "minutesInput";
            minutesInput.Size = new Size(96, 27);
            minutesInput.TabIndex = 1;
            // 
            // secondsInput
            // 
            secondsInput.Location = new Point(320, 121);
            secondsInput.Name = "secondsInput";
            secondsInput.Size = new Size(99, 27);
            secondsInput.TabIndex = 2;
            // 
            // hourslb
            // 
            hourslb.AutoSize = true;
            hourslb.Location = new Point(65, 98);
            hourslb.Name = "hourslb";
            hourslb.Size = new Size(48, 20);
            hourslb.TabIndex = 3;
            hourslb.Text = "Hours";
            // 
            // minuteslb
            // 
            minuteslb.AutoSize = true;
            minuteslb.Location = new Point(199, 98);
            minuteslb.Name = "minuteslb";
            minuteslb.Size = new Size(61, 20);
            minuteslb.TabIndex = 4;
            minuteslb.Text = "Minutes";
            // 
            // secondslb
            // 
            secondslb.AutoSize = true;
            secondslb.Location = new Point(320, 98);
            secondslb.Name = "secondslb";
            secondslb.Size = new Size(64, 20);
            secondslb.TabIndex = 5;
            secondslb.Text = "Seconds";
            // 
            // messagelb
            // 
            messagelb.AutoSize = true;
            messagelb.Location = new Point(65, 335);
            messagelb.Name = "messagelb";
            messagelb.Size = new Size(67, 20);
            messagelb.TabIndex = 7;
            messagelb.Text = "Message";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(65, 460);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(133, 52);
            startBtn.TabIndex = 8;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(214, 460);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(133, 52);
            resetBtn.TabIndex = 9;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // currentTimeGrpBox
            // 
            currentTimeGrpBox.Controls.Add(currentTimelb);
            currentTimeGrpBox.Location = new Point(486, 54);
            currentTimeGrpBox.Name = "currentTimeGrpBox";
            currentTimeGrpBox.Size = new Size(314, 135);
            currentTimeGrpBox.TabIndex = 10;
            currentTimeGrpBox.TabStop = false;
            currentTimeGrpBox.Text = "Current Time";
            // 
            // currentTimelb
            // 
            currentTimelb.AutoSize = true;
            currentTimelb.Font = new Font("Segoe UI", 32F);
            currentTimelb.Location = new Point(6, 28);
            currentTimelb.Name = "currentTimelb";
            currentTimelb.Size = new Size(228, 72);
            currentTimelb.TabIndex = 0;
            currentTimelb.Text = "00:00:00";
            // 
            // remainingTimeLb
            // 
            remainingTimeLb.AutoSize = true;
            remainingTimeLb.Font = new Font("Segoe UI", 40F);
            remainingTimeLb.Location = new Point(26, 23);
            remainingTimeLb.Name = "remainingTimeLb";
            remainingTimeLb.Size = new Size(284, 89);
            remainingTimeLb.TabIndex = 11;
            remainingTimeLb.Text = "00:00:00";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(remainingTimeLb);
            groupBox1.Location = new Point(65, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 125);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time Remaining";
            // 
            // messageTxtbox
            // 
            messageTxtbox.Location = new Point(65, 358);
            messageTxtbox.Multiline = true;
            messageTxtbox.Name = "messageTxtbox";
            messageTxtbox.Size = new Size(282, 81);
            messageTxtbox.TabIndex = 13;
            // 
            // messageBtn
            // 
            messageBtn.Location = new Point(353, 358);
            messageBtn.Name = "messageBtn";
            messageBtn.Size = new Size(66, 29);
            messageBtn.TabIndex = 14;
            messageBtn.Text = "Show";
            messageBtn.UseVisualStyleBackColor = true;
            messageBtn.Click += messageBtn_Click;
            // 
            // showClockBtn
            // 
            showClockBtn.Location = new Point(706, 195);
            showClockBtn.Name = "showClockBtn";
            showClockBtn.Size = new Size(94, 29);
            showClockBtn.TabIndex = 15;
            showClockBtn.Text = "Show Clock";
            showClockBtn.UseVisualStyleBackColor = true;
            showClockBtn.Click += showClockBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(874, 552);
            Controls.Add(showClockBtn);
            Controls.Add(messageBtn);
            Controls.Add(messageTxtbox);
            Controls.Add(groupBox1);
            Controls.Add(currentTimeGrpBox);
            Controls.Add(resetBtn);
            Controls.Add(startBtn);
            Controls.Add(messagelb);
            Controls.Add(secondslb);
            Controls.Add(minuteslb);
            Controls.Add(hourslb);
            Controls.Add(secondsInput);
            Controls.Add(minutesInput);
            Controls.Add(hoursInput);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            Text = "00:00:00";
            ((System.ComponentModel.ISupportInitialize)hoursInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutesInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondsInput).EndInit();
            currentTimeGrpBox.ResumeLayout(false);
            currentTimeGrpBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown hoursInput;
        private NumericUpDown minutesInput;
        private NumericUpDown secondsInput;
        private Label hourslb;
        private Label minuteslb;
        private Label secondslb;
        private Label messagelb;
        private Button startBtn;
        private Button resetBtn;
        private GroupBox currentTimeGrpBox;
        private Label currentTimelb;
        private Label remainingTimeLb;
        private GroupBox groupBox1;
        private TextBox messageTxtbox;
        private Button messageBtn;
        private Button showClockBtn;
    }
}
