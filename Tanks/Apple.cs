using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Apple : IPicture
    {
         AppleImg appleImg = new AppleImg();
        Image img;

        int x, y;

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public Image Img
        {
            get { return img; }           
        }

        public Apple(int x, int y)
        {
            img = appleImg.Img;
            this.x = x;
            this.y = y;
        }
    }
}
