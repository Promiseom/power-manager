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
    public partial class SelectionInputDialog : Form
    {
        private static SelectionInputDialog sDialog;

        public SelectionInputDialog()
        {
            InitializeComponent();
        }

        public static int ShowSelectionInputDialog(Form parent, string title, string[] items)
        {
            sDialog = new SelectionInputDialog();
            sDialog.Text = title;
            sDialog.cbAction.Items.AddRange(items);
            sDialog.cbAction.Items.RemoveAt(0);
            sDialog.cbAction.SelectedIndex = 0;

            if (sDialog.ShowDialog(parent) == DialogResult.OK)
            {
                //add one to the result since the first item in the item was removed
                return sDialog.cbAction.SelectedIndex + 1;
            }
            return -1; //nothing was selected
        }

        private void selectionInputDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public static void CloseDialog()
        {
            if (sDialog != null)
            {
                sDialog.Close();
                sDialog = null;
            }
        }
    }
}
