using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    /// <summary>
    /// Clas odpowiada za wywolanie potrzebnego, konkretnego zdjęcia dla czowga w pełny moment
    /// </summary>
    class TankImg
    {
        Image[] up = new Image[] {
            Properties.Resources.TankImg0_1, 
            Properties.Resources.TankImg0_11, 
            Properties.Resources.TankImg0_12, 
            Properties.Resources.TankImg0_13,
            Properties.Resources.TankImg0_14 };

       
        Image[] down = new Image[] {
            Properties.Resources.TankImg01, 
            Properties.Resources.TankImg011, 
            Properties.Resources.TankImg012, 
            Properties.Resources.TankImg013,
            Properties.Resources.TankImg014 };

       
        Image[] right = new Image[] { 
            Properties.Resources.TankImg10, 
            Properties.Resources.TankImg101, 
            Properties.Resources.TankImg102, 
            Properties.Resources.TankImg103,
            Properties.Resources.TankImg104 };


        Image[] left = new Image[] { 
            Properties.Resources.TankImg_10, 
            Properties.Resources.TankImg_101, 
            Properties.Resources.TankImg_102, 
            Properties.Resources.TankImg_103,
            Properties.Resources.TankImg_104 };


        public Image[] Up
        {
            get { return up; }  
        }

        public Image[] Down
        {
            get { return down; }
        }

        public Image[] Right
        {
            get { return right; }
        }

        public Image[] Left
        {
            get { return left; }
        }
        
    }
}
