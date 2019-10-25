using System.Drawing;
using VirtualProxy__System_A_;

namespace VirtualProxy
{
    class ProxyImage : MyImage
    {
        private string _name;
        private RealImage _image;

        public ProxyImage(string name)
        {
            _name = name;
        }

        public void Draw(Graphics graphics, Point position)
        {
            // lazy loading
            if (_image == null)
                _image = new RealImage(_name);

            _image.Draw(graphics, position);
        }
    }
}
