namespace Text_Assignment_Module_7
{
    partial class OathDialog
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
            this.oathControl1 = new Assignment3_Library.oathControl();
            this.SuspendLayout();
            // 
            // oathControl1
            // 
            this.oathControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oathControl1.BackColor = System.Drawing.SystemColors.Highlight;
            this.oathControl1.Location = new System.Drawing.Point(310, 167);
            this.oathControl1.Name = "oathControl1";
            this.oathControl1.Size = new System.Drawing.Size(641, 122);
            this.oathControl1.TabIndex = 2;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 563);
            this.Controls.Add(this.oathControl1);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.Controls.SetChildIndex(this.oathControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Assignment3_Library.oathControl oathControl1;
    }
}