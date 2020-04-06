namespace Assignment3_Library
{
    partial class Base
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
            this.baseMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seondBaseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseMenuStrip.SuspendLayout();
            this.seondBaseMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseMenuStrip
            // 
            this.baseMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.baseMenuStrip.Name = "contextMenuStrip1";
            this.baseMenuStrip.Size = new System.Drawing.Size(136, 48);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem1});
            this.preferencesToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem1.Text = "Preferences";
            // 
            // colorsToolStripMenuItem1
            // 
            this.colorsToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.colorsToolStripMenuItem1.MergeIndex = 1;
            this.colorsToolStripMenuItem1.Name = "colorsToolStripMenuItem1";
            this.colorsToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.colorsToolStripMenuItem1.Text = "Colors";
            this.colorsToolStripMenuItem1.Click += new System.EventHandler(this.colorsToolStripMenuItem1_Click);
            // 
            // seondBaseMenuStrip
            // 
            this.seondBaseMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.seondBaseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem1,
            this.fileToolStripMenuItem1});
            this.seondBaseMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.seondBaseMenuStrip.Name = "seondBaseMenuStrip";
            this.seondBaseMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.seondBaseMenuStrip.Size = new System.Drawing.Size(706, 24);
            this.seondBaseMenuStrip.Stretch = false;
            this.seondBaseMenuStrip.TabIndex = 1;
            this.seondBaseMenuStrip.Text = "menuStrip1";
            this.seondBaseMenuStrip.Visible = false;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeChildToolStripMenuItem});
            this.fileToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // closeChildToolStripMenuItem
            // 
            this.closeChildToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.closeChildToolStripMenuItem.MergeIndex = 1;
            this.closeChildToolStripMenuItem.Name = "closeChildToolStripMenuItem";
            this.closeChildToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeChildToolStripMenuItem.Text = "Close Child";
            this.closeChildToolStripMenuItem.Click += new System.EventHandler(this.closeChildToolStripMenuItem_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 385);
            this.ContextMenuStrip = this.baseMenuStrip;
            this.Controls.Add(this.seondBaseMenuStrip);
            this.MainMenuStrip = this.seondBaseMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Base";
            this.Text = "Base";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseUp);
            this.baseMenuStrip.ResumeLayout(false);
            this.seondBaseMenuStrip.ResumeLayout(false);
            this.seondBaseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip baseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip seondBaseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeChildToolStripMenuItem;
    }
}