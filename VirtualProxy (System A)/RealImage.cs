using System;
using System.Drawing;

namespace VirtualProxy__System_A_
{
    public class RealImage : MyImage
    {
        private string _name;
        private Image _image;

        public RealImage(string name)
        {
            _name = name;
            LoadImage(name);
        }

        private void LoadImage(string name)
        {
            _image = Images.ResourceManager.GetObject(name) as Image;
            Console.WriteLine("Load image: " + _name);
        }

        public void Draw(Graphics graphics, Point position)
        {
            if (graphics == null)
                return;

            Console.WriteLine("Display image: " + _name);
            graphics.DrawImage(_image, position);
        }
    }
}
