using System;
using System.Drawing;
using System.Windows.Forms;
using VirtualProxy__System_A_;

namespace VirtualProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyImage image1 = new ProxyImage("naruto");
        MyImage image2 = new ProxyImage("narutovssasuke");
        MyImage image3 = new ProxyImage("narutovshinata");
        MyImage image4 = new ProxyImage("naruto_kage_bushin_no_jutsu");

        private void btnDraw_Click(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void pnlDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            UseProxyPattern(e.Graphics);
            //UseNormalWay(e.Graphics);
        }

        private void UseProxyPattern(Graphics graphics)
        {
            switch (cbbImageName.Text)
            {
                case "naruto":
                    image1.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovssasuke":
                    image2.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovshinata":
                    image3.Draw(graphics, new Point(0, 0));
                    break;
                case "naruto_kage_bushin_no_jutsu":
                    image4.Draw(graphics, new Point(0, 0));
                    break;
                default: break;
            }
        }

        private void UseNormalWay(Graphics graphics)
        {
            MyImage image;
            switch (cbbImageName.Text)
            {
                case "naruto":
                    image = new RealImage(cbbImageName.Text);
                    image.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovssasuke":
                    image = new RealImage(cbbImageName.Text);
                    image.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovshinata":
                    image = new RealImage(cbbImageName.Text);
                    image.Draw(graphics, new Point(0, 0));
                    break;
                case "naruto_kage_bushin_no_jutsu":
                    image = new RealImage(cbbImageName.Text);
                    image.Draw(graphics, new Point(0, 0));
                    break;
                default: break;
            }
        }
    }
}
