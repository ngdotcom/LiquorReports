namespace LiquorReports
{
    partial class LiquorReport
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
            this.startTimeText = new System.Windows.Forms.TextBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.createEndDate = new System.Windows.Forms.TextBox();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTimeText
            // 
            this.startTimeText.Location = new System.Drawing.Point(143, 81);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(210, 22);
            this.startTimeText.TabIndex = 0;
            this.startTimeText.Text = "2018-04-17 18:25:07.993";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(46, 84);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(73, 17);
            this.startTimeLabel.TabIndex = 1;
            this.startTimeLabel.Text = "Start Time";
            this.startTimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createEndDate
            // 
            this.createEndDate.Location = new System.Drawing.Point(143, 137);
            this.createEndDate.Name = "createEndDate";
            this.createEndDate.Size = new System.Drawing.Size(210, 22);
            this.createEndDate.TabIndex = 2;
            this.createEndDate.Text = "2018-04-17 18:25:07.993";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(49, 141);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(68, 17);
            this.endTimeLabel.TabIndex = 3;
            this.endTimeLabel.Text = "End Time";
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(153, 185);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(114, 32);
            this.reportBtn.TabIndex = 4;
            this.reportBtn.Text = "Run Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // LiquorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 330);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.createEndDate);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.startTimeText);
            this.Name = "LiquorReport";
            this.Text = "Liquor Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startTimeText;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.TextBox createEndDate;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Button reportBtn;
    }
}

