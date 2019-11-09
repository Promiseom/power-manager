using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Manager
{
    public partial class PasswordInputDialog : Form
    {
        private static PasswordInputDialog dialog;

        private PasswordInputDialog()
        {
            InitializeComponent();
        }

        public static String ShowInputDialog(Form parent, string title)
        {
            dialog = new PasswordInputDialog();
            dialog.Text = title;
            if (dialog.ShowDialog(parent) == DialogResult.OK)
            {
                return dialog.txtInput.Text;
            }
            return "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }

        public static void CloseDialog()
        {
            if (dialog != null)
            {
                dialog.Close();
                dialog = null;
            }
        }
    }
}
