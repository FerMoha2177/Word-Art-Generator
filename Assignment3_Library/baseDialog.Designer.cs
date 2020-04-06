namespace Assignment3_Library
{
    partial class baseDialog
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
            this.nameControl = new Assignment3_Library.nameControl();
            this.courseControl = new Assignment3_Library.courseControl();
            this.SuspendLayout();
            // 
            // nameControl
            // 
            this.nameControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameControl.Location = new System.Drawing.Point(0, 336);
            this.nameControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameControl.Name = "nameControl";
            this.nameControl.Size = new System.Drawing.Size(888, 193);
            this.nameControl.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.ForeColor = System.Drawing.Color.Magenta;
            this.courseControl.Location = new System.Drawing.Point(0, 0);
            this.courseControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(888, 332);
            this.courseControl.TabIndex = 1;
            // 
            // baseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ass3Library.Properties.Resources.furretIcon;
            this.ClientSize = new System.Drawing.Size(888, 529);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.nameControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "baseDialog";
            this.Text = "baseDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private nameControl nameControl;
        private courseControl courseControl;
    }
}