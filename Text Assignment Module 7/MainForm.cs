using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Microsoft.Win32;
using Assignment3_Library;
using System.Drawing.Imaging;

namespace Text_Assignment_Module_7
{
    public partial class MainForm : baseMainForm
    {
        private Point txtInitLocation = new Point(100, 100);
        private Font txtFont;
        private Color txtColor;
        private Color txtBackColor;
        Text txt;

        RectangleF rect = new RectangleF();
        Point StartingLocation = new Point(0, 0);
        Point Offset = new Point(0, 0);

        bool DrawEnabled = false;
        private bool firstPasteDone = false;


        Document textDoc = new Document();
        TextOptionsDialog textDialog =  new TextOptionsDialog();

        List<Bitmap> bmpList = new List<Bitmap>();

        Bitmap bmp;

        BufferedGraphicsContext bufferContext;  //used for buffering. Might be useless and be deleted, probably
        
        private string fileNameWithFullPath;
        static int formCount = 0;

        Rectangle screenImageRectangle;
        Bitmap dumpImageBitmap;
        /************************CUSTOM/HELPER METHODS************************/

        /// <summary>
        /// Custom method:
        /// checks if a form is already open
        /// </summary>
        /// <param name="formToOpen"></param>
        /// <returns>true if the form is open, false if is not</returns>
        private bool IsFormOpen(Form formToOpen)
        {
            foreach (Form form in Application.OpenForms)
            {

                if (form.Name == formToOpen.Name)
                {
                    return true;
                }

            }
            return false;
        }

