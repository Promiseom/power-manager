namespace Power_Manager
{
    partial class Power_Manager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStatusPage = new System.Windows.Forms.TabPage();
            this.lbPowerLineStatus = new System.Windows.Forms.Label();
            this.labelPowerLine = new System.Windows.Forms.Label();
            this.lbBatteryStatus = new System.Windows.Forms.Label();
            this.lbBatteryPercent = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.GroupBox();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shutdownTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShutdownAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEditSettings = new System.Windows.Forms.CheckBox();
            this.labelBatteryPercent = new System.Windows.Forms.Label();
            this.labelBatteryStatus = new System.Windows.Forms.Label();
            this.tabShutdownPage = new System.Windows.Forms.TabPage();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnAutoShutdown = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shutdownMessage = new System.Windows.Forms.RichTextBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.shutdownPassword = new System.Windows.Forms.TextBox();
            this.autoShutdownTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutoShutdownAction = new System.Windows.Forms.ComboBox();
            this.tabLogPage = new System.Windows.Forms.TabPage();
            this.batteryStatusMonitor = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabStatusPage.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownTime)).BeginInit();
            this.tabShutdownPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoShutdownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStatusPage);
            this.tabControl1.Controls.Add(this.tabShutdownPage);
            this.tabControl1.Controls.Add(this.tabLogPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 250);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStatusPage
            // 
            this.tabStatusPage.Controls.Add(this.lbPowerLineStatus);
            this.tabStatusPage.Controls.Add(this.labelPowerLine);
            this.tabStatusPage.Controls.Add(this.lbBatteryStatus);
            this.tabStatusPage.Controls.Add(this.lbBatteryPercent);
            this.tabStatusPage.Controls.Add(this.settingsPanel);
            this.tabStatusPage.Controls.Add(this.cbEditSettings);
            this.tabStatusPage.Controls.Add(this.labelBatteryPercent);
            this.tabStatusPage.Controls.Add(this.labelBatteryStatus);
            this.tabStatusPage.Location = new System.Drawing.Point(4, 22);
            this.tabStatusPage.Name = "tabStatusPage";
            this.tabStatusPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusPage.Size = new System.Drawing.Size(529, 224);
            this.tabStatusPage.TabIndex = 0;
            this.tabStatusPage.Text = "Battery Status";
            this.tabStatusPage.UseVisualStyleBackColor = true;
            // 
            // lbPowerLineStatus
            // 
            this.lbPowerLineStatus.AutoSize = true;
            this.lbPowerLineStatus.Location = new System.Drawing.Point(87, 20);
            this.lbPowerLineStatus.Name = "lbPowerLineStatus";
            this.lbPowerLineStatus.Size = new System.Drawing.Size(37, 13);
            this.lbPowerLineStatus.TabIndex = 7;
            this.lbPowerLineStatus.Text = "Online";
            // 
            // labelPowerLine
            // 
            this.labelPowerLine.AutoSize = true;
            this.labelPowerLine.Location = new System.Drawing.Point(6, 20);
            this.labelPowerLine.Name = "labelPowerLine";
            this.labelPowerLine.Size = new System.Drawing.Size(80, 13);
            this.labelPowerLine.TabIndex = 6;
            this.labelPowerLine.Text = "Adapter Status:";
            // 
            // lbBatteryStatus
            // 
            this.lbBatteryStatus.AutoSize = true;
            this.lbBatteryStatus.Location = new System.Drawing.Point(87, 33);
            this.lbBatteryStatus.Name = "lbBatteryStatus";
            this.lbBatteryStatus.Size = new System.Drawing.Size(63, 13);
            this.lbBatteryStatus.TabIndex = 5;
            this.lbBatteryStatus.Text = "Discharging";
            // 
            // lbBatteryPercent
            // 
            this.lbBatteryPercent.AutoSize = true;
            this.lbBatteryPercent.Location = new System.Drawing.Point(87, 46);
            this.lbBatteryPercent.Name = "lbBatteryPercent";
            this.lbBatteryPercent.Size = new System.Drawing.Size(33, 13);
            this.lbBatteryPercent.TabIndex = 4;
            this.lbBatteryPercent.Text = "100%";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.btnDiscardChanges);
            this.settingsPanel.Controls.Add(this.btnSaveChanges);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.shutdownTime);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.cbShutdownAction);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Enabled = false;
            this.settingsPanel.Location = new System.Drawing.Point(6, 115);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(517, 103);
            this.settingsPanel.TabIndex = 3;
            this.settingsPanel.TabStop = false;
            this.settingsPanel.Text = "Auto Shutdown";
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.Location = new System.Drawing.Point(259, 63);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(114, 23);
            this.btnDiscardChanges.TabIndex = 6;
            this.btnDiscardChanges.Text = "Discard Changes";
            this.btnDiscardChanges.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(127, 63);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(114, 23);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seconds";
            // 
            // shutdownTime
            // 
            this.shutdownTime.Location = new System.Drawing.Point(370, 20);
            this.shutdownTime.Name = "shutdownTime";
            this.shutdownTime.Size = new System.Drawing.Size(72, 20);
            this.shutdownTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "After";
            // 
            // cbShutdownAction
            // 
            this.cbShutdownAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShutdownAction.FormattingEnabled = true;
            this.cbShutdownAction.Items.AddRange(new object[] {
            "Prompt For Action",
            "Nothing",
            "Sleep",
            "Hibernating",
            "Shutdown"});
            this.cbShutdownAction.Location = new System.Drawing.Point(176, 19);
            this.cbShutdownAction.Name = "cbShutdownAction";
            this.cbShutdownAction.Size = new System.Drawing.Size(150, 21);
            this.cbShutdownAction.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "When AC Power Is Unplugged";
            // 
            // cbEditSettings
            // 
            this.cbEditSettings.AutoSize = true;
            this.cbEditSettings.Location = new System.Drawing.Point(6, 76);
            this.cbEditSettings.Name = "cbEditSettings";
            this.cbEditSettings.Size = new System.Drawing.Size(144, 17);
            this.cbEditSettings.TabIndex = 2;
            this.cbEditSettings.Text = "Edit Unavailable Settings";
            this.cbEditSettings.UseVisualStyleBackColor = true;
            this.cbEditSettings.CheckedChanged += new System.EventHandler(this.cbEditSettings_CheckedChanged);
            // 
            // labelBatteryPercent
            // 
            this.labelBatteryPercent.AutoSize = true;
            this.labelBatteryPercent.Location = new System.Drawing.Point(6, 46);
            this.labelBatteryPercent.Name = "labelBatteryPercent";
            this.labelBatteryPercent.Size = new System.Drawing.Size(83, 13);
            this.labelBatteryPercent.TabIndex = 1;
            this.labelBatteryPercent.Text = "Battery Percent:";
            // 
            // labelBatteryStatus
            // 
            this.labelBatteryStatus.AutoSize = true;
            this.labelBatteryStatus.Location = new System.Drawing.Point(5, 33);
            this.labelBatteryStatus.Name = "labelBatteryStatus";
            this.labelBatteryStatus.Size = new System.Drawing.Size(76, 13);
            this.labelBatteryStatus.TabIndex = 0;
            this.labelBatteryStatus.Text = "Battery Status:";
            // 
            // tabShutdownPage
            // 
            this.tabShutdownPage.Controls.Add(this.btnShutdown);
            this.tabShutdownPage.Controls.Add(this.btnAutoShutdown);
            this.tabShutdownPage.Controls.Add(this.label8);
            this.tabShutdownPage.Controls.Add(this.label7);
            this.tabShutdownPage.Controls.Add(this.label6);
            this.tabShutdownPage.Controls.Add(this.label5);
            this.tabShutdownPage.Controls.Add(this.shutdownMessage);
            this.tabShutdownPage.Controls.Add(this.cbShowPassword);
            this.tabShutdownPage.Controls.Add(this.shutdownPassword);
            this.tabShutdownPage.Controls.Add(this.autoShutdownTime);
            this.tabShutdownPage.Controls.Add(this.label4);
            this.tabShutdownPage.Controls.Add(this.cbAutoShutdownAction);
            this.tabShutdownPage.Location = new System.Drawing.Point(4, 22);
            this.tabShutdownPage.Name = "tabShutdownPage";
            this.tabShutdownPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabShutdownPage.Size = new System.Drawing.Size(529, 224);
            this.tabShutdownPage.TabIndex = 1;
            this.tabShutdownPage.Text = "Shutdown";
            this.tabShutdownPage.UseVisualStyleBackColor = true;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(304, 177);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(108, 23);
            this.btnShutdown.TabIndex = 11;
            this.btnShutdown.Text = "Shutdown Now";
            this.btnShutdown.UseVisualStyleBackColor = true;
            // 
            // btnAutoShutdown
            // 
            this.btnAutoShutdown.Location = new System.Drawing.Point(170, 177);
            this.btnAutoShutdown.Name = "btnAutoShutdown";
            this.btnAutoShutdown.Size = new System.Drawing.Size(108, 23);
            this.btnAutoShutdown.TabIndex = 10;
            this.btnAutoShutdown.Text = "Auto Shutdown";
            this.btnAutoShutdown.UseVisualStyleBackColor = true;
            this.btnAutoShutdown.Click += new System.EventHandler(this.btnAutoShutdown_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Shutdown Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Shutdown Message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time:";
            // 
            // shutdownMessage
            // 
            this.shutdownMessage.Location = new System.Drawing.Point(129, 97);
            this.shutdownMessage.Name = "shutdownMessage";
            this.shutdownMessage.Size = new System.Drawing.Size(364, 60);
            this.shutdownMessage.TabIndex = 5;
            this.shutdownMessage.Text = "";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(129, 74);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cbShowPassword.TabIndex = 4;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // shutdownPassword
            // 
            this.shutdownPassword.Location = new System.Drawing.Point(129, 48);
            this.shutdownPassword.Name = "shutdownPassword";
            this.shutdownPassword.Size = new System.Drawing.Size(364, 20);
            this.shutdownPassword.TabIndex = 3;
            this.shutdownPassword.UseSystemPasswordChar = true;
            // 
            // autoShutdownTime
            // 
            this.autoShutdownTime.Location = new System.Drawing.Point(321, 22);
            this.autoShutdownTime.Name = "autoShutdownTime";
            this.autoShutdownTime.Size = new System.Drawing.Size(117, 20);
            this.autoShutdownTime.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Shutdown Action:";
            // 
            // cbAutoShutdownAction
            // 
            this.cbAutoShutdownAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoShutdownAction.FormattingEnabled = true;
            this.cbAutoShutdownAction.Location = new System.Drawing.Point(129, 19);
            this.cbAutoShutdownAction.Name = "cbAutoShutdownAction";
            this.cbAutoShutdownAction.Size = new System.Drawing.Size(147, 21);
            this.cbAutoShutdownAction.TabIndex = 0;
            // 
            // tabLogPage
            // 
            this.tabLogPage.Location = new System.Drawing.Point(4, 22);
            this.tabLogPage.Name = "tabLogPage";
            this.tabLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogPage.Size = new System.Drawing.Size(529, 224);
            this.tabLogPage.TabIndex = 2;
            this.tabLogPage.Text = "Log";
            this.tabLogPage.UseVisualStyleBackColor = true;
            // 
            // batteryStatusMonitor
            // 
            this.batteryStatusMonitor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.batteryStatusMonitor_DoWork);
            this.batteryStatusMonitor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.batteryStatusMonitor_ProgressChanged);
            // 
            // Power_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 274);
            this.Controls.Add(this.tabControl1);
            this.Name = "Power_Manager";
            this.Text = "Windows Power Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Power_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Power_Manager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStatusPage.ResumeLayout(false);
            this.tabStatusPage.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownTime)).EndInit();
            this.tabShutdownPage.ResumeLayout(false);
            this.tabShutdownPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoShutdownTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStatusPage;
        private System.Windows.Forms.TabPage tabShutdownPage;
        private System.Windows.Forms.TabPage tabLogPage;
        private System.Windows.Forms.Label labelBatteryStatus;
        private System.Windows.Forms.GroupBox settingsPanel;
        private System.Windows.Forms.CheckBox cbEditSettings;
        private System.Windows.Forms.Label labelBatteryPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown shutdownTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShutdownAction;
        private System.Windows.Forms.Button btnDiscardChanges;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lbBatteryStatus;
        private System.Windows.Forms.Label lbBatteryPercent;
        private System.ComponentModel.BackgroundWorker batteryStatusMonitor;
        private System.Windows.Forms.RichTextBox shutdownMessage;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.TextBox shutdownPassword;
        private System.Windows.Forms.NumericUpDown autoShutdownTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAutoShutdownAction;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnAutoShutdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPowerLineStatus;
        private System.Windows.Forms.Label labelPowerLine;
    }
}

