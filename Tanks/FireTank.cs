using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{   
    /// <summary>
    /// Tworzenie czowga który podbity i pala
    /// </summary>
    class FireTank
    {
        FireTankImg ftImg = new FireTankImg();
        Image curentImg;
        /// <summary>
        /// Zwraca konkretne zdjęcia
        /// </summary>
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
        /// <summary>
        /// Przypisanie koordynat do podbitego czowga.
        /// </summary>
        /// <param name="x">Koordynata</param>
        /// <param name="y">Koordynata</param>
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
        /// <summary>
        /// Wyłoluje potrzebne zdjęcie Fire Tank, na miejscu podbitego czowga
        /// </summary>
        protected void PutCurentImage()
        {
            curentImg = img[k];
            k++;
            if (k == 6)
                k = 0;
        }
    }
}
