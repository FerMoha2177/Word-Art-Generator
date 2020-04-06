using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3_Library;


namespace Text_Assignment_Module_7 
{
    public partial class TextOptionsDialog : baseDialog, IDataSource
    {
        public delegate void refreshItemsEventHandler();
        public event refreshItemsEventHandler TextItemUpdated;



        public Object _Data
        { get
            { return this.textBindingSource.DataSource; }
            set
            { this.textBindingSource.DataSource = value; }

        }

        public BindingManagerBase BindingManager
        {
            get
            {
                return this.BindingContext[this._Data];
            }
            set { this.BindingManager = value; }
        }

        public Text CurrentText
        {
            get
            {
                return (Text)this.BindingManager.Current;
            }
            set {; }
        }

        public int TextIndex { get => textIndex; set => textIndex = value; }

        int textIndex;
        public TextOptionsDialog()
        {
            InitializeComponent();
           
            RefreshItems();
        }
        public TextOptionsDialog(int txtIndex)
        {
           
            InitializeComponent();
            


            this.labelDisplayTextExample.DataBindings.Add("ForeColor", this.textBindingSource, "TextColor");
            this.labelDisplayTextExample.DataBindings.Add("BackColor", this.textBindingSource, "BackColor");
            this.labelDisplayTextExample.DataBindings.Add("Font", this.textBindingSource, "Textfont");
            this.xTextBox.DataBindings.Add("Text", this.textBindingSource, "Location.X");
            this.yTextBox.DataBindings.Add("Text", this.textBindingSource, "Location.Y");
            this.rotationXTextBox.DataBindings.Add("Text", this.textBindingSource, "RotationAngle");

            //MessageBox.Show("Receiving " + txtIndex);

            TextIndex = txtIndex;

            this.BindingManager.Position = txtIndex;
            RefreshItems();

        }
        
        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK)
            {

                this.CurrentText.BackColor = ColorDialog.Color;
                //this.labelDisplayTextExample.BackColor = ColorDialog.Color;

            }

            // invalidates main form and allows change (TIM DOES NOT WANT THIS)
            TextItemUpdated(); 
        }

        private void textColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                //currentText.TextColor = ColorDialog.Color;
                //this.currentDoc[this.managerBase.Position].TextColor = ColorDialog.Color;
                this.labelDisplayTextExample.ForeColor = ColorDialog.Color;
                this.CurrentText.TextColor = ColorDialog.Color;

            }
            TextItemUpdated();

        }

        private void applyLocationButton_Click(object sender, EventArgs e)
        {

            //this.CurrentText.Location = new Point(Int32.Parse(xTextBox.Text), Int32.Parse(yTextBox.Text));
            ////this.currentDoc[this.managerBase.Position].Location = new Point(Int32.Parse(xTextBox.Text), Int32.Parse(yTextBox.Text));
            //this.xTextBox.Text = xTextBox.Text;
            //this.yTextBox.Text = yTextBox.Text;
            TextItemUpdated();

        }

        private void applyRotationButton_Click(object sender, EventArgs e)
        {
            //this.currentDoc[this.managerBase.Position].RotationAngle = float.Parse(rotationXTextBox.Text);

            TextItemUpdated();

        }

        private void changeTextFontButton_Click(object sender, EventArgs e)
        {
            if(FontDialog.ShowDialog() == DialogResult.OK)
            {
                //this.currentDoc[this.managerBase.Position].Textfont = FontDialog.Font;
                this.labelDisplayTextExample.Font = FontDialog.Font;
                this.CurrentText.Textfont = FontDialog.Font;

            }
            TextItemUpdated();

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            //this.CurrentText.TextIndex = this.managerBase.Position;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

            --this.BindingManager.Position;

            //this.CurrentText.TextIndex = this.managerBase.Position;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = this.BindingManager.Count - 1;
            //this.CurrentText.TextIndex = this.managerBase.Position;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            //this.CurrentText.TextIndex = this.managerBase.Position;
        }



        private void IncreaseZOrder_Click(object sender, EventArgs e)
        {
            ///currentDoc.IncreaseZOrder(currentText);
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            //currentDoc.DecreaseZOrder(currentText);
        }

        private void SendToFront_Click(object sender, EventArgs e)
        {
            //currentDoc.SendToFront(currentText);
        }

        private void SendToBack_Click(object sender, EventArgs e)
        {
            //currentDoc.SendToBack(currentText);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            TextItemUpdated();

             ++this.BindingManager.Position;
            
            RefreshItems();
        }

        public void RefreshItems()
        {

            
            
            int count = this.BindingManager.Count;
            
            
            int position = this.BindingManager.Position + 1;
           


            // Enable or disable move buttons
            this.buttonMoveToFirst.Enabled = (position > 1);
            this.buttonPrevious.Enabled = (position > 1);
            this.buttonNext.Enabled = (position < count);
            this.buttonMoveToLast.Enabled = (position < count);

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            TextItemUpdated();
            // No need to worry about being < 0
            --this.BindingManager.Position;
            //currentText.TextIndex = this.managerBase.Position;
            RefreshItems();
        }

        private void buttonMoveToFirst_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            //currentText.TextIndex = this.managerBase.Position;
            RefreshItems();
        }

        private void buttonMoveToLast_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = this.BindingManager.Count - 1;
            //currentText.TextIndex = this.managerBase.Position  ;
            RefreshItems();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add item to list data source directly
            Text newText = new Text();
            
            //this.texts.Add(newText);
            //this.listOfTexts.Add(newText);
            //this.currentDoc.AddText(newText);

            // Select new item
            //this.managerBase.Position = this.managerBase.Count - 1;
            RefreshItems();
            
        }

        private void ZOrder_Enter(object sender, EventArgs e)
        {

        }

        private void GridViewVisible_Click(object sender, EventArgs e)
        {
            if (!textGridView.Visible)
            {
                textGridView.Visible = true;
                gridViewVisible.Text = "Hide Grid View";


            }
            else if(textGridView.Visible)
            {
                textGridView.Visible = false;
                gridViewVisible.Text = "Show Grid View";
            }
        }
    }
}
