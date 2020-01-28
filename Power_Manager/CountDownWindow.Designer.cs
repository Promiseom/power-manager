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
            this.components = new System.ComponentModel.Container();
            this.cd_timer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abortShutdown = new System.Windows.Forms.Button();
            this.shutdownMessage = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuite = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cd_timer
            // 
            this.cd_timer.AutoSize = true;
            this.cd_timer.BackColor = System.Drawing.SystemColors.Control;
            this.cd_timer.Font = new System.Drawing.Font("Courier New", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_timer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cd_timer.Location = new System.Drawing.Point(12, 33);
            this.cd_timer.Name = "cd_timer";
            this.cd_timer.Size = new System.Drawing.Size(350, 71);
            this.cd_timer.TabIndex = 0;
            this.cd_timer.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer";
            // 
            // abortShutdown
            // 
            this.abortShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abortShutdown.Location = new System.Drawing.Point(82, 107);
            this.abortShutdown.Name = "abortShutdown";
            this.abortShutdown.Size = new System.Drawing.Size(42, 38);
            this.abortShutdown.TabIndex = 4;
            this.abortShutdown.Text = "0";
            this.abortShutdown.UseVisualStyleBackColor = true;
            this.abortShutdown.Visible = false;
            this.abortShutdown.Click += new System.EventHandler(this.btnAbortShutdown_Click);
            // 
            // shutdownMessage
            // 
            this.shutdownMessage.BackColor = System.Drawing.SystemColors.Control;
            this.shutdownMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shutdownMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shutdownMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownMessage.Location = new System.Drawing.Point(12, 186);
            this.shutdownMessage.MaximumSize = new System.Drawing.Size(353, 84);
            this.shutdownMessage.Name = "shutdownMessage";
            this.shutdownMessage.ReadOnly = true;
            this.shutdownMessage.Size = new System.Drawing.Size(353, 84);
            this.shutdownMessage.TabIndex = 3;
            this.shutdownMessage.Text = "No Message...";
            // 
            // btnQuite
            // 
            this.btnQuite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuite.Location = new System.Drawing.Point(230, 124);
            this.btnQuite.Name = "btnQuite";
            this.btnQuite.Size = new System.Drawing.Size(42, 38);
            this.btnQuite.TabIndex = 6;
            this.btnQuite.Text = "0";
            this.btnQuite.UseVisualStyleBackColor = true;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.ForeColor = System.Drawing.Color.Transparent;
            this.btnMore.Image = global::Power_Manager.Properties.Resources.arrow2;
            this.btnMore.Location = new System.Drawing.Point(164, 107);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(40, 38);
            this.btnMore.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnMore, "Click to display the shutdown message.");
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // CountDownWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abortShutdown;
            this.ClientSize = new System.Drawing.Size(374, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.shutdownMessage);
            this.Controls.Add(this.abortShutdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cd_timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(390, 327);
            this.MinimumSize = new System.Drawing.Size(390, 196);
            this.Name = "CountDownWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Countdown Window";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountDownWindow_FormClosing);
            this.Resize += new System.EventHandler(this.CountDownWindow_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cd_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button abortShutdown;
        private System.Windows.Forms.RichTextBox shutdownMessage;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnQuite;
        private System.Windows.Forms.Label label1;
    }
}