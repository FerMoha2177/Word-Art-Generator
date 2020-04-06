namespace Assignment3_Library
{
    partial class courseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.course = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // course
            // 
            this.course.Dock = System.Windows.Forms.DockStyle.Top;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.Magenta;
            this.course.Location = new System.Drawing.Point(0, 0);
            this.course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(75, 19);
            this.course.TabIndex = 0;
            this.course.Text = "COP 4226";
            this.course.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.course.Click += new System.EventHandler(this.Course_Click);
            // 
            // semester
            // 
            this.semester.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.ForeColor = System.Drawing.Color.Magenta;
            this.semester.Location = new System.Drawing.Point(0, 62);
            this.semester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(75, 19);
            this.semester.TabIndex = 1;
            this.semester.Text = "Fall 2019";
            this.semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.semester);
            this.Controls.Add(this.course);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "courseControl";
            this.Size = new System.Drawing.Size(75, 81);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label semester;
    }
}