        /// <summary>
        /// Custom method:
        /// this method checks if the mouse is inside a text object
        /// is very similar to what is found inside the MainForm_MouseMove method       
        /// </summary>
        /// <param name="e"></param>
        /// <returns>
        /// false if mouse is not inside the objec, true if it is
        /// </returns>
        private bool MouseInsideShape(MouseEventArgs e)
        {
            
            Graphics g = this.CreateGraphics();

            foreach (Text txt in textDoc)
            {
                Font textFont = txt.Textfont;    //gets font
                SizeF textSize = g.MeasureString(txt.TextString, textFont);  //measure the size of the text
                RectangleF measureRectangle = new RectangleF(txt.Location, textSize);
                Console.WriteLine(textSize.ToString());
                if (measureRectangle.Contains(e.Location))
                {
                    return true;

                }

                //this is used for when transformation is implemented to detect the transformed shaped
                else
                {
                    Point[] mouseLoc = new Point[] { e.Location };
                    g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, mouseLoc);
                    if (measureRectangle.Contains(mouseLoc[0]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Custom method:
        /// this opens our custom extension text file
        /// </summary>
        /// <param name="path"></param>
        private void openFile(string path)
        {
            this.fileNameWithFullPath = path;

            if (File.Exists(path))
            {
                if (path.Contains(".txt"))
                {
                    openTextFile(path);
                }

                //For PNG Processing
                //if (path.Contains(".png"))
                //{
                //    openPNGFile();
                //}

                else
                {
                    BinaryFormatter openingFile = new BinaryFormatter();
                    Stream stream;
                    using (stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        //bmp = (Bitmap)openingFile.Deserialize(stream); //added this show the png processing dont think it works
                        textDoc = (Document)openingFile.Deserialize(stream);
                        if (textDoc != null)
                        {
                            //DrawingTextPanel.Refresh(); // redrawing all the text of the list, this panel was added in main Designer to draw text
                            this.Invalidate();
                        }

                        if (bmp != null)
                        {
                            this.Invalidate();
                        }
                    }
                }
            }
            else
            {
                this.fileNameWithFullPath = "Untitled" + formCount.ToString();
            }
            this.Text = this.Text + " (" + this.fileNameWithFullPath + " )";
            saveToolStripMenuItem.Enabled = true;
        }

        public void openPNGFile(string filename)
        {
            bmp = new Bitmap(filename);
        }

        /// <summary>
        /// Custom method:
        /// this opens any type of text file that can be opened using a normal word editor 
        /// </summary>
        /// <param name="path"></param>
        public void openTextFile(string path)
        {
            this.fileNameWithFullPath = path;

            if (File.Exists(path))
            {
                String line;
                Stream stream;
                StreamReader sr;
                Graphics g;

                using (stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (sr = new StreamReader(stream))
                using (g = CreateGraphics())
                {
                    //Read the first line of text
                    line = sr.ReadLine();
                    line.Trim();

                    //Continue to read until you reach end of file
                    char[] delimiterChars = { ' ' };

                    while (line != null)
                    {
                        string[] textWords = line.Split(delimiterChars);
                        foreach (var textWord in textWords)
                        {
                            Paste(textWord);
                        }

                        line = sr.ReadLine();
                    }

                    if (textDoc != null)
                    {
                        //DrawingTextPanel.Refresh(); // redrawing all the text of the list, this panel was added in main Designer to draw text
                        this.Invalidate();
                    }
                }
            }
        }

        /// <summary>
        /// Custom method:
        /// Draws the contents of the clipboard to the main form and adds it to 
        /// the Document array
        /// </summary>
        private void Paste()
        {
            Paste(System.Windows.Forms.Clipboard.GetText());
        }

        /// <summary>
        /// Custom method:
        /// Adds new element of the Document array and draws its contents. 
        /// If this is the first element, it just copies and pastes the 
        /// contents of the string "s" to it. 
        /// </summary>
        /// <param name="s"></param>
        private void Paste(string s)
        {
            if (s != "")
            {
                if (firstPasteDone)
                {
                    Graphics g = this.CreateGraphics();
                    Font textFont = textDoc.GetLast.Textfont;    //gets font from previous item 
                    SizeF textSize = g.MeasureString(textDoc.GetLast.TextString, textFont);  //measure the size of the text from previous item
                    RectangleF measureRectangle = new RectangleF(textDoc.GetLast.Location, textSize);
                    Point pointOfNewText = new Point((int)measureRectangle.Left, (int)measureRectangle.Bottom + 10);    //calculates location of previous item

                    txt = new Text(s, pointOfNewText);
                    SetTextProperties(txt);
                    textDoc.AddText(txt);

                    // Everytime a new text object is created, it gets an index
                    txt.TextIndex = textDoc.Count - 1;
                    

                    this.Invalidate();
                }
                else
                {
                    txt.TextString = s;
                    SetTextProperties(txt);
                    firstPasteDone = true;

                    this.Invalidate();

                }
            }
        }

        public static MainForm CreateTopLevelWindow(string fileName, bool isImage)
        {

            if (!String.IsNullOrEmpty(fileName))
            {
                foreach (MainForm form in Application.OpenForms)
                {
                    if (fileName.Equals(form.fileNameWithFullPath))
                    {
                        form.Activate();
                        return form;
                    }
                }
            }
            MainForm newForm = new MainForm();

            if (isImage == false)
            {
                newForm.openFile(fileName);
                newForm.Show();
                newForm.Activate();
                return newForm;
            }

            else
            {
                newForm.openPNGFile(fileName);
                newForm.Show();
                newForm.Activate();
                return newForm;
            }

        }



        /// <summary>
        /// Custom Method.
        /// Removes the current Text object from the main form and the Document object.
        /// If the Text object is the last one on the list it creates a new one and sets it to the Text object on main form.
        /// Else, the Text object on main form becomes the last object on the Document object list.
        /// </summary>
        private void DeleteText()
        {
            textDoc.RemoveText(txt);

            if (textDoc.Count == 0)     //list is empty
            {
                txt = new Text(txtInitLocation);
                textDoc.AddText(txt);
                firstPasteDone = false;
            }
            else
            {
                txt = textDoc.GetLast;
            }
        }

        /// <summary>
        /// Custom method.
        /// Sets the font, text color and background color of an Text object passed to it. 
        /// </summary>
        /// <param name="t"></param>
        private void SetTextProperties(Text t)
        {
            if (txtFont != null)
            {
                t.Textfont = txtFont;
            }
            if (!txtBackColor.Name.Equals("0"))
            {
                t.BackColor = txtBackColor;
            }
            if (!txtColor.Name.Equals("0"))
            {
                t.TextColor = txtColor;
            }
        }

        /// <summary>
        /// Custom method.
        /// Saves files as an png Image
        /// </summary>
        /// <param name="path"></param>
        private void saveFileAsImage(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                screenImageRectangle = this.DrawingTextPanel.ClientRectangle;    //creates rectangle from drawing text panel (which is invisible)
                dumpImageBitmap = new Bitmap(screenImageRectangle.Width, screenImageRectangle.Height); //sets bitmap to that size

                this.DrawingTextPanel.DrawToBitmap(dumpImageBitmap, screenImageRectangle);    //draws the content of the panel into the bitmap

                //saves the bitmap to the directory
                dumpImageBitmap.Save(path, ImageFormat.Png);
            }

        }
        /************************MAIN FORM STARTS HERE************************/

        public MainForm()
        {
            
            InitializeComponent();
            ToolStripManager.Merge(menuStripBase, menuStripMain);

            fileNameWithFullPath = "";

            txt = new Text(txtInitLocation);

            //initializes array
            textDoc.AddText(txt);

            //used for buffering
            bufferContext = new BufferedGraphicsContext();
            bufferContext.MaximumBuffer = this.ClientRectangle.Size;

            saveToolStripMenuItem.Enabled = false;

            ++formCount;
            this.Text += ": " + formCount.ToString();
            MultiSDIApp.Application.AddTopLevelForm(this);

        }


        //FIXME: THIS OVERRIDE OF MAIN FORM MIGHT NOT BE NEEDED AND PROBABLY CAN BE DELETED
        public MainForm(string path)
        {
            InitializeComponent();

            DrawingTextPanel.DragEnter += new DragEventHandler(DrawingTextPanel_DragEnter);
            DrawingTextPanel.DragDrop += new DragEventHandler(DrawingTextPanel_DragDrop);


            textDoc.AddText(txt);
            fileNameWithFullPath = path;
            //used for buffering
            bufferContext = new BufferedGraphicsContext();
            bufferContext.MaximumBuffer = this.ClientRectangle.Size;

            saveToolStripMenuItem.Enabled = false;

            openTextFile(fileNameWithFullPath);
        }

        private void saveFile(string path)
        {
            
            BinaryFormatter savingFile = new BinaryFormatter();
            Stream stream;
            if (!String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                using (stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    savingFile.Serialize(stream, textDoc);
                }
            }
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string p = @"C:\Test.txt";
            //string x = Path.GetExtension(p);
            openFileDialog.Filter = "st Files (.st)|*.st|All Files (*.*)|*.*| Text Files (.txt)|*.txt|HTML Files (.html)|*.html";
            openFileDialog.Title = "Open File";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainForm.CreateTopLevelWindow(this.openFileDialog.FileName, false);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "st Files (.st)|*.st|Text Files (.txt)|*.txt|All Files (*.*)|*.*|HTML Files (.html)|*.html";
            saveFileDialog.Title = "Save As";
            saveFileDialog.FileName = "Untitled";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFile(saveFileDialog.FileName);
            }
           
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
            saveFileDialog.FileName =  saveFileDialog.FileName;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile(fileNameWithFullPath);
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //checks if capslock was pressed outside the form
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.toolStripStatusLabelCapsLock.Text = "CapsLock";
            }
            else
            {
                this.toolStripStatusLabelCapsLock.Text = "";
            }
            this.Invalidate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //checks if capslock was pressed
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.toolStripStatusLabelCapsLock.Text = "CapsLock";

            }
            else
            {
                this.toolStripStatusLabelCapsLock.Text = "";
            }

            switch (e.KeyData)
            {
                case Keys.Up:
                    txt.Location = new Point(txt.Location.X, txt.Location.Y - 2);
                    this.Invalidate();
                    break;
                case Keys.Down:
                    txt.Location = new Point(txt.Location.X, txt.Location.Y + 2);
                    this.Invalidate();
                    break;
                case Keys.Left:
                    txt.Location = new Point(txt.Location.X - 2, txt.Location.Y);
                    this.Invalidate();
                    break;
                case Keys.Right:
                    txt.Location = new Point(txt.Location.X + 2, txt.Location.Y);
                    this.Invalidate();
                    break;
                case Keys.Back:
                    DeleteText();
                    this.Invalidate();
                    break;
            }
        }



        private void SetClickedRectangle(MouseEventArgs e)
        {

            Graphics g = this.CreateGraphics();

            foreach (Text t in textDoc)
            {
                Font textFont = t.Textfont;
                SizeF textSize = g.MeasureString(t.TextString, textFont); 
                RectangleF measureRectangle = new RectangleF(t.Location, textSize);

                if (measureRectangle.Contains(e.Location))
                {
                   
                    txt = t;
                    rect = measureRectangle;
                    
                }
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            textDoc.DrawAll(g); 
            textDoc.DrawSelection(g, txt);

            //bmp  = some image from open file dialg
            //if (bmp != null)
            //{
            //    Rectangle rect = new Rectangle(100, 100, this.DrawingTextPanel.ClientRectangle.Width - 20,
            //                    this.DrawingTextPanel.ClientRectangle.Height - 20);

            //    g.DrawImage(bmp, rect);
            //    g.DrawRectangle(Pens.Black, rect);
            //}
            // Set the image attribute's color mappings

            if (bmp != null)
            {

                Image image = bmp;
                ImageAttributes imageAttributes = new ImageAttributes();
                int width = image.Width;
                int height = image.Height;

                const int OGX = 100;
                const int OGY = 100;


                float[][] colorMatrixElements = {
                   new float[] {-2,  0,  0,  0, 0},        // red scaling factor of 2
                   new float[] {0,  1,  5,  0, 0},        // green scaling factor of 1
                   new float[] {0,  0,  1,  0, 0},        // blue scaling factor of 1
                   new float[] {0,  0,  0,  1, 0},        // alpha scaling factor of 1
                   new float[] {.2f, .2f, .2f, 0, 1}};    // three translations of 0.2

                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

                imageAttributes.SetColorMatrix(
                   colorMatrix,
                   ColorMatrixFlag.Default,
                   ColorAdjustType.Bitmap);

                //Regular Image
                e.Graphics.DrawImage(image, OGX, OGY);

                int offestX = OGX + 2 * image.Width;


                //changed colors
                e.Graphics.DrawImage(
                   image,
                   new Rectangle(offestX, 100, width, height),  // destination rectangle 
                   0, 0,        // upper-left corner of source rectangle 
                   width,       // width of source rectangle
                   height,      // height of source rectangle
                   GraphicsUnit.Pixel,
                   imageAttributes);


            }


        }

        

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

            //FIXME: the commented if line below fixes the dragging issue, 
            //but it introduces the previous hitbox bug
            //if (e.Button == MouseButtons.Left && MouseInsideShape(e)) 
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.Hand;
                SetClickedRectangle(e);
                
                StartingLocation = new Point(txt.Location.X, txt.Location.Y);

                int offsetX = e.X - (int)rect.X;
                int offsetY = e.Y - (int)rect.Y;
                Offset = new Point(offsetX, offsetY);
                EnableDraw();
                this.Invalidate();
            }

            else if (e.Button == MouseButtons.Right)
            {
                
                if (MouseInsideShape(e))
                {

                    //MessageBox.Show("Passing in " + txt.TextIndex);
                    textDialog = new TextOptionsDialog(txt.TextIndex);

                    List < Text > textList = new List<Text>();
                    for(int i = 0; i< textDoc.Count(); i++)
                    {
                        textList.Add(textDoc[i]);
                    }

                    textDialog._Data = textList;
                    textDialog.TextItemUpdated += this.Invalidate;
                    textDialog.Owner = this;



                    
                    if (!IsFormOpen(textDialog))
                    {
                        SetClickedRectangle(e);
                        
                        this.Invalidate();

                        textDialog.Show();
                        textDialog.RefreshItems();

                    }
                    

                }

            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (DrawEnabled)
            {
                int newX = StartingLocation.X + e.X - (int)rect.X;
                int newY = StartingLocation.Y + e.Y - (int)rect.Y;

                newX -= Offset.X;
                newY -= Offset.Y;

                txt.Location = new Point(newX, newY);
                this.Invalidate();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            DisableDraw();
            Cursor.Current = this.Cursor;
        }

        private void EnableDraw()
        {
            DrawEnabled = true;
        }

        private void DisableDraw()
        {
            DrawEnabled = false;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!txt.TextString.Equals(""))
            {
                Clipboard.SetText(txt.TextString);
            }

            DeleteText();
            this.Invalidate();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt.TextString != "")
            {
                Clipboard.SetText(txt.TextString);
            }
        }
        
        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OathDialog oathDialog = new OathDialog();
            oathDialog.Owner = this;

