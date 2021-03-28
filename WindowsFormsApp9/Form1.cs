using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{

    public partial class Form1 : Form
    {
        Graphics graphics_context;
        Pen outline;
        SolidBrush fillColor;
        public Form1()
        {
            InitializeComponent();
            graphics_context = this.CreateGraphics();
            outline = new Pen(Color.Red, 2);
            fillColor = new SolidBrush(Color.Green);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"X:{e.X} Y:{e.Y}";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn)
            {
                switch (btn.Text)
                {
                    case "Line":
                        {
                            //graphics_context.DrawLine(outline, 150, 10, 250, 100);
                            break;
                        }
                    case "Circle":
                        {
                            //graphics_context.DrawEllipse(outline, 300, 10, 50, 50);
                            //graphics_context.FillEllipse(fillColor, 300, 10, 50, 50);
                            break;
                        }
                    case "Rectangle":
                        {
                            //graphics_context.DrawRectangle(outline, 300, 10, 50, 50);
                            //graphics_context.FillRectangle(fillColor, 300, 10, 50, 50);
                            break;
                        }
                    case "Polygon":
                        {
                            Point[] points = new Point[5]
                            {
                                new Point(160,120),
                                new Point(120,180),
                                new Point(190,160),
                                new Point(200,241),
                                new Point(214,180),
                            };
                            graphics_context.FillPolygon(fillColor, points);
                            break;
                        }
                    case "Arc":
                        {
                            Rectangle rectangle = new Rectangle(450, 50, 100, 100);
                            graphics_context.DrawRectangle(outline, 450, 50, 160, 100);
                            graphics_context.DrawArc(outline, rectangle, 90, 180);
                            break;
                        }
                    case "Curve":
                        {
                            Point[] points = new Point[5]
                            {
                                new Point(250,220),
                                new Point(220,280),
                                new Point(290,280),
                                new Point(300,341),
                                new Point(314,280),
                            };

                            graphics_context.FillClosedCurve(fillColor, points);
                            break;
                        }
                    case "Text":
                        {
                            Font font = new Font("Verdana", 20);
                            Point location = new Point(400, 200);
                            StringFormat drawFormat = new StringFormat();
                            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                            graphics_context.DrawString("Hello World", font, fillColor, location, drawFormat);
                            break;
                        }
                    case "Image":
                        {
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = 
                            break;
                        }
                    default:
                        MessageBox.Show("Not Found");
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
