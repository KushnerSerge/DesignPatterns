using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProxy
{
    public class ProxyImage : IImage
    {
        private RealImage realImage = null;
        private string Filename { get; set; }
        public ProxyImage(string filename)
        {
            Filename = filename;
        }
        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(Filename);
            }
            realImage.DisplayImage();
        }
    }
}
