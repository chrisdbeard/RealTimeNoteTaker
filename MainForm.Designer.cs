namespace RealTimeNoteTaker
{
    partial class MainForm
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
            this.pnlListView = new System.Windows.Forms.Panel();
            this.lvEntries = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDemote = new System.Windows.Forms.Button();
            this.btnPromote = new System.Windows.Forms.Button();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.pnlListView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListView
            // 
            this.pnlListView.Controls.Add(this.lvEntries);
            this.pnlListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListView.Location = new System.Drawing.Point(0, 70);
            this.pnlListView.Name = "pnlListView";
            this.pnlListView.Size = new System.Drawing.Size(518, 401);
            this.pnlListView.TabIndex = 3;
            // 
            // lvEntries
            // 
            this.lvEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvEntries.HideSelection = false;
            this.lvEntries.Location = new System.Drawing.Point(0, 0);
            this.lvEntries.Name = "lvEntries";
            this.lvEntries.Size = new System.Drawing.Size(518, 401);
            this.lvEntries.TabIndex = 0;
            this.lvEntries.UseCompatibleStateImageBehavior = false;
            this.lvEntries.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddSection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNote, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPublish, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDemote, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPromote, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudLevel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(388, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(130, 401);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnAddSection
            // 
            this.btnAddSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSection.Location = new System.Drawing.Point(3, 3);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(124, 34);
            this.btnAddSection.TabIndex = 0;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNote.Location = new System.Drawing.Point(3, 43);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(124, 34);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublish.Location = new System.Drawing.Point(3, 363);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(124, 35);
            this.btnPublish.TabIndex = 7;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(3, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDemote
            // 
            this.btnDemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDemote.Location = new System.Drawing.Point(3, 203);
            this.btnDemote.Name = "btnDemote";
            this.btnDemote.Size = new System.Drawing.Size(124, 34);
            this.btnDemote.TabIndex = 3;
            this.btnDemote.Text = "Demote";
            this.btnDemote.UseVisualStyleBackColor = true;
            this.btnDemote.Click += new System.EventHandler(this.btnDemote_Click);
            // 
            // btnPromote
            // 
            this.btnPromote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPromote.Location = new System.Drawing.Point(3, 163);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(124, 34);
            this.btnPromote.TabIndex = 2;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // nudLevel
            // 
            this.nudLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudLevel.Location = new System.Drawing.Point(3, 127);
            this.nudLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(124, 26);
            this.nudLevel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Level Indicator";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFileLocation, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnNewFile, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 70);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Location";
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbFileLocation.Location = new System.Drawing.Point(3, 38);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(382, 23);
            this.tbFileLocation.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Location = new System.Drawing.Point(391, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(124, 34);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Open File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pnlFile
            // 
            this.pnlFile.Controls.Add(this.tableLayoutPanel2);
            this.pnlFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFile.Location = new System.Drawing.Point(0, 0);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(518, 70);
            this.pnlFile.TabIndex = 2;
            // 
            // btnNewFile
            // 
            this.btnNewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewFile.Location = new System.Drawing.Point(391, 3);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(124, 24);
            this.btnNewFile.TabIndex = 3;
            this.btnNewFile.Text = "New File";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlListView);
            this.Controls.Add(this.pnlFile);
            this.Name = "MainForm";
            this.Text = "Real Time Note Taker";
            this.pnlListView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvEntries;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnDemote;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewFile;
    }
}

