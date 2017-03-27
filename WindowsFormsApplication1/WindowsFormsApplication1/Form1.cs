using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        

        GraphicsPath gp = new GraphicsPath();
        GraphicsPath gp2 = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(700, 520);
        }
       /// Rectangle r = new Rectangle(20, 20, 640, 440);
        Rectangle r2 = new Rectangle(300, 220, 60, 40);
        SolidBrush b = new SolidBrush(Color.Green);
        SolidBrush b2 = new SolidBrush(Color.White);
        SolidBrush b3 = new SolidBrush(Color.Yellow);
        Pen p = new Pen(Color.Yellow);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gp.AddLine(360, 220, 330, 200);
            gp.AddLine(300, 220, 300, 200);
            gp.AddLine(300, 260, 330, 280);
            gp.AddLine(330, 280, 360, 260);
            e.Graphics.FillPath(b3, gp);

            e.Graphics.FillEllipse(b2, 70, 100, 20, 20);
            e.Graphics.FillEllipse(b2, 270, 100, 20, 20);
            e.Graphics.FillEllipse(b2, 550, 130, 20, 20);

            e.Graphics.FillEllipse(b2, 400, 380, 20, 20);
            e.Graphics.FillEllipse(b2, 170, 400, 20, 20);
            e.Graphics.FillEllipse(b2, 610, 400, 20, 20);
            e.Graphics.FillRectangle(b3, r2);

            Point[] poins = {
                                new Point (340,100),
             
                                new Point (320,140),
                                 new Point (300,160),
                                 new Point (380,160),
                                 new Point (360,100),
                                
                    
                            };
            e.Graphics.FillClosedCurve(b, poins);

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor  = Color.SlateBlue;
           
        }
    }
}
