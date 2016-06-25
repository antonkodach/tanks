using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    /// <summary>
    /// Tworzenia Pakmena
    /// </summary>
    class Packman : IRun, ITurn, ITransparent, ICurentPicture
    {
        PackmanImg packmanImg = new PackmanImg();
        Image[] img;
        Image curentImg;
        
        
        public Image CurentImg
        {
            get { return curentImg; }
        }

        int sizeField;

        int x, y, direct_x, direct_y, nextDirect_x, nextDirect_y;

        public int NextDirect_y
        {
            get { return nextDirect_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    nextDirect_y = value;
                else nextDirect_y = 0;
            }
        }

        public int NextDirect_x
        {
            get { return nextDirect_x; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    nextDirect_x = value;
                else nextDirect_x = 0;
            }
        }


        public int Direct_x
        {
            get { return direct_x; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_x = value;
                else direct_x = 0;
            }
        }
        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_y = value;
                else direct_y = 0;
            }
        }
        /// <summary>
        /// Pociatkowe koordynaty packmena i koordynaty przy ruchu
        /// </summary>
        /// <param name="sizeField"></param>
        public Packman(int sizeField)
        {
            this.sizeField = sizeField;
            this.x = 120;
            this.y = 240;
            this.NextDirect_x = 0;
            this.NextDirect_y = -1;
            this.Direct_x = 0;
            this.Direct_y = -1;
            PutImg();
            PutCurentImage();
    
        }
        public int Y
        {
            get { return y; }

        }

        public int X
        {
            get { return x; }

        }
        /// <summary>
        /// Metoda która odpowiada za ruch czowga na polu, wyznacz kiedy on porze skręcać
        /// </summary>
        public void Run() //метода, яка рухає наші танки// Метод Run i метод Turn нерозривно зязані між собою, бо саме вони задають модель повідєнія танка на полі
        {
            
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0) // Може повертати виключно на перехресті
                Turn();

            PutCurentImage();

            Transparent();

        }

        int k;
        /// <summary>
        /// Podstawia potrzebne zdjęcia
        /// </summary>
        private void PutCurentImage()
        {
            curentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }
        /// <summary>
        /// Wyznacza kiedy może skręcać Packmen
        /// </summary>
        public void Turn()
        {
            Direct_x = NextDirect_x;
            Direct_y = NextDirect_y;

            PutImg();
        }
        /// <summary>
        /// Metoda która pozwala jeżdzic packmenu przez sciany
        /// </summary>
        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 19)
                x = 1;

            if (y == -1)
                y = sizeField - 21;
            if (y == sizeField - 19)
                y = 1;
        }
        /// <summary>
        /// Przy skręceniu Packmena podstawia potrzebne zdjęcia
        /// </summary>
        void PutImg()
        {
            if (direct_x == 1)
                img = packmanImg.Right;
            if (direct_x == -1)
                img = packmanImg.Left;
            if (direct_y == 1)
                img = packmanImg.Down;
            if (direct_y == -1)
                img = packmanImg.Up;

        }
    }
}