            if (!IsFormOpen(oathDialog))
            {
                oathDialog.Show();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.Owner = this;

            if (!IsFormOpen(aboutDialog))
            {
                aboutDialog.Show();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.CreateTopLevelWindow(null, false);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialogMainForm.ShowDialog() == DialogResult.OK)
            {
                txtFont = fontDialogMainForm.Font;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogMainForm.ShowDialog() == DialogResult.OK)
            {
                txtColor = colorDialogMainForm.Color;
            }
        }

        private void textBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogMainForm.ShowDialog() == DialogResult.OK)
            {
                txtBackColor = colorDialogMainForm.Color;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDialog searchDialog = new SearchDialog();
            searchDialog.Owner = this;
            if (!IsFormOpen(searchDialog))
            {
                searchDialog.FileSelected += openTextFile;
                searchDialog.Show();

            }
        }
        enum KeyState
        {
            LeftMouse = 1,
            RightMouse = 2,
            ShiftKey = 4,
            CtrlKey = 8,
            MiddleMouse = 16,
            AltKey = 32,
        }
        private void MainFormDragAndDrop_Load(object sender, EventArgs e)
        {
            // Enable drop target
            this.AllowDrop = true;
        }

        //drop effect
        private void SetDropEffect(DragEventArgs e)
        {

            KeyState keyState = (KeyState)e.KeyState;

            // We don't like the data, so by default do not allow anything
            e.Effect = DragDropEffects.None;

            // If the data is a string, we can handle it
            if (e.Data.GetDataPresent(typeof(string)))
            {
                // If only Ctrl is pressed, copy it
                if ((keyState & KeyState.CtrlKey) == KeyState.CtrlKey)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                { // Else, move it
                    e.Effect = DragDropEffects.Move;
                }
            }

        }
        private void DrawingTextPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            //if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;

        }

        private void DrawingTextPanel_DragDrop(object sender, DragEventArgs e)
        {

            string txt = (string)e.Data.GetData(typeof(string));
            //MessageBox.Show("Dropped Text: " + txt);
            Paste(txt);

        }

        //this should probably be on the click event handler of the menu strip "Save as Image" 
        private void toolStripButtonSaveAsImage_Click(object sender, EventArgs e)
        {

            saveFileDialog.Filter = "PNG Image |*.png";
            saveFileDialog.Title = "Save Image As";
            saveFileDialog.FileName = "Untitled";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileAsImage(saveFileDialog.FileName);
            }

        }

        private void OpenPNGImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.png) |  *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MainForm.CreateTopLevelWindow(dlg.FileName, true);
                    bmpList.Add(new Bitmap(dlg.FileName));

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        
    }
    }

