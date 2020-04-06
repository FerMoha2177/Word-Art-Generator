using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace Text_Assignment_Module_7
{
    public partial class SearchDialog : Form
    {
        //Adds delegate and event to open the file on the main form
        public delegate void fileSelectedEventHandler(string path);
        public event fileSelectedEventHandler FileSelected;

        //Ferris
        //TO DO: Add Encapsulation


        //Build a list for the comboBox of Text Extensions
        List<TextExtensions> dataSource = new List<TextExtensions>();

        //Ferris

        public SearchDialog()
        {
            InitializeComponent();




            //Ferris



            //Build a list to populate teh comboBox of Text Extensions
            //var dataSource = new List<TextExtensions>();
            dataSource.Add(new TextExtensions() { Name = ".txt", Value = "TXT files" });
            dataSource.Add(new TextExtensions() { Name = ".html", Value = "HTML Files" });
            dataSource.Add(new TextExtensions() { Name = ".htm", Value = "HTM Files" });

            //Setup data binding
            this.comboBoxSearchDialog.DataSource = dataSource;
            this.comboBoxSearchDialog.DisplayMember = "Name";
            this.comboBoxSearchDialog.ValueMember = "Value";

            // make it readonly

            this.comboBoxSearchDialog.DropDownStyle = ComboBoxStyle.DropDownList;

            //Ferris

            //disabling start button if nothing is selected in combo box
            if (comboBoxSearchDialog.SelectedItem == null)
            {
                startSearchButton.Enabled = false;
            }

            this.toolStripProgressBarSearchDialog.Style = ProgressBarStyle.Marquee;
            this.toolStripProgressBarSearchDialog.MarqueeAnimationSpeed = 60;
            this.toolStripProgressBarSearchDialog.Visible = false;
        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startSearchButton_Click(object sender, EventArgs e)
        {
            fileCount = 0;
            pauseSearchButton.Enabled = true;
            stopSearchButton.Enabled = true;
            startSearchButton.Enabled = false;
            listBoxSearch.Items.Clear();

            //passing the value of that is selected in the combobox to the worker
            this.backgroundWorker.RunWorkerAsync(this.comboBoxSearchDialog.SelectedItem.ToString());
            this.toolStripProgressBarSearchDialog.Visible = true;
            this.toolStripStatusLabelSearchDialog.Text = "Searching...";
        }

        private void pauseSearchButton_Click(object sender, EventArgs e)
        {
            if (pauseSearchButton.Text.Equals("Pause"))
            {
                pauseSearchButton.Text = "Continue";
                pause = true;
                this.toolStripProgressBarSearchDialog.Visible = false;
                this.toolStripStatusLabelSearchDialog.Text = "Paused";
            }
            else
            {
                pauseSearchButton.Text = "Pause";
                pause = false;
                this.toolStripProgressBarSearchDialog.Visible = true;
                this.toolStripStatusLabelSearchDialog.Text = "Searching...";
            }

        }

        private void stopSearchButton_Click(object sender, EventArgs e)
        {
            startSearchButton.Enabled = true;
            pauseSearchButton.Enabled = false;
            stopSearchButton.Enabled = false;

            this.backgroundWorker.CancelAsync();
            this.toolStripProgressBarSearchDialog.Visible = false;
            this.toolStripStatusLabelSearchDialog.Text = "Ready";
        }



        void ShowProgress(FileInfo[] Files)
        {
            // Make sure we're on the UI thread
            Debug.Assert(this.InvokeRequired == false);

            // Display progress in UI

            //add each file found along with its path to the listbox
            foreach (FileInfo file in Files)
            {
                listBoxSearch.Items.Add(file.FullName);
            }

        }

        private bool pause = false; //worker has been paused
        private bool restart = false; //indicates that the worker must be restarted
        private string selectedItem; //item picked in the combobox
        private int fileCount; //increments everytime a file is found and the total is returned after the worker is killed 

        class SearchUserState
        {
            public readonly FileInfo[] Files;

            public SearchUserState(FileInfo[] files)
            {
                this.Files = files;
            }
        }

        
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            selectedItem = (string)e.Argument; //file extension

            Search(selectedItem);

            //testing for cancellation
            if (this.backgroundWorker != null && this.backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SearchUserState progress = (SearchUserState)e.UserState;
            ShowProgress(progress.Files); //passing data back to ui
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(restart)//starts a new worker with the updated combobox item
            {
                restart = false;
                this.backgroundWorker.RunWorkerAsync(this.comboBoxSearchDialog.SelectedItem.ToString());
                
                return; //don't want the rest of the function to execute. avoids the message.
            }
            
            if (e.Cancelled)
            {
                MessageBox.Show("Search completed. " + fileCount + " files found.");
            }
        }

        private void Search(string selectedItem)
        {
            foreach (String drive in Directory.GetLogicalDrives())
            {
                Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive))
                {
                    Debug.WriteLine(child.FullName);
                    if (this.backgroundWorker.CancellationPending) { return; }
                    FindFiles(child, selectedItem);


                }
            }
        }

        
        private void FindFiles(DirectoryInfo dir, string selectedItem)
        {
            try
            {
                if (this.backgroundWorker.CancellationPending) { return; }
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0)
                {
                    foreach (DirectoryInfo child in children)
                    {
                        Debug.WriteLine(child.FullName);
                        FindFiles(child, selectedItem);
                    }
                }
                else
                {
                    if (selectedItem == ".txt")
                    {
                        FileInfo[] Files = dir.GetFiles("*.txt");
                        if (Files.Length > 0)
                        {
                            //Found some text files.
                            //Do something
                            //Report progress
                            fileCount++;
                            SearchUserState state = new SearchUserState(Files);
                            this.backgroundWorker.ReportProgress(0, state);

                        }
                    }
                    else if (selectedItem == ".html")
                    {
                        FileInfo[] Files = dir.GetFiles("*.html");
                        if (Files.Length > 0)
                        {
                            //Found some html files.
                            //Do something
                            //Report progress
                            fileCount++;
                            SearchUserState state = new SearchUserState(Files);
                            this.backgroundWorker.ReportProgress(0, state);

                        }
                    }
                    else if (selectedItem == ".htm")
                    {
                        FileInfo[] Files = dir.GetFiles("*.htm");
                        if (Files.Length > 0)
                        {
                            //Found some htm files.
                            //Do something
                            //Report progress
                            fileCount++;
                            SearchUserState state = new SearchUserState(Files);
                            this.backgroundWorker.ReportProgress(0, state);
                        }
                    }

                    while(pause)
                    {
                        Thread.Sleep(1);

                        if (this.backgroundWorker.CancellationPending) { return; }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private bool AttrOn(FileAttributes attr, FileAttributes field)
        {
            return (attr & field) == field;
        }

        public DirectoryInfo[] getDirectories(DirectoryInfo dir)
        {
            if (AttrOn(dir.Attributes, FileAttributes.Offline))
            {
                Console.Out.WriteLine(dir.Name + " is not mapped ");
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists)
            {
                Console.Out.WriteLine(dir.Name + " does not exist ");
                return new DirectoryInfo[] { };
            }
            try
            {
                return dir.GetDirectories();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
                return new DirectoryInfo[] { };
            }
        }

        public DirectoryInfo[] getDirectories(String strDrive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            return getDirectories(dir);
        }

        private void SearchState_Click(object sender, EventArgs e)
        {

        }


        //stops search when user closes dialog
        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            this.toolStripStatusLabelSearchDialog.Text = "Ready.";
        }

        //detects a change in the combobox, kills the thread, flag for restart
        private void comboBoxSearchDialog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.backgroundWorker.IsBusy)
            {
                this.backgroundWorker.CancelAsync();
                restart = true;
            }
            
        }

        public void listBoxSearch_DoubleClick(object sender, EventArgs e)
        {
            string fileToOpen = listBoxSearch.GetItemText(listBoxSearch.SelectedItem);

            if (FileSelected != null)
            {
                FileSelected(fileToOpen);
            }
            this.backgroundWorker.CancelAsync();
            this.Close();
        }
    }
}
