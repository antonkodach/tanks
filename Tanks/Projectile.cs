﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Tanks
{
    /// <summary>
    /// Tworzenie kuli dla packmena(strelia packmen kulami)
    /// </summary>
    class Projectile
    {
        private ProjectileImg projectileImg = new ProjectileImg();
        private int km; //Odległosć na któru leci Projektitle
        private Image img;
        public Image Img
        {
            get { return img; }
            set { img = value; }
        }

        int x, y, direct_x, direct_y;
        /// <summary>
        /// Kulia leci i znika
        /// </summary>
        public Projectile()
        {
            img = projectileImg.Up;
            DefaultSetting();
        }

        public void DefaultSetting()
        {
            x = y = -10;
            Direct_x = Direct_y = 0;
            km = 0;
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
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
        /// Odpowiada za ruch kuli, Wyznacza na jaku odległać leci kula
        /// </summary>
        public void Run()
        {
            if (Direct_x == 0 && Direct_y == 0)
                return;
            km +=3;
            PutImg();
            x += Direct_x*3;
            y += Direct_y*3;
            if (km > 120) // Dalnist poliotu snariadu
                DefaultSetting();
        }
        /// <summary>
        /// Podstawia zdjęcia po kolejnici przy ruchu w kazdą strone
        /// </summary>
        private void PutImg()
        {
            if (direct_x == 1)
                img = projectileImg.Right;
            if (direct_x == -1)
                img = projectileImg.Left;
            if (direct_y == 1)
                img = projectileImg.Down;
            if (direct_y == -1)
                img = projectileImg.Up;

        }
    }
}
