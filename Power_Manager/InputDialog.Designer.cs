namespace Power_Manager
{
    partial class InputDialog
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(292, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.UseSystemPasswordChar = true;
            this.txtInput.WordWrap = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(67, 75);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(13, 50);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(80, 17);
            this.cbShowPassword.TabIndex = 3;
            this.cbShowPassword.Text = "Show Input";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // InputDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(316, 110);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtInput);
            this.MinimumSize = new System.Drawing.Size(332, 134);
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}