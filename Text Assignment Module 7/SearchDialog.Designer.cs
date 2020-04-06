namespace Text_Assignment_Module_7
{
    partial class SearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog));
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.startSearchButton = new System.Windows.Forms.Button();
            this.pauseSearchButton = new System.Windows.Forms.Button();
            this.stopSearchButton = new System.Windows.Forms.Button();
            this.statusStripSearchDialog = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSearchDialog = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarSearchDialog = new System.Windows.Forms.ToolStripProgressBar();
            this.helpProviderStartButton = new System.Windows.Forms.HelpProvider();
            this.helpProviderPauseButton = new System.Windows.Forms.HelpProvider();
            this.helpProviderStopButton = new System.Windows.Forms.HelpProvider();
            this.comboBoxSearchDialog = new System.Windows.Forms.ComboBox();
            this.helpProviderComboBox = new System.Windows.Forms.HelpProvider();
            this.toolTipStartButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPauseButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStopButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipComboBox = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStripSearchDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(7, 8);
            this.listBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(558, 238);
            this.listBoxSearch.TabIndex = 0;
            this.listBoxSearch.DoubleClick += new System.EventHandler(this.listBoxSearch_DoubleClick);
            // 
            // startSearchButton
            // 
            this.startSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProviderStartButton.SetHelpKeyword(this.startSearchButton, "");
            this.helpProviderStartButton.SetHelpString(this.startSearchButton, "Click to start a new search");
            this.startSearchButton.Location = new System.Drawing.Point(413, 250);
            this.startSearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startSearchButton.Name = "startSearchButton";
            this.helpProviderStartButton.SetShowHelp(this.startSearchButton, true);
            this.startSearchButton.Size = new System.Drawing.Size(58, 19);
            this.startSearchButton.TabIndex = 1;
            this.startSearchButton.Text = "Start";
            this.toolTipStartButton.SetToolTip(this.startSearchButton, "Start search");
            this.startSearchButton.UseVisualStyleBackColor = true;
            this.startSearchButton.Click += new System.EventHandler(this.startSearchButton_Click);
            // 
            // pauseSearchButton
            // 
            this.pauseSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseSearchButton.Enabled = false;
            this.helpProviderPauseButton.SetHelpString(this.pauseSearchButton, "Click to pause the current search process");
            this.pauseSearchButton.Location = new System.Drawing.Point(413, 274);
            this.pauseSearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pauseSearchButton.Name = "pauseSearchButton";
            this.helpProviderPauseButton.SetShowHelp(this.pauseSearchButton, true);
            this.pauseSearchButton.Size = new System.Drawing.Size(58, 21);
            this.pauseSearchButton.TabIndex = 2;
            this.pauseSearchButton.Text = "Pause";
            this.toolTipPauseButton.SetToolTip(this.pauseSearchButton, "Pause search");
            this.pauseSearchButton.UseVisualStyleBackColor = true;
            this.pauseSearchButton.Click += new System.EventHandler(this.pauseSearchButton_Click);
            // 
            // stopSearchButton
            // 
            this.stopSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopSearchButton.Enabled = false;
            this.helpProviderStopButton.SetHelpString(this.stopSearchButton, "Click to stop the current search process.");
            this.stopSearchButton.Location = new System.Drawing.Point(413, 297);
            this.stopSearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stopSearchButton.Name = "stopSearchButton";
            this.helpProviderStopButton.SetShowHelp(this.stopSearchButton, true);
            this.stopSearchButton.Size = new System.Drawing.Size(58, 21);
            this.stopSearchButton.TabIndex = 3;
            this.stopSearchButton.Text = "Stop";
            this.toolTipStopButton.SetToolTip(this.stopSearchButton, "Stop search");
            this.stopSearchButton.UseVisualStyleBackColor = true;
            this.stopSearchButton.Click += new System.EventHandler(this.stopSearchButton_Click);
            // 
            // statusStripSearchDialog
            // 
            this.statusStripSearchDialog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripSearchDialog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSearchDialog,
            this.toolStripProgressBarSearchDialog});
            this.statusStripSearchDialog.Location = new System.Drawing.Point(0, 356);
            this.statusStripSearchDialog.Name = "statusStripSearchDialog";
            this.statusStripSearchDialog.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStripSearchDialog.Size = new System.Drawing.Size(575, 23);
            this.statusStripSearchDialog.TabIndex = 4;
            // 
            // toolStripStatusLabelSearchDialog
            // 
            this.toolStripStatusLabelSearchDialog.Name = "toolStripStatusLabelSearchDialog";
            this.toolStripStatusLabelSearchDialog.Size = new System.Drawing.Size(39, 18);
            this.toolStripStatusLabelSearchDialog.Text = "Ready";
            // 
            // toolStripProgressBarSearchDialog
            // 
            this.toolStripProgressBarSearchDialog.Name = "toolStripProgressBarSearchDialog";
            this.toolStripProgressBarSearchDialog.Size = new System.Drawing.Size(75, 17);
            this.toolStripProgressBarSearchDialog.Step = 100;
            // 
            // comboBoxSearchDialog
            // 
            this.comboBoxSearchDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchDialog.FormattingEnabled = true;
            this.helpProviderComboBox.SetHelpString(this.comboBoxSearchDialog, "Click and choose a file extension to filter results");
            this.comboBoxSearchDialog.Items.AddRange(new object[] {
            ".html",
            ".txt",
            ".htm"});
            this.comboBoxSearchDialog.Location = new System.Drawing.Point(475, 250);
            this.comboBoxSearchDialog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxSearchDialog.Name = "comboBoxSearchDialog";
            this.helpProviderComboBox.SetShowHelp(this.comboBoxSearchDialog, true);
            this.comboBoxSearchDialog.Size = new System.Drawing.Size(90, 21);
            this.comboBoxSearchDialog.TabIndex = 5;
            this.toolTipComboBox.SetToolTip(this.comboBoxSearchDialog, "Select extension");
            this.comboBoxSearchDialog.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchDialog_SelectedIndexChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 379);
            this.Controls.Add(this.comboBoxSearchDialog);
            this.Controls.Add(this.statusStripSearchDialog);
            this.Controls.Add(this.stopSearchButton);
            this.Controls.Add(this.pauseSearchButton);
            this.Controls.Add(this.startSearchButton);
            this.Controls.Add(this.listBoxSearch);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchDialog";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDialog_FormClosing);
            this.statusStripSearchDialog.ResumeLayout(false);
            this.statusStripSearchDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button startSearchButton;
        private System.Windows.Forms.Button pauseSearchButton;
        private System.Windows.Forms.Button stopSearchButton;
        private System.Windows.Forms.StatusStrip statusStripSearchDialog;
        private System.Windows.Forms.HelpProvider helpProviderStartButton;
        private System.Windows.Forms.HelpProvider helpProviderPauseButton;
        private System.Windows.Forms.HelpProvider helpProviderStopButton;
        private System.Windows.Forms.ComboBox comboBoxSearchDialog;
        private System.Windows.Forms.HelpProvider helpProviderComboBox;
        private System.Windows.Forms.ToolTip toolTipStartButton;
        private System.Windows.Forms.ToolTip toolTipPauseButton;
        private System.Windows.Forms.ToolTip toolTipStopButton;
        private System.Windows.Forms.ToolTip toolTipComboBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSearchDialog;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarSearchDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}