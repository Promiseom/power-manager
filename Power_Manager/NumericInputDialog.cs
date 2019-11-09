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
    public partial class NumericInputDialog : Form
    {
        private static NumericInputDialog dialog;

        private NumericInputDialog()
        {
            InitializeComponent();
        }

        public static int ShowInputDialog(Form parent, string title, string message)
        {
            if (dialog == null)
            {
                dialog = new NumericInputDialog();
            }            
            dialog.Text = (title.Length > 0)? title : dialog.Text;
            dialog.lbMessage.Text = message;
            if (dialog.ShowDialog(parent) == DialogResult.OK)
            {
                return (int)dialog.time.Value;
            }
            throw new DialogCancelResultException("The user cancelled the operation");
        }
    }
}
