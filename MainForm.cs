using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        /// <summary>
        /// Clears the listview and populates it again with the selected texted added, edited or deleted.
        /// Controls what you see on the GUI's listview.
        /// </summary>
        private void UpdateListView()
        {
            lvEntries.Items.Clear();
            ColumnHeader header = new ColumnHeader();
            lvEntries.HeaderStyle = ColumnHeaderStyle.None;
            lvEntries.Columns.Add(header);
            lvEntries.View = View.Details;

            foreach (Entry e in noteController.Entries)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = e.ToString();
                lvi.Tag = e;                
                lvEntries.Items.Add(lvi);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Allows the use of the UP and DOWN keys to modify which level you would like to select.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Allows you to create a new file and select the location you wish to save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewFile_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Opens directory and allows you to select and open an existing file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "rtn files (*.rtn)|*.rtn|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbFileLocation.Text = ofd.FileName;
                    noteController.SetFilePath(ofd.FileName);
                    noteController.ReadFile(ofd.FileName);
                    UpdateListView();
                }
            }
        }

        /// <summary>
        /// Opens the EntryForm to add a Section to your file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            entryForm = new EntryForm();
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                noteController.AddSection(entryForm.returnText, (int)nudLevel.Value);
                UpdateListView();
            }            
        }

        /// <summary>
        /// Opens the EntryForm to add a Note to your file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            entryForm = new EntryForm();
            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                noteController.AddNote(DateTime.Now, entryForm.returnText, (int)nudLevel.Value);
                UpdateListView();
            }
        }

        /// <summary>
        /// Promotes the selected Entry up one level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Demotes selected Entry down one level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Allows the selected Entry to be edited.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvEntries.SelectedItems.Count == 1)
            {
                entryForm = new EntryForm();
                entryForm.tbUserInput.Text = lvEntries.SelectedItems[0].Text;
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

        /// <summary>
        /// Removes selected Entry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Saves current Entries to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPublish_Click(object sender, EventArgs e)
        {
            noteController.WriteEntriesToFile();
            MessageBox.Show("Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// RightClick menu item to promote selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPromote_Click(object sender, EventArgs e)
        {
            btnPromote_Click(sender, e);
        }

        /// <summary>
        /// RightClick menu item to demote selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDemote_Click(object sender, EventArgs e)
        {
            btnDemote_Click(sender, e);
        }

        /// <summary>
        /// RightClick menu item to edit selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        /// <summary>
        /// RightClick menu item to delete selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }
    }
}
