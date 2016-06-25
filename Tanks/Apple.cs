using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{   
    /// <summary>
    /// Klas odpowiada za tworzenie obiektu(jabłka)
    /// </summary>
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
        /// <summary>
        /// Przypisanie, gdzie będzie wyłolane jabłko 
        /// </summary>
        /// <param name="x">koordynata jabłka</param>
        /// <param name="y">koordynata jabłka</param>
        public Apple(int x, int y)
        {
            img = appleImg.Img;
            this.x = x;
            this.y = y;
        }
    }
}
