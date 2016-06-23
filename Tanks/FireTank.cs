using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class FireTank
    {
        FireTankImg ftImg = new FireTankImg();
        Image curentImg;

        public Image CurentImg
        {
            get { return curentImg; }
        }

        Image[] img;

        int x, y;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public FireTank(int x, int y)
        {
            this.x = x;
            this.y = y;
            img = ftImg.Img;
            PutCurentImage();
        }

        public void Fire()
        {
            PutCurentImage();
        }

        int k;
        protected void PutCurentImage()
        {
            curentImg = img[k];
            k++;
            if (k == 6)
                k = 0;
        }
    }
}
