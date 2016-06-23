using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun, ITurn, ITurnAround, ITransparent, ICurentPicture // В цьому класі представлена вся логікаб яка відповідає за представлення нашого танка, за його переміщення,
    {                                                                   //за взаємодію його з іншими обєктами.
        private TankImg tankImg = new TankImg();
        private void PutImg() //розтавляє картінки по грі
        {
            if (direct_x == 1)
                img = tankImg.Right;
            if (direct_x == -1)
                img = tankImg.Left;
            if (direct_y == 1)
                img = tankImg.Down;
            if (direct_y == -1)
                img = tankImg.Up;

        }


        protected Image[] img;
        protected Image curentImg; // Конкретне зображення з таблиці картінок танка.
        protected int k;
        protected void PutCurentImage() //Виводе конкретні зображення танка підряд
        {
            curentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }
        protected int sizeField;
        protected int x, y, direct_x, direct_y; //переменниє двіженія танка (последние две)
        protected static Random r;

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

        public Tank(int sizeField, int x, int y)
        {
            this.sizeField = sizeField;
            
            r = new Random();
            if (r.Next(5000) < 2500)
            {
                Direct_y = 0;
            loop:
                Direct_x = r.Next(-1, 2);
                if (Direct_x == 0)
                    goto loop;
            }
            else
            {
                Direct_x = 0;
            loop:
                Direct_y = r.Next(-1, 2);
                if (Direct_y == 0)
                    goto loop;
            }
            PutImg();
            PutCurentImage();

            this.x = x;
            this.y = y;
        }

        public Image CurentImg
        {
            get { return curentImg; }
        }
        public int Y
        {
            get { return y; }
           
        }
        public int X
        {
            get { return x; }
           
        }
        public void Run() //метода, яка рухає наші танки// Метод Run i метод Turn нерозривно зязані між собою, бо саме вони задають модель повідєнія танка на полі
        {
            
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn();

            PutCurentImage();
            
            Transparent();
            
        }
        public void Turn() //повороти танка
        {                        
                if (r.Next(5000) < 2500) // рухаємося далі по аертикалі
                {
                    if (Direct_y == 0)
                      
                        direct_x = 0;
                        while (Direct_y == 0)
                            Direct_y = r.Next(-1, 2);
                    
                }
                else // рухаємося по горизонталі
                {
                    if (Direct_x == 0)                      
                    {
                        direct_y = 0;
                        while (Direct_x == 0)
                            Direct_x = r.Next(-1,2);
                    }
                }
                
            PutImg();
        }
        public void Transparent() // прозрачність стін( в праву вїхав - з лівох виїхав)
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
        public void TurnAround() // Розворот танків при зіткненні
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            PutImg();
        }
    }
}
