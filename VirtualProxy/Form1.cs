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

            if (useProxyPattern)
                InitProxyImages();
            else InitRealImages();
        }

        private bool useProxyPattern = true;

        private void InitProxyImages()
        {
            proxyImage1 = new ProxyImage("naruto");
            proxyImage2 = new ProxyImage("narutovssasuke");
            proxyImage3 = new ProxyImage("narutovshinata");
            proxyImage4 = new ProxyImage("naruto_kage_bushin_no_jutsu");
        }

        private void InitRealImages()
        {
            realImage1 = new RealImage("naruto");
            realImage2 = new RealImage("narutovssasuke");
            realImage3 = new RealImage("narutovshinata");
            realImage4 = new RealImage("naruto_kage_bushin_no_jutsu");
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            pnlDrawingArea.Invalidate();
        }

        private void pnlDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            if (useProxyPattern)
                UseProxyPattern(e.Graphics);
            else UseNormalWay(e.Graphics);
        }

        MyImage proxyImage1 = null;
        MyImage proxyImage2 = null;
        MyImage proxyImage3 = null;
        MyImage proxyImage4 = null;

        // image will be loaded in the first use
        // fast in the first load our program, but slow in the first we draw an image
        private void UseProxyPattern(Graphics graphics)
        {
            switch (cbbImageName.Text)
            {
                case "naruto":
                    proxyImage1.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovssasuke":
                    proxyImage2.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovshinata":
                    proxyImage3.Draw(graphics, new Point(0, 0));
                    break;
                case "naruto_kage_bushin_no_jutsu":
                    proxyImage4.Draw(graphics, new Point(0, 0));
                    break;
                default: break;
            }
        }

        MyImage realImage1 = null;
        MyImage realImage2 = null;
        MyImage realImage3 = null;
        MyImage realImage4 = null;

        // image always load first without knowing that it will be used or not
        // slow in the first load our program, but fast in the first we draw an image
        private void UseNormalWay(Graphics graphics)
        {
            switch (cbbImageName.Text)
            {
                case "naruto":
                    realImage1.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovssasuke":
                    realImage2.Draw(graphics, new Point(0, 0));
                    break;
                case "narutovshinata":
                    realImage3.Draw(graphics, new Point(0, 0));
                    break;
                case "naruto_kage_bushin_no_jutsu":
                    realImage4.Draw(graphics, new Point(0, 0));
                    break;
                default: break;
            }
        }
    }
}
