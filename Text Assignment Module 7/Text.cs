using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Text_Assignment_Module_7
//this class is not done yet, basic implementation to continue with project.
{   [Serializable]
    public class Text /*: INotifyPropertyChanged */ 
    {

        //// Declare the event
        //public event PropertyChangedEventHandler PropertyChanged;


        private String textString;      // String of text
        private Color textColor;        // text color
        private Color backColor;        // backcolor of text
        private Point location;         // location
        private Font textFont;          // font of text
        private float rotationAngle;    // angle of rotation 
        private int zIndex;             // for z-order
        private int textIndex;
                            
        public String TextString
        {
            get { return textString;  }
            set { textString = value; }
        }
        
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }
        
        public Point Location
        {
            get { return location; }
            set { location = value;  }
        }

        public Font Textfont
        {
            get { return textFont; }
            set { textFont = value; }
        }

        public Color BackColor { get => backColor; set => backColor = value; }

        public float RotationAngle { get => rotationAngle; set => rotationAngle = value; }

        public int ZIndex { get => zIndex; set => zIndex = value; }
       
        public int TextIndex
        {
            get { return textIndex; }
            set { textIndex = value; }

        }

        public Text(String textString, Color textColor, Color backGround, 
            Point location, Font textFont, int rotationX, int rotationY, float rotationAngle, int zIndex)
        {
            this.textString = textString;
            this.textColor = textColor;
            this.backColor = backGround;
            this.location = location;
            this.textFont = textFont;
            this.RotationAngle = rotationAngle;
            this.ZIndex = zIndex; 
        }
        //for testing purposes

        public Text(Point location)
        {
            this.TextString = "";
            this.TextColor = Color.Black;
            this.BackColor = Color.Transparent;
            this.Location = location;
            this.Textfont = new Font("Arial", 12.0f);
            this.RotationAngle = 0.0f;
            this.ZIndex = 0;

        }

        public Text(string s, Point location)
        {
            this.TextString = s;
            this.TextColor = Color.Black;
            this.BackColor = Color.Transparent;
            this.Location = location;
            this.Textfont = new Font("Arial", 12.0f);
            this.RotationAngle = 0.0f;
            this.ZIndex = 0;

        }

        public Text(String textString, Point location, Color txtcolor, Color txtbackcolor, Font txtfont)
        {
            this.TextString = textString;
            this.TextColor = txtcolor;
            this.BackColor = txtbackcolor;
            this.Location = location;
            this.Textfont = txtfont;   
            this.RotationAngle = 0.0f;
            this.ZIndex = 0;
            
            
        }

        public Text()
        {
            TextString = "";
            this.TextColor = Color.Black;
            this.BackColor = Color.Red;
            this.Location = new Point(100, 100);
            this.Textfont = new Font("Arial", 12.0f);
            this.RotationAngle = 0.0f;
            this.ZIndex = 0;

        }

        public Text(String textString)
        {
            this.textString = textString;
            this.TextColor = Color.Black;
            this.BackColor = Color.Red;
            this.Location = new Point(100, 100);
            this.Textfont = new Font("Arial", 12.0f);
            this.RotationAngle = 0.0f;
            this.ZIndex = 0;
        }

        /// <summary>
        /// Draws a single text object in the document array. used internally
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        public void DrawSingle(Graphics g)
        {
            //gets properties from the text object
            SolidBrush textColor = new SolidBrush(TextColor);
            SolidBrush textBackColor = new SolidBrush(BackColor);
            float rotationAngle = RotationAngle;
            SizeF textSize = g.MeasureString(TextString, Textfont);  //measure the size of the text
            RectangleF rec = new RectangleF(Location, textSize); //uses size of text and location for the rectangle to be drawn

            StringFormat drawformat = new StringFormat();
            drawformat.Alignment = StringAlignment.Near;

            GraphicsState oldState = g.Save();

            TransformGraphics(g, rotationAngle, rec);

            g.FillRectangle(textBackColor, rec);
            g.DrawString(TextString, textFont, textColor, rec, drawformat);

            g.Restore(oldState);

        }

        /// <summary>
        /// custom Method:
        /// Rotates the object around the axis of rotation passed. Code taken from:
        /// https://stackoverflow.com/questions/10210134/using-a-matrix-to-rotate-rectangles-individually
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rotationAngle"></param>
        /// <param name="r"></param>
        public void TransformGraphics(Graphics g, float rotationAngle, RectangleF r)
        {
            using (Matrix m = new Matrix())
            {
                PointF p = new PointF(r.Left + (r.Width / 2), r.Top + (r.Height / 2));
                m.RotateAt(rotationAngle, p);
                g.Transform = m;
            }
        }


    }
}
