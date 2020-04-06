using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Assignment_Module_7
{
    [Serializable]
    public class Document : IEnumerable<Text>
    {
        public List<Text> TextDoc { get; private set; } 

        public Document()
        {
            TextDoc = new List<Text>();
        }

        
        public void SendToFront(Text text)
        {
            int index = TextDoc.IndexOf(text);
            for (int i = index; i < TextDoc.Count; i++)
            {
                IncreaseZOrder(text);
            }
        }

        public void SendToBack(Text text)
        {
            int index = TextDoc.IndexOf(text);
            for (int i = index; i > 0; i--)
            {
                DecreaseZOrder(text);
            }
        }
        
        public void IncreaseZOrder(Text text)
        {
            int sourceIndex = TextDoc.IndexOf(text);
            int targetIndex = (sourceIndex < TextDoc.Count - 1 ) ? sourceIndex + 1 : sourceIndex;
            SwapTextOrder(sourceIndex, targetIndex);
        }
        public void DecreaseZOrder(Text text)
        {
            int sourceIndex = TextDoc.IndexOf(text);
            int targetIndex = (sourceIndex > 0) ? sourceIndex - 1 : 0;
            SwapTextOrder(sourceIndex, targetIndex);
        }


        private void SwapTextOrder(int sourceIndex, int targetIndex)
        {
            Text temp = TextDoc[sourceIndex];
            TextDoc[sourceIndex] = TextDoc[targetIndex];
            TextDoc[targetIndex] = temp;
        }

        public void AddText(Text singleText)
        {   
            TextDoc.Add(singleText);
        }

        public void RemoveText(Text singleText)
        {
            TextDoc.Remove(singleText);
        }

        public void AddTexts(List<Text> listOfTextOb)
        {
            foreach (Text text in listOfTextOb)
            {
                TextDoc.Add(text);
            }
        }

        public Text this[int i]
        {
            get { return TextDoc[i]; }
            set { TextDoc[i] = value; }
        }
        

        public int Count
        {
            get { return TextDoc.Count; }
        }

        public Text GetLast
        {
            get { return TextDoc[TextDoc.Count - 1]; }

        }

        public IEnumerator<Text> GetEnumerator()
        {
            return TextDoc.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Drags all the shapes in the document array. Used by main form
        /// </summary>
        /// <param name="g"></param>
        public void DrawAll(Graphics g)
        {
            int i = 0;
            foreach(Text txt in TextDoc)
            {
                txt.DrawSingle(g);
            }
        }

        /// <summary>
        /// Draws a single text object in the document array. used internally
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        private void DrawSingle(Graphics g, int i)
        {
            //gets properties from the text object
            Font textFont = TextDoc[i].Textfont;    
            SolidBrush textColor = new SolidBrush(TextDoc[i].TextColor); 
            SolidBrush textBackColor = new SolidBrush(TextDoc[i].BackColor); 
            float rotationAngle = TextDoc[i].RotationAngle;
            SizeF textSize = g.MeasureString(TextDoc[i].TextString, textFont);  //measure the size of the text
            RectangleF rec = new RectangleF(TextDoc[i].Location, textSize); //uses size of text and location for the rectangle to be drawn

            StringFormat drawformat = new StringFormat();
            drawformat.Alignment = StringAlignment.Near;

            GraphicsState oldState = g.Save();

            //TransformGraphics(g, rotationAngle, rec); 

            g.FillRectangle(textBackColor, rec);
            g.DrawString(TextDoc[i].TextString, textFont, textColor, rec, drawformat);

            g.Restore(oldState);

        }

        public void DrawSelection(Graphics g, Text txt)
        {
            Font textFont = txt.Textfont;
            SizeF textSize = g.MeasureString(txt.TextString, textFont);
            RectangleF rec = new RectangleF(txt.Location, textSize);
            SolidBrush highlight = new SolidBrush(Color.DarkGreen);
            float rotationAngle = txt.RotationAngle;

            Pen p = new Pen(highlight, 3);
            GraphicsPath path = new GraphicsPath();
            StringFormat drawformat = new StringFormat();


            path.AddRectangle(rec);
            txt.TransformGraphics(g, rotationAngle, rec);
            g.DrawPath(p, path);
        }


    }
}   
