namespace Assignment3_Library
{
    partial class oathControl
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
            this.oath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oath
            // 
            this.oath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oath.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oath.Location = new System.Drawing.Point(0, 0);
            this.oath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oath.Name = "oath";
            this.oath.Size = new System.Drawing.Size(408, 80);
            this.oath.TabIndex = 0;
            this.oath.Text = " I understand that this is a group project.\r\n      It is in my best interest to p" +
    "articipate in writing \r\n      the homework and study all the code from the \r\n   " +
    "   homework.";
            // 
            // oathControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.oath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "oathControl";
            this.Size = new System.Drawing.Size(408, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label oath;
    }
}
