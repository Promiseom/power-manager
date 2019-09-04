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
            this.lbBatteryStatus = new System.Windows.Forms.Label();
            this.lbBatteryPercent = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEditSettings = new System.Windows.Forms.CheckBox();
            this.labelBatteryPercent = new System.Windows.Forms.Label();
            this.labelBatteryStatus = new System.Windows.Forms.Label();
            this.tabShutdownPage = new System.Windows.Forms.TabPage();
            this.tabLogPage = new System.Windows.Forms.TabPage();
            this.batteryStatusMonitor = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabStatusPage.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // lbBatteryStatus
            // 
            this.lbBatteryStatus.AutoSize = true;
            this.lbBatteryStatus.Location = new System.Drawing.Point(85, 16);
            this.lbBatteryStatus.Name = "lbBatteryStatus";
            this.lbBatteryStatus.Size = new System.Drawing.Size(63, 13);
            this.lbBatteryStatus.TabIndex = 5;
            this.lbBatteryStatus.Text = "Discharging";
            // 
            // lbBatteryPercent
            // 
            this.lbBatteryPercent.AutoSize = true;
            this.lbBatteryPercent.Location = new System.Drawing.Point(85, 46);
            this.lbBatteryPercent.Name = "lbBatteryPercent";
            this.lbBatteryPercent.Size = new System.Drawing.Size(33, 13);
            this.lbBatteryPercent.TabIndex = 4;
            this.lbBatteryPercent.Text = "100%";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.button2);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.numericUpDown1);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.comboBox1);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Enabled = false;
            this.settingsPanel.Location = new System.Drawing.Point(6, 115);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(517, 103);
            this.settingsPanel.TabIndex = 3;
            this.settingsPanel.TabStop = false;
            this.settingsPanel.Text = "Settings";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Discard Changes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(370, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 3;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Prompt For Shutdown Action",
            "Nothing",
            "Sleep",
            "Hibernating",
            "Shutdown"});
            this.comboBox1.Location = new System.Drawing.Point(176, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 1;
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
            this.labelBatteryPercent.Location = new System.Drawing.Point(3, 46);
            this.labelBatteryPercent.Name = "labelBatteryPercent";
            this.labelBatteryPercent.Size = new System.Drawing.Size(83, 13);
            this.labelBatteryPercent.TabIndex = 1;
            this.labelBatteryPercent.Text = "Battery Percent:";
            // 
            // labelBatteryStatus
            // 
            this.labelBatteryStatus.AutoSize = true;
            this.labelBatteryStatus.Location = new System.Drawing.Point(3, 16);
            this.labelBatteryStatus.Name = "labelBatteryStatus";
            this.labelBatteryStatus.Size = new System.Drawing.Size(76, 13);
            this.labelBatteryStatus.TabIndex = 0;
            this.labelBatteryStatus.Text = "Battery Status:";
            // 
            // tabShutdownPage
            // 
            this.tabShutdownPage.Location = new System.Drawing.Point(4, 22);
            this.tabShutdownPage.Name = "tabShutdownPage";
            this.tabShutdownPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabShutdownPage.Size = new System.Drawing.Size(529, 224);
            this.tabShutdownPage.TabIndex = 1;
            this.tabShutdownPage.Text = "Shutdown";
            this.tabShutdownPage.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.Power_Manager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStatusPage.ResumeLayout(false);
            this.tabStatusPage.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbBatteryStatus;
        private System.Windows.Forms.Label lbBatteryPercent;
        private System.ComponentModel.BackgroundWorker batteryStatusMonitor;
    }
}

