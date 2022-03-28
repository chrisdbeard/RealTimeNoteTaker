using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealTimeNoteTaker
{
    public partial class EntryForm : Form
    {
        public string returnText;

        public EntryForm()
        {
            InitializeComponent();
            this.AcceptButton = this.btnSubmit;
            this.CancelButton = this.btnCancel;
            this.ActiveControl = this.tbUserInput;
        }

        /// <summary>
        /// Saves current text in the textbox to a property returnText of this class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;           
            returnText = tbUserInput.Text;
            this.Close();
        }

        /// <summary>
        /// Clears and closes the EntryForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
