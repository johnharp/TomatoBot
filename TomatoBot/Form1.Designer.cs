namespace TomatoBot
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
            this.StartStopButton = new System.Windows.Forms.Button();
            this.sendSerialCommandCheckbox = new System.Windows.Forms.CheckBox();
            this.setChatStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(13, 126);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 0;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // sendSerialCommandCheckbox
            // 
            this.sendSerialCommandCheckbox.AutoSize = true;
            this.sendSerialCommandCheckbox.Checked = true;
            this.sendSerialCommandCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendSerialCommandCheckbox.Location = new System.Drawing.Point(13, 71);
            this.sendSerialCommandCheckbox.Name = "sendSerialCommandCheckbox";
            this.sendSerialCommandCheckbox.Size = new System.Drawing.Size(206, 19);
            this.sendSerialCommandCheckbox.TabIndex = 1;
            this.sendSerialCommandCheckbox.Text = "Send Status to Arduino LOL Shield";
            this.sendSerialCommandCheckbox.UseVisualStyleBackColor = true;
            // 
            // setChatStatusCheckbox
            // 
            this.setChatStatusCheckbox.AutoSize = true;
            this.setChatStatusCheckbox.Checked = true;
            this.setChatStatusCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setChatStatusCheckbox.Location = new System.Drawing.Point(13, 46);
            this.setChatStatusCheckbox.Name = "setChatStatusCheckbox";
            this.setChatStatusCheckbox.Size = new System.Drawing.Size(189, 19);
            this.setChatStatusCheckbox.TabIndex = 2;
            this.setChatStatusCheckbox.Text = "Update Microsoft Teams Status";
            this.setChatStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(95, 126);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentStateLabel.Location = new System.Drawing.Point(13, 13);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(250, 26);
            this.currentStateLabel.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TomatoBot";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.currentStateLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.setChatStatusCheckbox);
            this.Controls.Add(this.sendSerialCommandCheckbox);
            this.Controls.Add(this.StartStopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TomatoBot";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.CheckBox sendSerialCommandCheckbox;
        private System.Windows.Forms.CheckBox setChatStatusCheckbox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label currentStateLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

