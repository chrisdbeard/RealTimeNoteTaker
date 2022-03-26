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
    public partial class MainForm : Form
    {
        private NoteController noteController;
        private EntryForm entryForm;

        public MainForm()
        {
            InitializeComponent();
            this.noteController = new NoteController();
            this.ActiveControl = this.btnBrowse;

            // DEBUG Code
            if (Environment.UserName == "heart")
            {
                tbFileLocation.Text = @"C:\Users\heart\Documents\Programming\OutputDump\test.rtn";
                noteController.SetFilePath(@"C:\Users\heart\Documents\Programming\OutputDump\test.rtn");
            }
        }

        private void UpdateListView()
        {
            lvEntries.Items.Clear();
            foreach (Entry e in noteController.Entries)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = e.ToString();
                lvi.Tag = e;

                if (e is Section)
                {                   
                    lvi.Font = new Font(lvEntries.Font, FontStyle.Bold);
                }
                
                lvEntries.Items.Add(lvi);              
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // TODO arrow keys also move through text box.
            switch (keyData)
            {
                case Keys.Up:
                    if (nudLevel.Value < nudLevel.Maximum)
                    {
                        nudLevel.Value++;
                    }
                    break;
                case Keys.Down:
                    if (nudLevel.Value > 0)
                    {
                        nudLevel.Value--;
                    }
                    break;
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "rtn files (*.rtn)|*.rtn|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tbFileLocation.Text = sfd.FileName;
                noteController.SetFilePath(sfd.FileName);
            }
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            entryForm = new EntryForm();
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                noteController.AddSection(entryForm.returnText, (int)nudLevel.Value);
                UpdateListView();
            }            
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            entryForm = new EntryForm();
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                noteController.AddNote(DateTime.Now, entryForm.returnText, (int)nudLevel.Value);
                UpdateListView();
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (lvEntries.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in lvEntries.SelectedItems)
                {
                    noteController.PromoteEntry((Entry)lvi.Tag);
                }
            }
            
            UpdateListView();
        }

        private void btnDemote_Click(object sender, EventArgs e)
        {
            if (lvEntries.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in lvEntries.SelectedItems)
                {
                    noteController.DemoteEntry((Entry)lvi.Tag);
                }
            }
            UpdateListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvEntries.SelectedItems.Count == 1)
            {
                entryForm = new EntryForm();
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    noteController.EditEntry((Entry)lvEntries.SelectedItems[0].Tag, entryForm.returnText);
                    UpdateListView();
                }                    
            }
            else
            {
                MessageBox.Show("Invalid number of selected items. Only one entry is allowed to be edited at a time.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvEntries.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in lvEntries.SelectedItems)
                {
                    noteController.RemoveEntry((Entry)lvi.Tag);
                }
            }
            UpdateListView();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            noteController.WriteEntriesToFile();
            MessageBox.Show("Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
