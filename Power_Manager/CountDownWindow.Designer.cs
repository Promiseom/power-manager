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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.cd_timer.Location = new System.Drawing.Point(14, 50);
            this.cd_timer.Name = "cd_timer";
            this.cd_timer.Size = new System.Drawing.Size(353, 76);
            this.cd_timer.TabIndex = 0;
            this.cd_timer.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Full Message";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Abort Shutdown";
            this.button2.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cd_timer);
            this.Name = "CountDownWindow";
            this.Text = "Shutdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountDownWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cd_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox shutdownMessage;
    }
}