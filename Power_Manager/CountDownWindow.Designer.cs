namespace Power_Manager
{
    partial class CountDownWindow
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
            this.cd_timer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abortShutdown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shutdownMessage = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cd_timer
            // 
            this.cd_timer.AutoSize = true;
            this.cd_timer.BackColor = System.Drawing.SystemColors.Control;
            this.cd_timer.Font = new System.Drawing.Font("Courier New", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_timer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cd_timer.Location = new System.Drawing.Point(12, 33);
            this.cd_timer.Name = "cd_timer";
            this.cd_timer.Size = new System.Drawing.Size(353, 76);
            this.cd_timer.TabIndex = 0;
            this.cd_timer.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer";
            // 
            // abortShutdown
            // 
            this.abortShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abortShutdown.Location = new System.Drawing.Point(134, 226);
            this.abortShutdown.Name = "abortShutdown";
            this.abortShutdown.Size = new System.Drawing.Size(111, 23);
            this.abortShutdown.TabIndex = 4;
            this.abortShutdown.Text = "Abort Shutdown";
            this.abortShutdown.UseVisualStyleBackColor = true;
            this.abortShutdown.Click += new System.EventHandler(this.btnAbortShutdown_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.shutdownMessage);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 100);
            this.panel1.TabIndex = 5;
            // 
            // shutdownMessage
            // 
            this.shutdownMessage.BackColor = System.Drawing.SystemColors.Control;
            this.shutdownMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shutdownMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shutdownMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shutdownMessage.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownMessage.Location = new System.Drawing.Point(0, 0);
            this.shutdownMessage.Name = "shutdownMessage";
            this.shutdownMessage.ReadOnly = true;
            this.shutdownMessage.Size = new System.Drawing.Size(353, 98);
            this.shutdownMessage.TabIndex = 3;
            this.shutdownMessage.Text = " No Message...";
            // 
            // CountDownWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abortShutdown;
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.abortShutdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cd_timer);
            this.MaximumSize = new System.Drawing.Size(392, 301);
            this.MinimumSize = new System.Drawing.Size(392, 301);
            this.Name = "CountDownWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shutdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountDownWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cd_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button abortShutdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox shutdownMessage;
    }
}