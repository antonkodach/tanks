using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    /// <summary>
    /// Clas Tworzy obiekt Huntera
    /// </summary>
    class Hunter : Tank
    {

        HunterImg hunterImg = new HunterImg();
        /// <summary>
        /// Naskrzyrzowaniu wyłoluje potrzebne zdjęcie
        /// </summary>
        private void PutImg()
        {
            if (direct_x == 1)
                img = hunterImg.Right;
            if (direct_x == -1)
                img = hunterImg.Left;
            if (direct_y == 1)
                img = hunterImg.Down;
            if (direct_y == -1)
                img = hunterImg.Up;
        }
        /// <summary>
        /// Skręcenia Huntera
        /// </summary>
        /// <param name="target_x">koordynata Hunter</param>
        /// <param name="target_y">koordynata Huntera</param>
        public void Turn(int target_x, int target_y) //Координати Пакмена
        {
            Direct_x = Direct_y = 0;
            if (X > target_x)
                Direct_x = -1;
            if (X < target_x)
                Direct_x = 1;
            if (Y > target_y)
                Direct_y = -1;
            if (Y < target_y)
                Direct_y = 1;

            if (Direct_x != 0 && Direct_y != 0)
                if (r.Next(5000) < 2500)
                    Direct_x = 0;
                else
                    Direct_y = 0;

            PutImg();
        }
        /// <summary>
        /// Metoda odpowiada za ruch Huntera
        /// </summary>
        /// <param name="target_x"></param>
        /// <param name="target_y"></param>
        public void Run(int target_x, int target_y)
        {

            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn(target_x,target_y);

            PutCurentImage();

            Transparent();
        }
        /// <summary>
        /// Rozkrecenia Huntera przy spotkaniu z innymi czowgami
        /// </summary>
        new public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            PutImg();
        }
        /// <summary>
        /// Bazowa realizacja konstruktora z trzema parametramy
        /// </summary>
        /// <param name="sizeField"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Hunter(int sizeField, int x, int y) 
            : base(sizeField, x, y) // базова реалізація конструктора яка приймає 3 параметри
        {
            Direct_y = -1; 
            Direct_x = 0; 
            PutImg(); 
            PutCurentImage(); 
        }
    }
}
