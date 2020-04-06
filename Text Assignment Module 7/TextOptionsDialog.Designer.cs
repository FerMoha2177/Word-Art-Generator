namespace Text_Assignment_Module_7
{
    partial class TextOptionsDialog
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
            System.Windows.Forms.Label textBackColorLabel;
            System.Windows.Forms.Label textColorLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            System.Windows.Forms.Label rotationXLabel;
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.colorsGroupBox = new System.Windows.Forms.GroupBox();
            this.textColorButton = new System.Windows.Forms.Button();
            this.chooseTextBackColorButton = new System.Windows.Forms.Button();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.applyLocationButton = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.rotationGroupBox = new System.Windows.Forms.GroupBox();
            this.applyRotationButton = new System.Windows.Forms.Button();
            this.rotationXTextBox = new System.Windows.Forms.TextBox();
            this.textFontGroupBox = new System.Windows.Forms.GroupBox();
            this.changeTextFontButton = new System.Windows.Forms.Button();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.ZOrder = new System.Windows.Forms.GroupBox();
            this.Decrease = new System.Windows.Forms.Button();
            this.SendToBack = new System.Windows.Forms.Button();
            this.SendToFront = new System.Windows.Forms.Button();
            this.IncreaseZOrder = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonMoveToFirst = new System.Windows.Forms.Button();
            this.buttonMoveToLast = new System.Windows.Forms.Button();
            this.textGridView = new System.Windows.Forms.DataGridView();
            this.labelDisplayTextExample = new System.Windows.Forms.Label();
            this.groupBoxTextExample = new System.Windows.Forms.GroupBox();
            this.textBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.gridViewVisible = new System.Windows.Forms.Button();
            textBackColorLabel = new System.Windows.Forms.Label();
            textColorLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            rotationXLabel = new System.Windows.Forms.Label();
            this.colorsGroupBox.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.rotationGroupBox.SuspendLayout();
            this.textFontGroupBox.SuspendLayout();
            this.ZOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textGridView)).BeginInit();
            this.groupBoxTextExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBackColorLabel
            // 
            textBackColorLabel.AutoSize = true;
            textBackColorLabel.Location = new System.Drawing.Point(5, 15);
            textBackColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            textBackColorLabel.Name = "textBackColorLabel";
            textBackColorLabel.Size = new System.Drawing.Size(83, 13);
            textBackColorLabel.TabIndex = 0;
            textBackColorLabel.Text = "Text Back Color";
            // 
            // textColorLabel
            // 
            textColorLabel.AutoSize = true;
            textColorLabel.Location = new System.Drawing.Point(5, 67);
            textColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            textColorLabel.Name = "textColorLabel";
            textColorLabel.Size = new System.Drawing.Size(55, 13);
            textColorLabel.TabIndex = 3;
            textColorLabel.Text = "Text Color";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(5, 21);
            xLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(17, 13);
            xLabel.TabIndex = 0;
            xLabel.Text = "X:";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(5, 42);
            yLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(17, 13);
            yLabel.TabIndex = 2;
            yLabel.Text = "Y:";
            // 
            // rotationXLabel
            // 
            rotationXLabel.AutoSize = true;
            rotationXLabel.Location = new System.Drawing.Point(10, 16);
            rotationXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rotationXLabel.Name = "rotationXLabel";
            rotationXLabel.Size = new System.Drawing.Size(47, 13);
            rotationXLabel.TabIndex = 0;
            rotationXLabel.Text = "Rotation";
            // 
            // colorsGroupBox
            // 
            this.colorsGroupBox.AutoSize = true;
            this.colorsGroupBox.Controls.Add(this.textColorButton);
            this.colorsGroupBox.Controls.Add(textColorLabel);
            this.colorsGroupBox.Controls.Add(this.chooseTextBackColorButton);
            this.colorsGroupBox.Controls.Add(textBackColorLabel);
            this.colorsGroupBox.Location = new System.Drawing.Point(27, 16);
            this.colorsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorsGroupBox.Name = "colorsGroupBox";
            this.colorsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.colorsGroupBox.Size = new System.Drawing.Size(171, 129);
            this.colorsGroupBox.TabIndex = 2;
            this.colorsGroupBox.TabStop = false;
            this.colorsGroupBox.Text = "Colors";
            // 
            // textColorButton
            // 
            this.textColorButton.Location = new System.Drawing.Point(25, 84);
            this.textColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(125, 28);
            this.textColorButton.TabIndex = 5;
            this.textColorButton.Text = "Pick Text Color";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // chooseTextBackColorButton
            // 
            this.chooseTextBackColorButton.Location = new System.Drawing.Point(25, 34);
            this.chooseTextBackColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.chooseTextBackColorButton.Name = "chooseTextBackColorButton";
            this.chooseTextBackColorButton.Size = new System.Drawing.Size(125, 29);
            this.chooseTextBackColorButton.TabIndex = 2;
            this.chooseTextBackColorButton.Text = "Pick Text Back Color";
            this.chooseTextBackColorButton.UseVisualStyleBackColor = true;
            this.chooseTextBackColorButton.Click += new System.EventHandler(this.chooseColorButton_Click);
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationGroupBox.Controls.Add(this.applyLocationButton);
            this.locationGroupBox.Controls.Add(xLabel);
            this.locationGroupBox.Controls.Add(this.xTextBox);
            this.locationGroupBox.Controls.Add(yLabel);
            this.locationGroupBox.Controls.Add(this.yTextBox);
            this.locationGroupBox.Location = new System.Drawing.Point(877, 179);
            this.locationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.locationGroupBox.Size = new System.Drawing.Size(117, 113);
            this.locationGroupBox.TabIndex = 3;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // applyLocationButton
            // 
            this.applyLocationButton.Location = new System.Drawing.Point(25, 66);
            this.applyLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyLocationButton.Name = "applyLocationButton";
            this.applyLocationButton.Size = new System.Drawing.Size(77, 24);
            this.applyLocationButton.TabIndex = 4;
            this.applyLocationButton.Text = "Apply ";
            this.applyLocationButton.UseVisualStyleBackColor = true;
            this.applyLocationButton.Click += new System.EventHandler(this.applyLocationButton_Click);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(26, 18);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(76, 20);
            this.xTextBox.TabIndex = 1;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(25, 42);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(77, 20);
            this.yTextBox.TabIndex = 3;
            // 
            // rotationGroupBox
            // 
            this.rotationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationGroupBox.AutoSize = true;
            this.rotationGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rotationGroupBox.Controls.Add(this.applyRotationButton);
            this.rotationGroupBox.Controls.Add(rotationXLabel);
            this.rotationGroupBox.Controls.Add(this.rotationXTextBox);
            this.rotationGroupBox.Location = new System.Drawing.Point(877, 11);
            this.rotationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rotationGroupBox.MaximumSize = new System.Drawing.Size(160, 116);
            this.rotationGroupBox.Name = "rotationGroupBox";
            this.rotationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rotationGroupBox.Size = new System.Drawing.Size(137, 81);
            this.rotationGroupBox.TabIndex = 4;
            this.rotationGroupBox.TabStop = false;
            this.rotationGroupBox.Text = "Rotation";
            // 
            // applyRotationButton
            // 
            this.applyRotationButton.Location = new System.Drawing.Point(57, 36);
            this.applyRotationButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyRotationButton.Name = "applyRotationButton";
            this.applyRotationButton.Size = new System.Drawing.Size(75, 28);
            this.applyRotationButton.TabIndex = 4;
            this.applyRotationButton.Text = "Apply";
            this.applyRotationButton.UseVisualStyleBackColor = true;
            this.applyRotationButton.Click += new System.EventHandler(this.applyRotationButton_Click);
            // 
            // rotationXTextBox
            // 
            this.rotationXTextBox.Location = new System.Drawing.Point(57, 15);
            this.rotationXTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rotationXTextBox.Name = "rotationXTextBox";
            this.rotationXTextBox.Size = new System.Drawing.Size(76, 20);
            this.rotationXTextBox.TabIndex = 1;
            // 
            // textFontGroupBox
            // 
            this.textFontGroupBox.Controls.Add(this.changeTextFontButton);
            this.textFontGroupBox.Location = new System.Drawing.Point(27, 149);
            this.textFontGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.textFontGroupBox.Name = "textFontGroupBox";
            this.textFontGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.textFontGroupBox.Size = new System.Drawing.Size(171, 58);
            this.textFontGroupBox.TabIndex = 5;
            this.textFontGroupBox.TabStop = false;
            this.textFontGroupBox.Text = "Text Font";
            // 
            // changeTextFontButton
            // 
            this.changeTextFontButton.Location = new System.Drawing.Point(25, 26);
            this.changeTextFontButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeTextFontButton.Name = "changeTextFontButton";
            this.changeTextFontButton.Size = new System.Drawing.Size(125, 21);
            this.changeTextFontButton.TabIndex = 0;
            this.changeTextFontButton.Text = "Change Font";
            this.changeTextFontButton.UseVisualStyleBackColor = true;
            this.changeTextFontButton.Click += new System.EventHandler(this.changeTextFontButton_Click);
            // 
            // ZOrder
            // 
            this.ZOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZOrder.Controls.Add(this.Decrease);
            this.ZOrder.Controls.Add(this.SendToBack);
            this.ZOrder.Controls.Add(this.SendToFront);
            this.ZOrder.Controls.Add(this.IncreaseZOrder);
            this.ZOrder.Location = new System.Drawing.Point(877, 100);
            this.ZOrder.Margin = new System.Windows.Forms.Padding(2);
            this.ZOrder.Name = "ZOrder";
            this.ZOrder.Padding = new System.Windows.Forms.Padding(2);
            this.ZOrder.Size = new System.Drawing.Size(182, 75);
            this.ZOrder.TabIndex = 6;
            this.ZOrder.TabStop = false;
            this.ZOrder.Text = "Z-Order";
            this.ZOrder.Enter += new System.EventHandler(this.ZOrder_Enter);
            // 
            // Decrease
            // 
            this.Decrease.Location = new System.Drawing.Point(11, 50);
            this.Decrease.Margin = new System.Windows.Forms.Padding(2);
            this.Decrease.Name = "Decrease";
            this.Decrease.Size = new System.Drawing.Size(75, 21);
            this.Decrease.TabIndex = 3;
            this.Decrease.Text = "Decrease";
            this.Decrease.UseVisualStyleBackColor = true;
            this.Decrease.Click += new System.EventHandler(this.Decrease_Click);
            // 
            // SendToBack
            // 
            this.SendToBack.Location = new System.Drawing.Point(92, 50);
            this.SendToBack.Margin = new System.Windows.Forms.Padding(2);
            this.SendToBack.Name = "SendToBack";
            this.SendToBack.Size = new System.Drawing.Size(80, 21);
            this.SendToBack.TabIndex = 2;
            this.SendToBack.Text = "Send to back";
            this.SendToBack.UseVisualStyleBackColor = true;
            this.SendToBack.Click += new System.EventHandler(this.SendToBack_Click);
            // 
            // SendToFront
            // 
            this.SendToFront.Location = new System.Drawing.Point(92, 20);
            this.SendToFront.Margin = new System.Windows.Forms.Padding(2);
            this.SendToFront.Name = "SendToFront";
            this.SendToFront.Size = new System.Drawing.Size(80, 21);
            this.SendToFront.TabIndex = 1;
            this.SendToFront.Text = "Send to front";
            this.SendToFront.UseVisualStyleBackColor = true;
            this.SendToFront.Click += new System.EventHandler(this.SendToFront_Click);
            // 
            // IncreaseZOrder
            // 
            this.IncreaseZOrder.Location = new System.Drawing.Point(11, 20);
            this.IncreaseZOrder.Margin = new System.Windows.Forms.Padding(2);
            this.IncreaseZOrder.Name = "IncreaseZOrder";
            this.IncreaseZOrder.Size = new System.Drawing.Size(75, 21);
            this.IncreaseZOrder.TabIndex = 0;
            this.IncreaseZOrder.Text = "Increase";
            this.IncreaseZOrder.UseVisualStyleBackColor = true;
            this.IncreaseZOrder.Click += new System.EventHandler(this.IncreaseZOrder_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(985, 310);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(74, 24);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(27, 310);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(74, 24);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Prev";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonMoveToFirst
            // 
            this.buttonMoveToFirst.Location = new System.Drawing.Point(106, 311);
            this.buttonMoveToFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveToFirst.Name = "buttonMoveToFirst";
            this.buttonMoveToFirst.Size = new System.Drawing.Size(74, 29);
            this.buttonMoveToFirst.TabIndex = 9;
            this.buttonMoveToFirst.Text = "Move First";
            this.buttonMoveToFirst.UseVisualStyleBackColor = true;
            this.buttonMoveToFirst.Click += new System.EventHandler(this.buttonMoveToFirst_Click);
            // 
            // buttonMoveToLast
            // 
            this.buttonMoveToLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveToLast.Location = new System.Drawing.Point(909, 310);
            this.buttonMoveToLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveToLast.Name = "buttonMoveToLast";
            this.buttonMoveToLast.Size = new System.Drawing.Size(74, 30);
            this.buttonMoveToLast.TabIndex = 10;
            this.buttonMoveToLast.Text = "Move Last";
            this.buttonMoveToLast.UseVisualStyleBackColor = true;
            this.buttonMoveToLast.Click += new System.EventHandler(this.buttonMoveToLast_Click);
            // 
            // textGridView
            // 
            this.textGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textGridView.Location = new System.Drawing.Point(282, 150);
            this.textGridView.Margin = new System.Windows.Forms.Padding(2);
            this.textGridView.Name = "textGridView";
            this.textGridView.RowTemplate.Height = 24;
            this.textGridView.Size = new System.Drawing.Size(550, 210);
            this.textGridView.TabIndex = 11;
            this.textGridView.Visible = false;
            // 
            // labelDisplayTextExample
            // 
            this.labelDisplayTextExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisplayTextExample.Location = new System.Drawing.Point(2, 15);
            this.labelDisplayTextExample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisplayTextExample.Name = "labelDisplayTextExample";
            this.labelDisplayTextExample.Size = new System.Drawing.Size(507, 76);
            this.labelDisplayTextExample.TabIndex = 4;
            this.labelDisplayTextExample.Text = "Example123!@?";
            this.labelDisplayTextExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxTextExample
            // 
            this.groupBoxTextExample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTextExample.Controls.Add(this.labelDisplayTextExample);
            this.groupBoxTextExample.Location = new System.Drawing.Point(308, 21);
            this.groupBoxTextExample.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTextExample.Name = "groupBoxTextExample";
            this.groupBoxTextExample.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTextExample.Size = new System.Drawing.Size(511, 93);
            this.groupBoxTextExample.TabIndex = 11;
            this.groupBoxTextExample.TabStop = false;
            this.groupBoxTextExample.Text = "Preview";
            // 
            // textBindingSource
            // 
            this.textBindingSource.DataSource = typeof(Text_Assignment_Module_7.Text);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(308, 121);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(52, 19);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // gridViewVisible
            // 
            this.gridViewVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewVisible.Location = new System.Drawing.Point(684, 122);
            this.gridViewVisible.Name = "gridViewVisible";
            this.gridViewVisible.Size = new System.Drawing.Size(135, 23);
            this.gridViewVisible.TabIndex = 13;
            this.gridViewVisible.Text = "See Grid View";
            this.gridViewVisible.UseVisualStyleBackColor = true;
            this.gridViewVisible.Click += new System.EventHandler(this.GridViewVisible_Click);
            // 
            // TextOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 539);
            this.Controls.Add(this.gridViewVisible);
            this.Controls.Add(this.groupBoxTextExample);
            this.Controls.Add(this.textFontGroupBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textGridView);
            this.Controls.Add(this.buttonMoveToLast);
            this.Controls.Add(this.buttonMoveToFirst);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.ZOrder);
            this.Controls.Add(this.rotationGroupBox);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.colorsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(557, 406);
            this.Name = "TextOptionsDialog";
            this.Text = "TextOptionsDialog";
            this.Controls.SetChildIndex(this.colorsGroupBox, 0);
            this.Controls.SetChildIndex(this.locationGroupBox, 0);
            this.Controls.SetChildIndex(this.rotationGroupBox, 0);
            this.Controls.SetChildIndex(this.ZOrder, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            this.Controls.SetChildIndex(this.buttonPrevious, 0);
            this.Controls.SetChildIndex(this.buttonMoveToFirst, 0);
            this.Controls.SetChildIndex(this.buttonMoveToLast, 0);
            this.Controls.SetChildIndex(this.textGridView, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.textFontGroupBox, 0);
            this.Controls.SetChildIndex(this.groupBoxTextExample, 0);
            this.Controls.SetChildIndex(this.gridViewVisible, 0);
            this.colorsGroupBox.ResumeLayout(false);
            this.colorsGroupBox.PerformLayout();
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.rotationGroupBox.ResumeLayout(false);
            this.rotationGroupBox.PerformLayout();
            this.textFontGroupBox.ResumeLayout(false);
            this.ZOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textGridView)).EndInit();
            this.groupBoxTextExample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.GroupBox colorsGroupBox;
        private System.Windows.Forms.Button chooseTextBackColorButton;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.Button applyLocationButton;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.GroupBox rotationGroupBox;
        private System.Windows.Forms.Button applyRotationButton;
        private System.Windows.Forms.TextBox rotationXTextBox;
        private System.Windows.Forms.GroupBox textFontGroupBox;
        private System.Windows.Forms.Button changeTextFontButton;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.GroupBox ZOrder;
        private System.Windows.Forms.Button Decrease;
        private System.Windows.Forms.Button SendToBack;
        private System.Windows.Forms.Button SendToFront;
        private System.Windows.Forms.Button IncreaseZOrder;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.BindingSource textBindingSource;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonMoveToFirst;
        private System.Windows.Forms.Button buttonMoveToLast;
        private System.Windows.Forms.DataGridView textGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDisplayTextExample;
        private System.Windows.Forms.GroupBox groupBoxTextExample;
        private System.Windows.Forms.Button gridViewVisible;
    }
}