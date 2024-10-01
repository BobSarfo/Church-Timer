namespace ChurchTimer
{
    partial class ExtendedDisplay
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
            countdownLb = new Label();
            messageLb = new Label();
            SuspendLayout();
            // 
            // countdownLb
            // 
            countdownLb.AutoSize = true;
            countdownLb.Font = new Font("Segoe UI", 55F);
            countdownLb.Location = new Point(147, 149);
            countdownLb.Name = "countdownLb";
            countdownLb.Size = new Size(392, 123);
            countdownLb.TabIndex = 0;
            countdownLb.Text = "00:00:00";
            // 
            // messageLb
            // 
            messageLb.AutoSize = true;
            messageLb.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLb.Location = new Point(185, 322);
            messageLb.Name = "messageLb";
            messageLb.Size = new Size(0, 100);
            messageLb.TabIndex = 1;
            // 
            // ExtendedDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 434);
            Controls.Add(messageLb);
            Controls.Add(countdownLb);
            Name = "ExtendedDisplay";
            Text = "ExtendedDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label countdownLb;
        private Label messageLb;
    }
}