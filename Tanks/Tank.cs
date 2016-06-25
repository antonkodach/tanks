using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun, ITurn, ITurnAround, ITransparent, ICurentPicture // W tym klasie przedstawiona logika, która odpowiada za przedstawienia naszego czołga, za jego ruch,
    {                                                                   //za otnoszenia z innymi czołgami.
        private TankImg tankImg = new TankImg();
        private void PutImg() //Roztawia zdjecia w naszej gre
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
        protected Image curentImg; // Konkretne zdjecia czołga
        protected int k;
        /// <summary>
        /// Wywołuje konkretnie zdjęcia czowga 
        /// </summary>
        protected void PutCurentImage() //Виводе конкретні зображення танка підряд
        {
            curentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }
        protected int sizeField;
        protected int x, y, direct_x, direct_y; //direct_x, direct_y - zmiana ruchu czołga
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizeField">rozmiar pola</param>
        /// <param name="x">koordynata czowga</param>
        /// <param name="y">koordynata czowga</param>
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
        /// <summary>
        /// Metoda zwraca konkretne zdjęcia
        /// </summary>
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
        /// <summary>
        /// Metoda, która  rucha nasze czowgi
        /// </summary>
        public void Run() //метода, яка рухає наші танки// Метод Run i метод Turn нерозривно зязані між собою, бо саме вони задають модель повідєнія танка на полі
        {
            
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn();

            PutCurentImage();
            
            Transparent();
            
        }
        /// <summary>
        /// Odpowiada za skręcanie czowgów
        /// </summary>
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
        /// <summary>
        /// Metoda odpowiada za to, żeby czowgi mogły jeżdzić przez sciany(W góre wjechaw - z doly wyjechaw, 
        /// w lewu scianu wjechad - z prawej wyjechaw)
        /// </summary>
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
        /// <summary>
        /// Metoda odpowiada za rozkręcenie czowgów przy spotkaniu
        /// </summary>
        public void TurnAround() // Розворот танків при зіткненні
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            PutImg();
        }
    }
}
